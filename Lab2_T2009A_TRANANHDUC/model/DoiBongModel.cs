using System;
using Lab2_T2009A_TRANANHDUC.entity;
using Lab2_T2009A_TRANANHDUC.util;
using MySql.Data.MySqlClient;

namespace Lab2_T2009A_TRANANHDUC.model
{
    public class DoiBongModel
    {
        public DoiBong ThemDoiBong(DoiBong doiBong)
        {
            doiBong.CreateAt = DateTime.Now;
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"insert into doi_bong (ma, ten, hlv, create_at) value( '{doiBong.MaDoiBong}','{doiBong.TenDoiBong}', '{doiBong.HuanLuyenVien}', '{doiBong.CreateAt}')";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                return doiBong;
            }
            DbConnection.Instance().CloseConnection();
            return null;
        }

        public DoiBong SuaDoiBong(DoiBong doiBong)
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"update doi_bong set ten ='{doiBong.TenDoiBong}', hlv ='{doiBong.HuanLuyenVien}' where ma ='{doiBong.MaDoiBong}'";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            var result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                return doiBong;
            }

            return null;
        }

        public DoiBong XemThongTin()
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"select * from doi_bong";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DoiBong _doiBong = new DoiBong();
                        int ma = reader.GetOrdinal("ma");
                        _doiBong.MaDoiBong = reader.GetString(ma);

                        int ten = reader.GetOrdinal("ten");
                        _doiBong.TenDoiBong = reader.GetString(ten);

                        int hlv = reader.GetOrdinal("hlv");
                        _doiBong.HuanLuyenVien = reader.GetString(hlv);

                        Console.WriteLine(
                            $"|{_doiBong.MaDoiBong,20}{"",10}|{_doiBong.TenDoiBong,20}{"",10}|{_doiBong.HuanLuyenVien,20}{"",10}|");
                    }
                }
            }
            DbConnection.Instance().CloseConnection();
            return null;
        }
    }
}