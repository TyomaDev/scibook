using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scibook
{
    public partial class addArticle : Form
    {
        public addArticle()
        {
            InitializeComponent();
        }
        private void addArticle_Load(object sender, EventArgs e)
        {
            string a = mainphotoTextBox.Text;
            try {
                this.articalsTableAdapter.Fill(this.dataSet1.articals);
                
            } catch {

                
            }
            
            try
            {
                pictureBox1.Image = Image.FromFile(a);
            }
            catch (Exception ex)
            {

                
            }
        }
        private void articalsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.articalsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
                label1.Text = " ";
                string a = mainphotoTextBox.Text;
                pictureBox1.Image = Image.FromFile(a);

            }
            catch
            {

                label1.Text = "Ошибка!";

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pretitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pretitleLabel_Click(object sender, EventArgs e)
        {

        }

        // Добавление
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.articalsBindingSource.AddNew();
                label1.Text = " ";
            }
            catch
            {
                label1.Text = "Ошибка добавления!";
            }
        }
        // Сохранение изменений  
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.articalsBindingSource.EndEdit();
                this.articalsTableAdapter.Update(dataSet1);
                label1.Text = " ";
            }
            catch
            {
                label1.Text = "Ошибка сохранения!";
            }
        }

        private void articalsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                try
                {
                    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {


                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                        mainphotoTextBox.Text = openFileDialog.FileName;
                    }
                }
                catch { label1.Text = "Ошибка  добавления фотографии!"; }
              
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Удаление
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.articalsBindingSource.RemoveCurrent();
                this.articalsBindingSource.EndEdit();
                this.articalsTableAdapter.Update(dataSet1.articals);
                dataSet1.User.AcceptChanges();
                label1.Text = " ";

            }
            catch
            {
                label1.Text = "Ошибка удаления!";
            }
        }
    }
}
