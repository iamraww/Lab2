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

        public LichThiDau LayTen(string maTranDau)
        {
            LichThiDau lichThiDau = new LichThiDau();
            DbConnection.Instance().OpenConnection();
            var sqlQuery = $"SELECT * FROM lich_thi_dau " +
                           $"where ma_tran_dau = '{maTranDau}' ";
                            var cmd = new MySqlCommand(sqlQuery, DbConnection.Instance().Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int tenDoi1 = reader.GetOrdinal("ten_doi_1");
                        lichThiDau.TenDoi1 = reader.GetString(tenDoi1);
                        
                        int tenDoi2 = reader.GetOrdinal("ten_doi_2");
                        lichThiDau.TenDoi2 = reader.GetString(tenDoi2);
                        return lichThiDau;
                    }
                }
            }
            return null;
        }
    }
}