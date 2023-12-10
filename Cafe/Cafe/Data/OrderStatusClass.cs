using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Data
{
    class OrderStatusClass
    {
        static public DataTable dtOrderStatus = new DataTable();
        // это метод подключения данных к данным для datatable Users
        static public void GetOrderStatus()
        {
            try
            {
                DBConnection.msCommand.CommandText = "SELECT * FROM orderstatus";
                dtOrderStatus.Clear();
                DBConnection.msDataAdapter.SelectCommand = DBConnection.msCommand;
                DBConnection.msDataAdapter.Fill(dtOrderStatus);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
