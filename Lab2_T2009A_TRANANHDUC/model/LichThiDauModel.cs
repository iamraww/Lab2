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
                $"update lich_thi_dau set ngay ='{lichThiDau.NgayThiDau}'" +
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
                        

                        int ngay = reader.GetOrdinal("ngay");
                        lichThiDau.NgayThiDau = reader.GetString(ngay);

                        int gio = reader.GetOrdinal("gio");
                        lichThiDau.GioThiDau = reader.GetString(gio);

                        int san = reader.GetOrdinal("san");
                        lichThiDau.SanThiDau = reader.GetString(san);
                        Console.WriteLine(
                            $"|{lichThiDau.MaTranDau,20}{"",10}|{lichThiDau.NgayThiDau,20}{"",10}|{lichThiDau.NgayThiDau,20}{"",10}|{lichThiDau.SanThiDau,20}{"",10}|");
                    }
                }
            }

            DbConnection.Instance().CloseConnection();
            return null;
        }

        public LichThiDau TaoLichThiDau(LichThiDau lichThiDau)
        {
            lichThiDau.CreateAt = DateTime.Now;
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"insert into lich_thi_dau (ma_tran_dau , ma_doi_1 ,ten_doi_1, ma_doi_2, ten_doi_2, gio, ngay, san, create_at) " +
                $"value ('{lichThiDau.MaTranDau}', '{lichThiDau.MaDoi1}', '{lichThiDau.TenDoi1}', " +
                $"'{lichThiDau.MaDoi2}', '{lichThiDau.TenDoi2}' ," +
                $"'{lichThiDau.GioThiDau}', '{lichThiDau.NgayThiDau}','{lichThiDau.SanThiDau}','{lichThiDau.CreateAt}')";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                return lichThiDau;
            }
            DbConnection.Instance().CloseConnection();
            return null;
        }
    }
}