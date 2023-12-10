using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    internal class Authorization
    {
        static public string Role, User;

        static public void Authorizations(string login, string password)
        {
            try
            {
                DBConnection.msCommand.CommandText = @"SELECT accessuser FROM users WHERE username = '" + login + "' and passuser = '" + password + "'";
                Object result = DBConnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    Role = result.ToString();
                    User = login;
                }
                else
                {
                    Role = null;
                }
            }
            catch
            {
                Role = User = null;
                MessageBox.Show("Ошибка авторизации!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
