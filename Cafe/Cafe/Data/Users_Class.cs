using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    class Users_Class
    {
        static public DataTable dtUsers = new DataTable();
        // это метод подключения данных к данным для datatable Users
        static public void GetUsers()
        {
            try
            {
                DBConnection.msCommand.CommandText = "SELECT * FROM users";
                dtUsers.Clear();
                DBConnection.msDataAdapter.SelectCommand = DBConnection.msCommand;
                DBConnection.msDataAdapter.Fill(dtUsers);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
