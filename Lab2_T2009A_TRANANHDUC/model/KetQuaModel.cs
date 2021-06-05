using System;
using Lab2_T2009A_TRANANHDUC.entity;
using Lab2_T2009A_TRANANHDUC.util;
using MySql.Data.MySqlClient;

namespace Lab2_T2009A_TRANANHDUC.model
{
    public class KetQuaModel
    {
        private KetQua _ketQua = new KetQua();
        private LichThiDau _lichThiDau = new LichThiDau();
        
        public KetQua XemKetQua()
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"select * FROM lich_thi_dau " +
                $"LEFT JOIN doi_bong";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ma = reader.GetOrdinal("ma_tran_dau");
                        _lichThiDau.MaTranDau = reader.GetString(ma);
                        
                        
                        int ketQua = reader.GetOrdinal("ket_qua");
                        _ketQua.KetQuaDau = reader.GetString(ketQua);
                        
                        Console.WriteLine(
                            $"|{_lichThiDau.MaTranDau,20}{"",10}" +
                            $"|{_ketQua.KetQuaDau,20}{"",10}|");
                    }
                }
            }

            DbConnection.Instance().CloseConnection();
            return null;
        }

        public KetQua ThemKetQua(KetQua ketQua, string maTranDau)
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery = $"update lich_thi_dau set ket_qua ='{ketQua.KetQuaDau}', status={ketQua.Status} " +
                                $"where ma_tran_dau ={maTranDau}";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                return ketQua;
            }
            return null;
        }
    }
}