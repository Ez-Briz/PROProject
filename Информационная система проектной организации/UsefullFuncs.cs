using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Mail;
using System.Net;

namespace Информационная_система_проектной_организации
{
    class UsefullFuncs
    {
        public readonly Color moveUpColor = Color.Gray;
        public readonly Color moveDownColor = Color.DarkSlateGray;
        public bool IsPassValid(string str)
        {
            if (str.Length <= 4)
                return false;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == ' ' || str[i] == '\\' || str[i] == '%' || str[i] == '.' || str[i] == '!' ||
                    str[i] == ';' || str[i] == ':' || str[i] == '_' || str[i] == '/' || str[i] == ',' || str[i] == '%')
                    return false;
            }
            return true;
        }
        public bool IsAlreadyInUse(string login, SqlConnection connect)
        {
            try
            {
                connect.Open();
                string sql = "SELECT [UserName] FROM [User] WHERE [UserName] = @Login";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@Login", login);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    connect.Close();
                    return true;
                }
                dr.Close();
                connect.Close();
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State != System.Data.ConnectionState.Closed)
                {
                    connect.Close();
                }
            }
            return false;
        }

        public int CheckForSpace(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    return i;
            }
            return -1;
        }

        public bool SendMail(string Message, string email, string subject)
        {
            try
            {
                MailAddress from = new MailAddress("skypeformyass@gmail.com", "Projects Corp.");
                MailAddress to = new MailAddress(email.ToLower());
                MailMessage message = new MailMessage(from, to);
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = Message;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("skypeformyass@gmail.com", ""); // Any mail
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
