using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp = iTextSharp.text;

namespace scibook
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
            
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.userBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
                label1.Text = " ";
                pictureBox1.Image = Image.FromFile(@avatarTextBox.Text);
                
            }
            catch {
            
                label1.Text = "Ошибка!";
               
            }
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.User' table. You can move, or remove it, as needed.
            try
            {
                this.userTableAdapter.Fill(this.dataSet1.User);
                
            }
            catch {
                label1.Text = "Ошибка связанная с БД!!";
            }

            string a = avatarTextBox.Text;
            try
            {
                pictureBox1.Image = Image.FromFile(a);
            }
            catch{}
           
           
        }

        private void user_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // добавить нового пользователя
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.userBindingSource.AddNew();
                label1.Text = " ";
            }
            catch
            {
                label1.Text = "Ошибка работы с БД!!";
            }
        }

        // сохранить изменения
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.userBindingSource.EndEdit();
                this.userTableAdapter.Update(dataSet1);
                label1.Text = " ";
            }
            catch
            {
                label1.Text = "Ошибка работы с БД!!";
            }
        }

        // Удалить
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.userBindingSource.RemoveCurrent();
                this.userBindingSource.EndEdit();
                this.userTableAdapter.Update(dataSet1.User);
                dataSet1.User.AcceptChanges();
                label1.Text = " ";

            }
            catch
            {
                label1.Text = "Ошибка работы с БД!";
            }
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                try {
                    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                        avatarTextBox.Text = openFileDialog.FileName;
                    }
                } 
                catch { label1.Text = "Ошибка добавления фотографии!"; }
               
            }
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = avatarTextBox.Text;
            try
            {
                pictureBox1.Image = Image.FromFile(a);
            }
            catch { }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void userBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            string a = avatarTextBox.Text;
            try
            {
                pictureBox1.Image = Image.FromFile(a);
            }
            catch { }
        }
    }
}
