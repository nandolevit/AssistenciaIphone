using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;
using System.Net.Mime;
using System.Net.Configuration;
using System.Net;
using ObjTransfer;

namespace AccessDB
{
    public class Email
    {
        MailMessage mail = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        public string smtpEmailFrom { get; set; }
        public string smtpSenha { get; set; }
        public string smtpName { get; set; }
        public string Host { get; set; }

        public Email(string host, string email, string senha, string name)
        {
            smtpEmailFrom = email;
            smtpSenha = senha;
            Host = host;
            smtpName = name;
        }

        private SmtpClient EmailPadrao()
        {
            smtp.Host = Host;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(smtpEmailFrom, smtpSenha);

            return smtp;
        }

        private MailMessage EmailMessage(EmailInfo email)
        {
            mail.From = new MailAddress(smtpEmailFrom, smtpName);

            if (email.emailTo.Length > 0)
                foreach (string item in email.emailTo)
                {
                    string[] novoEmail = FormatarEmail(item);

                    if (novoEmail.Length > 1)
                        mail.To.Add(new MailAddress(displayName: novoEmail[0].Trim(), address: novoEmail[1].Trim()));
                    else
                        mail.To.Add(new MailAddress(address: novoEmail[0].Trim()));
                }

            if (email.emailCC.Length > 0)
                foreach (string item in email.emailCC)
                {
                    string[] novoEmail = FormatarEmail(item);

                    if (novoEmail.Length > 1)
                        mail.CC.Add(new MailAddress(displayName: novoEmail[0].Trim(), address: novoEmail[1].Trim()));
                    else
                        mail.CC.Add(new MailAddress(address: novoEmail[0].Trim()));
                }

            if (email.emailCCo.Length > 0)
                foreach (string item in email.emailCCo)
                {
                    string[] novoEmail = FormatarEmail(item);

                    if (novoEmail.Length > 1)
                        mail.Bcc.Add(new MailAddress(displayName: novoEmail[0].Trim(), address: novoEmail[1].Trim()));
                    else
                        mail.Bcc.Add(new MailAddress(address: novoEmail[0].Trim()));
                    
                }

            mail.Subject = email.emailAssunto;
            mail.Body = email.emailMessage;

            if (email.emailAnexo.Length > 0)
                foreach (string item in email.emailAnexo)
                    mail.Attachments.Add(new Attachment(item));

            return mail;
        }

        private string [] FormatarEmail(string email)
        {
            string[] novoEmail = email.Split('-');
            return novoEmail;
        }

        public bool EnviarEmail(EmailInfo emailInfo)
        {
            SmtpClient smtp = EmailPadrao();
            smtp.Send(EmailMessage(emailInfo));

            return true;
        }
    }
}
