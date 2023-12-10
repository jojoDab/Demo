using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form1 : Form
    {
        static public string loginActive;
        public Form1()
        {
            InitializeComponent();
        }
        // при загрузке формы (необходимо сделать вызывать обработчик события) подключаем базу данных и леоаем поле пароля недоступным для просмотра во время ввода
        private void Form1_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB(); // обращаемся к методу подключения к БД
            textBox2.UseSystemPasswordChar = true;
        }
        // обработчки события при нажалтии на кнопку авторизации
        private void button1_Click(object sender, EventArgs e)
        {    //проверка на то - не пусты ли поля ввода логина и пароля
            if(textBox1.Text != "" && textBox2.Text != "")
            {   // проверка на авторизацию и выбор загрузки формы в зависимости от уровня доступа сотрудника
                Authorization.Authorizations(textBox1.Text, textBox2.Text);
                switch (Authorization.Role)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунта не существует!", "Проверьте данные и попробуйте снова", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    case "1": // что проиходит когда заходит администратор. Решено, что тип доступа 1 будет закреплена за администрацией
                        { //Admin
                            this.Hide();
                            FormAdmin form = new FormAdmin();
                            form.Show();
                            break;
                        }
                    case "2":
                        { // Garcon (офмциант) уровень доступа 2
                            this.Hide();
                            FormGarcon form = new FormGarcon();
                            form.Show();
                            break;
                        }
                    case "3":
                        { // Cook (повар) уровень доступа 3
                            this.Hide();
                            FormGarcon form = new FormGarcon();
                            form.Show();
                            break;
                        }
                }
            } //если поля пустые - выводмм сообщение о необходимости заполнения
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Заполнение полей обязательно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // когда форма закрывается - закрывается всё приложение
        {
            Application.Exit();
        }
    }
}
