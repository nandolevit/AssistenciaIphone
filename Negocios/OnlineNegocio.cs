using System;
using ObjTransfer;
using AccessDB;
using System.Data;


namespace Negocios
{
    public class OnlineNegocio
    {
        private static string EmpConexao { get; set; }

        public OnlineNegocio() { }

        public OnlineNegocio(string conexao)
        {
            EmpConexao = conexao;
        }

        OnlineDB online = new OnlineDB();

        public ChatOnlineColecao ConsultarChatMensagemNova(int chatOn)
        {
            if (online.Conectar(EmpConexao))
            {
                online.AddParametrosMySql("@recebe", chatOn);
                DataTable dataTable = online.dataTableMySql("spConsultarChatMensagemNova");

                if (dataTable != null)
                {
                    ChatOnlineColecao colecao = new ChatOnlineColecao();
                    foreach (DataRow chat in dataTable.Rows)
                    {
                        ChatOnlineInfo chatInfo = new ChatOnlineInfo
                        {
                            chatid = Convert.ToInt32(chat["quant"]),
                            chatmessage = Convert.ToString(chat["uselogin"]) + " (" + Convert.ToInt32(chat["quant"]) + ")",
                            chatidenvio = Convert.ToInt32(chat["chatidenvio"]),
                        };

                        colecao.Add(chatInfo);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public ChatOnlineColecao ConsultarChatNova(ChatOnlineInfo chatOn)
        {
            if (online.Conectar(EmpConexao))
            {
                online.AddParametrosMySql("@ident", chatOn.chatident);
                online.AddParametrosMySql("@recebe", chatOn.chatidrecebe);
                DataTable dataTable = online.dataTableMySql("spConsultarChatNova");

                if (dataTable != null)
                    return PreencherChatOnline(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateChatMessageLida(string ident, int recebe)
        {
            if (online.Conectar(EmpConexao))
            {
                online.AddParametrosMySql("@ident", ident);
                online.AddParametrosMySql("@recebe", recebe);

                return online.ExecutarScalarMySql("spUpdateChatMessageLida");
            }
            return 0;
        }

        public ChatOnlineColecao ConsultarChat(string ident)
        {
            if (online.Conectar(EmpConexao))
            {
                online.AddParametrosMySql("@ident", ident);
                DataTable dataTable = online.dataTableMySql("spConsultarChat");

                if (dataTable != null)
                    return PreencherChatOnline(dataTable);
                else
                    return null;
            }
            return null;
        }


        private ChatOnlineColecao PreencherChatOnline(DataTable dataTable)
        {
            ChatOnlineColecao chatcolecao = new ChatOnlineColecao();
            foreach (DataRow chat in dataTable.Rows)
            {
                ChatOnlineInfo onlineInfo = new ChatOnlineInfo
                {
                    chatdata = Convert.ToDateTime(chat["chatdata"]),
                    chatid = Convert.ToInt32(chat["chatid"]),
                    chatident = Convert.ToString(chat["chatident"]),
                    chatidenvio = Convert.ToInt32(chat["chatidenvio"]),
                    chatidrecebe = Convert.ToInt32(chat["chatidrecebe"]),
                    chatlida = Convert.ToBoolean(chat["chatlida"]),
                    chatmessage = Convert.ToString(chat["chatmessage"])
                };

                chatcolecao.Add(onlineInfo);
            }

            return chatcolecao;
        }

        public int InsertChat(ChatOnlineInfo chat)
        {
            if (online.Conectar(EmpConexao))
            {
                online.AddParametrosMySql("@envio", chat.chatidenvio);
                online.AddParametrosMySql("@recebe", chat.chatidrecebe);
                online.AddParametrosMySql("@message", chat.chatmessage);
                online.AddParametrosMySql("@ident", chat.chatident);

                return online.ExecutarScalarMySql("spInsertChat");
            }
            else
                return 0;
        }

        public UserLoginColecao ConsultarUserOnline()
        {
            //esse método é exclusivo para o chat online, possui um método de conexão exclusiva
            if (online.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                dataTable = online.dataTableMySql("spConsultarUserOnline");
                if (dataTable != null)
                    return PreencherUserLoginColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertUserLogin(UserInfo userInfo)
        {
            if (online.Conectar(EmpConexao))
            {
                online.AddParametrosMySql("@id", userInfo.useid);

                return online.ExecutarScalarMySql("spInsertUserLogin");
            }
            else
                return 0;
        }

        public int UpdateUserLogin(int userLogin)
        {
            if (online.Conectar(EmpConexao))
            {
                online.AddParametrosMySql("@id", userLogin);
                return online.ExecutarScalarMySql("spUpdateUserLogin");
            }
            else
                return 0;
        }

        private UserLoginColecao PreencherUserLoginColecao(DataTable dataTable)
        {
            UserLoginColecao colecao = new UserLoginColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                UserLoginInfo user = new UserLoginInfo
                {
                    logindatadeslog = Convert.ToDateTime(row["logindatadeslog"]),
                    logindatalog = Convert.ToDateTime(row["logindatalog"]),
                    loginid = Convert.ToInt32(row["loginid"]),
                    loginiduser = Convert.ToInt32(row["loginiduser"]),
                    loginnome = Convert.ToString(row["uselogin"])
                };

                colecao.Add(user);
            }

            return colecao;
        }

        public UserLoginInfo ConsultarUserLogin(int id)
        {
            if (online.Conectar(EmpConexao))
            {
                online.AddParametrosMySql("@id", id);
                DataTable dataTable = dataTable = online.dataTableMySql("spConsultarUserLogin");
                if (dataTable != null)
                    return PreencherUserLoginColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

    }
}
