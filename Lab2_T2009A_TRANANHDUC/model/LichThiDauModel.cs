using System.Data.SqlClient;
using System;
using Lab2_T2009A_TRANANHDUC.entity;
using Lab2_T2009A_TRANANHDUC.util;
using MySql.Data.MySqlClient;

namespace Lab2_T2009A_TRANANHDUC.model
{
    public class LichThiDauModel
    {
        public LichThiDau SuaLichThiDau(LichThiDau lichThiDau)
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"update doi_bong set tran ='{lichThiDau.Tran}', ngay ='{lichThiDau.NgayThiDau}'" +
                $", gio ='{lichThiDau.GioThiDau}, san ='{lichThiDau.SanThiDau}'' " +
                $"where ma ='{lichThiDau.MaTranDau}'";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                return lichThiDau;
            }

            return null;
        }

        public LichThiDau XemLichThiDau()
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"select * from lich_thi_dau";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        LichThiDau lichThiDau = new LichThiDau();
                        int ma = reader.GetOrdinal("ma_tran_dau");
                        lichThiDau.MaTranDau = reader.GetString(ma);

                        int tran = reader.GetOrdinal("tran");
                        lichThiDau.Tran = reader.GetString(tran);

                        int ngay = reader.GetOrdinal("ngay");
                        lichThiDau.NgayThiDau = reader.GetString(ngay);

                        int gio = reader.GetOrdinal("gio");
                        lichThiDau.NgayThiDau = reader.GetString(gio);

                        int san = reader.GetOrdinal("san");
                        lichThiDau.NgayThiDau = reader.GetString(san);
                        Console.WriteLine(
                            $"|{lichThiDau.MaTranDau,20}{"",10}|{lichThiDau.Tran,20}{"",10}|{lichThiDau.NgayThiDau,20}{"",10}|{lichThiDau.NgayThiDau,20}{"",10}|{lichThiDau.SanThiDau,20}{"",10}|");
                    }
                }
            }

            DbConnection.Instance().CloseConnection();
            return null;
        }

        public LichThiDau TaoLichThiDau(LichThiDau lichThiDau)
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"insert into lich_thi_dau (ma_tran_dau, tran, ngay, gio, san) value ('{lichThiDau.MaTranDau}', " +
                $"'{lichThiDau.Tran}', '{lichThiDau.NgayThiDau}', '{lichThiDau.GioThiDau}','{lichThiDau.SanThiDau}')";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                return lichThiDau;
            }

            return null;
        }
    }
}