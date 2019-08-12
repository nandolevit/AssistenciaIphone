using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AccessDB
{
    public class OnlineDB
    {
        private bool conectado;
        private MySqlParameterCollection mySqlParameterCollection = new MySqlCommand().Parameters;
        public string EmpConexao { get; set; }

        MySqlConnection conn; //acessa o banco online

        public OnlineDB(string empConexao)
        {
            EmpConexao = empConexao;
        }

        public bool ConectarSys()
        {
            DateTime tempo = DateTime.Now;
            int conta = 1; //conta quantas vezes o sistema tentou se conectar sem êxito

            while (true)
            {
                while (tempo <= DateTime.Now)
                {
                    conta++;

                    try
                    {
                        conn = new MySqlConnection(DadosDB.ConexaoSys);

                        conn.Open();
                        conectado = true;
                        return true;
                    }
                    catch (MySqlException)
                    {
                        tempo = DateTime.Now;
                        double sec = 5 * conta;
                        tempo = tempo.AddSeconds(sec);

                        if (conta > 2)
                            return false;
                    }
                }
            }
        }

        public void FecharConexao()
        {
            conn.Close();
            conn.Dispose();
        }

        public bool Conectar()
        {
            try
            {
                conn = new MySqlConnection(EmpConexao);

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
                catch 
                {
                    return false;
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
                catch
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
                    //if (conn.State != ConnectionState.Open)
                    //    conn.Open();

                    da.Fill(dt);
                    //conn.Close();

                    if (dt.Rows.Count > 0)
                        return dt;
                    else
                        return null;
                }
                catch
                {
                    return null;
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
