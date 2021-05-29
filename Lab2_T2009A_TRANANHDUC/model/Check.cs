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

            return false;
        }

        public bool CheckLichThiDau(string ma)
        {
            DbConnection.Instance().OpenConnection();
            var sqlQuery =
                $"select * from lich_thi_dau where ma ='{ma}'";
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
    }
}