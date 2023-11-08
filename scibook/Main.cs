using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scibook
{
    public partial class Main : Form
    {
        public static int userIdVar = 0;
        public static int userRole = 0;
        public static string userFIOVar = "Пользователь не вошел";
        public Main()
        {
            InitializeComponent();
            if (userIdVar > 0)
            {
                button2.Text = "Выйти";
                button1.Hide();
                if (userRole == 1) { 
                    addarticbtn.Visible = true;
                    userbtn.Visible = true;
                }else {

                    addarticbtn.Visible = false;
                    userbtn.Visible = false;
                }
            }
            else
            {
                addarticbtn.Visible = false;
                userbtn.Visible = false;
                button2.Text = "Авторизация";
                button1.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Articles articles = new Articles();
            articles.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userIdVar = 0;
            userFIOVar = "Пользователь не вошел";
            this.Hide();
            authorizathion authorizathion = new authorizathion();
            authorizathion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration registration = new registration();
            registration.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            Help.ShowHelp(this, "..//..//..//Sprawka//helpProject.chm");
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void addarticbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addArticle addarticle = new addArticle();
            addarticle.Show();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            
            addUser adduser = new addUser();    
            adduser.Show();
            this.Hide();
        }
    }
}
