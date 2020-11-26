using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace adatbazisok_beadando
{
    public static class DatabaseAccess
    {
        private const string connetionString = @"datasource=127.0.0.1;port=3306;username=admin;password=WXiqIfzpwO8XHMDK;database=bank;";

        private static MySqlConnection CreateConnection()
        {
            return new MySqlConnection(connetionString);
        }

        private static MySqlCommand CreateCommand(string sql, MySqlConnection connection)
        {
            return new MySqlCommand(sql, connection)
            {
                CommandTimeout = 60
            };
        }

        public static void ExecuteInsert(string sql)
        {
            var connection = CreateConnection();
            var command = CreateCommand(sql, connection);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Az adatbázis nem elérhető.");
                connection.Close();
                return;
            }
            

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Az adatok nem helyesen lettek megadva!");
                connection.Close();
                return;
            }

            connection.Close();
        }

        public static Dictionary<int, List<string>> ExcecuteRead(string sql)
        {
            var connection = CreateConnection();
            var command = CreateCommand(sql, connection);
            var result = new Dictionary<int, List<string>>();

            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Az adatbázis nem elérhető!");
                connection.Close();
                return null;
            }

            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                var schema = reader.GetColumnSchema();
                int counter = 0;
                while (reader.Read())
                {
                    var temp = new List<string>();
                    for (int i = 0; i < schema.Count; i++)
                    {
                        if (schema[i].DataTypeName == "INT")
                        {
                            temp.Add(reader.GetInt32(i).ToString());
                        }
                        else if (schema[i].DataTypeName == "VARCHAR")
                        {
                            temp.Add(reader.GetString(i));
                        }
                        else if (schema[i].DataTypeName == "DATE" || schema[i].DataTypeName == "DATETIME")
                        {
                            temp.Add(reader.GetDateTime(i).ToString());
                        }
                        else if(schema[i].DataTypeName == "FLOAT")
                        {
                            temp.Add(reader.GetFloat(i).ToString());
                        }
                        else if (schema[i].DataTypeName == "DOUBLE")
                        {
                            temp.Add(reader.GetDouble(i).ToString());
                        }
                    }
                    result.Add(counter++, temp);
                }
            }
            else
            {
                MessageBox.Show("No rows found.");
            }
            connection.Close();
            return result;
        }
    }
}
