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
    public partial class authorizathion : Form
    {
        DBconnect dbconect = new DBconnect();
        public authorizathion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var loginUser = loginBox.Text;
                var loginPassword = passBox.Text;
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    string querystring = $"SELECT * FROM [User] WHERE login = '{loginUser}' and password = '{loginPassword}'";
                    SqlCommand command = new SqlCommand(querystring, dbconect.getConnetion());


                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    dbconect.openConnetion();
                    querystring = $"SELECT User_id FROM [User] WHERE login = '{loginUser}' and password = '{loginPassword}'";

                    Main.userIdVar = (int)new SqlCommand(querystring, dbconect.getConnetion()).ExecuteScalar();
                    querystring = $"SELECT Full_name FROM [User] WHERE login = '{loginUser}' and password = '{loginPassword}'";
                    Main.userFIOVar = new SqlCommand(querystring, dbconect.getConnetion()).ExecuteScalar().ToString();
                    querystring = $"SELECT admin_rule FROM [User] WHERE login = '{loginUser}' and password = '{loginPassword}'";
                    Main.userRole = (int)new SqlCommand(querystring, dbconect.getConnetion()).ExecuteScalar();
                    if (dt.Rows.Count == 1)
                    {
                        dbconect.closeConnetion();
                        MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Main main = new Main();
                        this.Close();
                        main.Show();

                    }
                    else
                    {
                        dbconect.closeConnetion();
                        MessageBox.Show("Такого аккаунта не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Вы ввели неправильные данные!", "Ошибка! Вы ввели неправильные данные!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loginUser = loginBox.Text = "";
                    loginPassword = passBox.Text = "";
                }
                
                
             
            }
            catch {
                MessageBox.Show("Что-то пошло не так", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Main main = new Main();
                main.Show();
                this.Close();
            }
        }


    }
}
