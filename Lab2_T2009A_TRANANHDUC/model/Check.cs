using System;
using Lab2_T2009A_TRANANHDUC.entity;
using Lab2_T2009A_TRANANHDUC.util;
using MySql.Data.MySqlClient;

namespace Lab2_T2009A_TRANANHDUC.model
{
    public class Check
    {
        public bool CheckMaDoiBong(string ma)
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"select * from doi_bong where ma ='{ma}'";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
            }
            DbConnection.Instance().CloseConnection();
            return false;
        }

        public bool CheckMaTranDau(string ma)
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"select * from lich_thi_dau where ma_tran_dau ='{ma}'";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CheckTrangThai(string ma)
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"select * from lich_thi_dau where ma_tran_dau ='{ma}'";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int status = reader.GetOrdinal("status");
                        int statusInterger = reader.GetInt32(status);
                        if (statusInterger == 0)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public DoiBong LayTen(string maTranDau)
        {
            DoiBong doiBong = new DoiBong();
            DbConnection.Instance().OpenConnection();
            var sqlQuery =$"SELECT * FROM lich_thi_dau " +
                            $"LEFT JOIN doi_bong " +
                            $"ON lich_thi_dau.ma_tran_dau = '{maTranDau}' " +
                            $"AND (lich_thi_dau.ma_doi_1 = doi_bong.ma OR lich_thi_dau.ma_doi_2 = doi_bong.ma)";
            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int tenDoi = reader.GetOrdinal("ten");
                        doiBong.TenDoiBong = reader.GetString(tenDoi);
                        return doiBong;
                    }
                }
            }
            return null;
        }
    }
}