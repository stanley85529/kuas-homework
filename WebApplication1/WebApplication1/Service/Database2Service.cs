using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Service
{
    public class Database2Service
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\KUAS-1230\WebApplication1\WebApplication1\App_Data\Database2.mdf;Integrated Security=True";
        public List<Models.名稱> LoadAll名稱()
        {
            List<Models.名稱> result = new List<Models.名稱>();

            var connection = new System.Data.SqlClient.SqlConnection(connectionString);
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("", connection);
            command.CommandText = @"
Select * from 名稱s";
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Models.名稱 item = new Models.名稱();

                item.名稱Id = (int)reader["名稱Id"];
                item.Name = reader["Name"].ToString();
                item.Description= reader["Description"].ToString();

                result.Add(item);
            }
            connection.Close();
            return result;
        }


        public List<Models.Albums> LoadAlbumBy名稱ID(int 名稱ID)
        {
            List<Models.Albums> result = new List<Models.Albums>();

            var connection = new System.Data.SqlClient.SqlConnection(connectionString);
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("", connection);
            command.CommandText = string.Format(@"
Select * from Albums where 名稱Id={0}",名稱ID);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Models.Albums item = new Models.Albums();

                item.AlbumID = (int)reader["AlbumId"];
                item.名稱Id = (int)reader["名稱ID"];
                item.金錢花費 = (decimal)reader["金錢花費"];
                item.記事者 = reader["記事者"].ToString();
                item.AlbumArtUrl = reader["AlbumArtUrl"].ToString();
                result.Add(item);
            }
            connection.Close();
            return result;
        }

    }
}