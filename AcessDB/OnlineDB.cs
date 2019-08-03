using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AccessDB
{
    public class OnlineDB
    {
        private bool conectado;
        private MySqlParameterCollection mySqlParameterCollection = new MySqlCommand().Parameters;

        MySqlConnection conn; //acessa o banco online

        public bool ConectarSys()
        {
            return Conectar(DadosDB.ConexaoSys);
        }

        public void FecharConexao()
        {
            conn.Close();
            conn.Dispose();
        }

        public bool Conectar(string empaccess)
        {
            try
            {
                conn = new MySqlConnection(empaccess);

                conn.Open();
                conectado = true;
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }

        }

        private void LimparParametrosMySql()
        {
            mySqlParameterCollection.Clear();
            FecharConexao();
        }

        public void AddParametrosMySql(string nomeParametro, object valorParametros)
        {
            mySqlParameterCollection.Add(new MySqlParameter(nomeParametro, valorParametros));
        }

        public bool ExecutarComandoMySql(string cmdText)
        {
            if (conectado)
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 3600;

                foreach (MySqlParameter mySqlParameter in mySqlParameterCollection)
                    cmd.Parameters.Add(mySqlParameter);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
                finally
                {
                    LimparParametrosMySql();
                }
            }
            else
                return false;
        }

        public int ExecutarScalarMySql(string cmdText)
        {
            if (conectado)
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 3600;

                foreach (MySqlParameter mySqlParameter in mySqlParameterCollection)
                    cmd.Parameters.Add(mySqlParameter);

                try
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (MySqlException)
                {
                    return 0;
                    //throw new Exception("Error: " + ex.Message);
                }
                finally
                {
                    LimparParametrosMySql();
                }
            }
            else
                return 0;
        }

        public DataTable dataTableMySql(string cmdText)
        {
            if (conectado)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3600;

                    foreach (MySqlParameter parameter in mySqlParameterCollection)
                        cmd.Parameters.Add(parameter);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    da.Fill(dt);
                    conn.Close();

                    if (dt.Rows.Count > 0)
                        return dt;
                    else
                        return null;
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
                finally
                {
                    LimparParametrosMySql();
                }
            }
            else
                return null;
        }
    }
}
