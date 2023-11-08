using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scibook
{
   
    public partial class registration : Form
    {
        DBconnect dbconect = new DBconnect();

        public registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string regFIO = nameBox.Text;
            string regUser = loginBox.Text;
            string regPassword = passBox.Text;

            if (checkUser() != true)
            {

                string querystring = $"INSERT INTO [User](Full_name     , login, password) values('{regFIO}','{regUser}','{regPassword}')";
                SqlCommand command = new SqlCommand(querystring, dbconect.getConnetion());

                dbconect.openConnetion();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                    authorizathion authorizathion = new authorizathion();
                    this.Hide();
                    authorizathion.Show();
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!");
                }
                dbconect.closeConnetion();
            }
           

        }

        private Boolean checkUser()
        {
            var regUser = loginBox.Text;
            var regPassword = passBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT * FROM [User] WHERE login = '{regUser}' and password = '{regPassword}'";

            SqlCommand command = new SqlCommand(querystring, dbconect.getConnetion());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
