using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Util.Db
{
    public class mdl
    {
        public MySqlConnection Connection { get { return conn; } }

        public string Connection_String { get { return Connection.ConnectionString; } }

        MySqlConnection conn { get; set; }

        public bool Connect()
        {
            bool _flag = false;
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=SUPERVISOR;pwd=di5t0rti0n;database=triraksa;sslmode=none";
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn = new MySqlConnection("server=localhost;user=SUPERVISOR;pwd=di5t0rti0n;database=triraksa;sslmode=none");
                    conn.Open();
                }
                else
                {
                    conn.Close();
                    conn = new MySqlConnection("server=localhost;user=SUPERVISOR;pwd=di5t0rti0n;database=triraksa;sslmode=none");
                    conn.Open();
                }
                _flag = true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _flag;
        }

        public bool Connect(string Database)
        {
            bool _flag = false;
            conn = new MySqlConnection();
            conn.ConnectionString = $"server=localhost;user=SUPERVISOR;pwd=di5t0rti0n;database={Database};sslmode=none";
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn = new MySqlConnection($"server=localhost;user=SUPERVISOR;pwd=di5t0rti0n;database={Database};sslmode=none");
                    conn.Open();
                }
                else
                {
                    conn.Close();
                    conn = new MySqlConnection($"server=localhost;user=SUPERVISOR;pwd=di5t0rti0n;database={Database};sslmode=none");
                    conn.Open();
                }
                _flag = true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _flag;
        }

        public bool UserAkses(string UserName, string Password, out string refMsg)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $"Select `username` from dbuser Where `Username` = '{UserName}'";
                cmd.Connection = conn;
                if (cmd.ExecuteNonQuery() == 0)
                {
                    refMsg = "User tidak ditemukan / Salah";
                    return false;
                }
                else
                {
                    string key = string.Empty;
                    using (MySqlDataReader reader = new MySqlCommand($"Select `password` from dbuser Where `Username` = '{UserName}'").ExecuteReader())
                    {
                        reader.Read();
                        if (reader[0].ToString() == Password)
                        {
                            refMsg = "Login Sukses";
                            return true;
                        }
                        else
                        {
                            refMsg = "Password Salah";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Exception e = ex;
                refMsg = "Error User Akses Login";
                return false;
            }
        }

        public DataTable OpenTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand(query, conn));
                adapter.Fill(dt);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
