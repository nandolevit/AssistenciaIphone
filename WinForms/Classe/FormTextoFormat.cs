using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
	public class FormTextoFormat
	{
		//criação de delegates de mensagem
		//mensagem de confirmação tipo sim/não
		private delegate DialogResult DelMessageQuestion(string mensagem);
		private static DelMessageQuestion DelQ = new DelMessageQuestion(FormMessage.ShowMessegeQuestion);
		//mensagem de aviso
		private delegate void DelMessgeWarning(string mensagem);
		private static DelMessgeWarning DelW = new DelMessgeWarning(FormMessage.ShowMessegeWarning);
		//messagem de informação
		private delegate void DelMessageInfo(string mensagem);
		private static DelMessageInfo DelI = new DelMessageInfo(FormMessage.ShowMessegeInfo);

        public const string Alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		public static void NovoTextoUpper(TextBox texto)
		{
			NovoTextoTxt(texto);
		}

        public static string PrimeiroNome(string nome)
        {
            string[] compNome = nome.Split(' ');
            string primeiroNome = compNome[0].Substring(0, 1).ToUpper() + compNome[0].Substring(1).ToLower();
            return primeiroNome;
        }
        public static void MoedaFormat(TextBox box)
        {
            if (double.TryParse(box.Text, out double cod))
            {
                string n = string.Empty;
                decimal v = 0;

                n = box.Text.Replace(",", "").Replace(".", "").Replace("R$", "");
                if (string.IsNullOrEmpty(n))
                    n = "";

                n = n.PadLeft(3, '0');
                if (n.Length > 3 && n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);

                v = Convert.ToDecimal(n) / 100;
                box.Text = string.Format("{0:N}", v);
                box.SelectionStart = box.Text.Length;
            }
            else
                box.Text = "0";
        }

        public static void Format3casasdecimais(TextBox box)
        {
            string n = string.Empty;
            decimal v = 0;

            n = box.Text.Replace(",", "").Replace(".", "");
            if (string.IsNullOrEmpty(n))
                n = "";

            n = n.PadLeft(3, '0');
            if (n.Length > 3 && n.Substring(0, 1) == "0")
                n = n.Substring(1, n.Length - 1);

            v = Convert.ToDecimal(n) / 1000;
            box.Text = string.Format("{0:0.000}", v);
            box.SelectionStart = box.Text.Length;
        }

        private static void NovoTextoTxt(TextBox box)
		{
			string novoTexto = string.Empty;
            int cursor = box.SelectionStart;
            novoTexto = box.Text.Substring(0, box.Text.Length - 1);


            for (int i = box.Text.Length - 1; i < box.Text.Length; i++)
			{
				char letra;
                //captura a última letra digitada
                letra = box.Text[box.Text.Length - 1];
				//verifica se há acento e remove
				char novaLetra = RemoveAcentos(letra);
				novoTexto += novaLetra;
			}

			box.Text = novoTexto;
            box.SelectionStart = cursor;
        }


		private static char RemoveAcentos(char l)
		{
			string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
			string semAcentos = "AAAAAAAAAAAEEEEEEEEIIIIIIIIOOOOOOOOOOUUUUUUUCC";
			char letra;

			if (comAcentos.IndexOf(l) != -1)
			{
				int num = comAcentos.IndexOf(l);
				letra = semAcentos[num];
				return letra;
			}
			else
			{
				return letra = l;
			}

		}

		public static bool ValidaEmail(string texto)
		{
            string padrao = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"; //@"(@\w+\.\w+)(\.\w+)*$"; 

            string novoTexto = FormatarEmail(texto).Trim();

            Regex er = new Regex(padrao, RegexOptions.IgnoreCase);

			if (er.IsMatch(novoTexto))
				return true;
			else
			{
				DelW(texto + " EMAIL INVÁLIDO!");
				return false;
			}
		}

        private static string FormatarEmail(string email)
        {
            string[] novoEmail = email.Split('-');

            if(novoEmail.Length > 1)
                return novoEmail[1];
            else
                return novoEmail[0];
        }
    }
}
