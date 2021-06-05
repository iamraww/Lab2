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
                $"SELECT * FROM lich_thi_dau " +
                $"LEFT JOIN ket_qua " +
                $"ON lich_thi_dau.ma_tran_dau = ket_qua.ma_tran_dau ";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ma = reader.GetOrdinal("ma_tran_dau");
                        _lichThiDau.MaTranDau = reader.GetString(ma);
                        
                        int tenDoi1 = reader.GetOrdinal("ten_doi_1");
                        _lichThiDau.TenDoi1 = reader.GetString(tenDoi1);
                        int banThang1 = reader.GetOrdinal("ban_thang_doi_1");
                        _ketQua.GhiBanDoi1 = reader.GetInt32(banThang1);
                        
                        int tenDoi2 = reader.GetOrdinal("ten_doi_2");
                        _lichThiDau.TenDoi2 = reader.GetString(tenDoi2);
                        int banThang2 = reader.GetOrdinal("ban_thang_doi_2");
                        _ketQua.GhiBanDoi2 = reader.GetInt32(banThang2);
                        
                        string dau = $"{_lichThiDau.TenDoi1} - {_lichThiDau.TenDoi2}";
                        string ketQua = $"{_ketQua.GhiBanDoi1} - {_ketQua.GhiBanDoi2}";
                        
                        Console.WriteLine(
                            $"|{_lichThiDau.MaTranDau,20}{"",10}" +
                            $"|{"",10}{dau ,25}" +
                            $"|{"",10}{ketQua,25}");
                    }
                }
            }

            DbConnection.Instance().CloseConnection();
            return null;
        }

        public KetQua ThemKetQua(KetQua ketQua)
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"insert into ket_qua (ma_tran_dau, ban_thang_doi_1,ban_thang_doi_2) value( '{ketQua.MaTranDau}','{ketQua.GhiBanDoi1}', '{ketQua.GhiBanDoi2}')";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                return ketQua;
            }
            DbConnection.Instance().CloseConnection();
            return null;
        }
    }
}