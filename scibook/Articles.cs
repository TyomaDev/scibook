using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace scibook
{
    public partial class Articles : Form
    {
        
        public Articles()
        {
            InitializeComponent();
        }

        

        private void articalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try {
                this.Validate();
                this.articalsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
        catch (Exception ex)
            {
                label1.Text = "Ошибка связи с БД!";
            }

        }
        int nRow;
       
        private void Articles_Load(object sender, EventArgs e)
        {
            try
            { 
                // TODO: This line of code loads data into the 'dataSet1.articals' table. You can move, or remove it, as needed.
                this.articalsTableAdapter.Fill(this.dataSet1.articals);
         
            } catch {  label1.Text = "Ошибка связи с БД!";}

            nRow = articalsDataGridView.CurrentCell.RowIndex;
            string a = main_photoTextBox.Text;
            try
            {
            
                pictureBox1.Image = System.Drawing.Image.FromFile(a);
            }
            catch (Exception ex)
            {
               
            }

        }

        private void articalsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = main_photoTextBox.Text;
            try
            {
               
                pictureBox1.Image = System.Drawing.Image.FromFile(a);
            }
            catch (Exception ex)
            {
               
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (nRow < articalsDataGridView.RowCount)
                {
                    articalsDataGridView.Rows[nRow].Selected = false;
                    articalsDataGridView.Rows[++nRow].Selected = true;
                    articalsDataGridView.CurrentCell = articalsDataGridView.Rows[nRow].Cells[7];
                    try
                    {
                        string a = main_photoTextBox.Text;
                        pictureBox1.Image = System.Drawing.Image.FromFile(a);
                        label1.Text = "";
                    }
                    catch (Exception ex)
                    {
                       
                    }
                }
                else {
                    nRow = 0;
                }
            }
            catch {
                articalsDataGridView.Rows[0].Selected = true;
                nRow = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nRow < articalsDataGridView.RowCount)
                {
                    articalsDataGridView.Rows[nRow].Selected = false;
                    articalsDataGridView.Rows[--nRow].Selected = true;
                    articalsDataGridView.CurrentCell = articalsDataGridView.Rows[nRow].Cells[7];
                    try
                    {
                        string a = main_photoTextBox.Text;
                        pictureBox1.Image = System.Drawing.Image.FromFile(a);
                        label1.Text = "";
                    }
                    catch (Exception ex)
                    {
                    
                    }
                }
                else
                {
                    nRow = 0;
                }
            }
            catch {
                articalsDataGridView.Rows[0].Selected = true;
                nRow = 0;
            }
        }

        // Кнопка поиска 
        private void button4_Click(object sender, EventArgs e)
        {
 
             string sbtext = searchbox.Text;

            articalsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                for (int i = 0; i < articalsDataGridView.RowCount; i++){
                    articalsDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < articalsDataGridView.ColumnCount; j++) { 
                        if (articalsDataGridView.Rows[i].Cells[j].Value != null) {
                            if (articalsDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(sbtext.ToLower()))
                            {
                                articalsDataGridView.CurrentCell = articalsDataGridView.Rows[i].Cells[2];
                                articalsDataGridView.Rows[i].Selected = true;
                                string a = main_photoTextBox.Text;
                                pictureBox1.Image = System.Drawing.Image.FromFile(a);
                                label1.Text = "";
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                label1.Text = "Ошибка поиска!";
            } 
        }
        ///Эскпорт в pdf
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                // Создаем диалоговое окно для выбора пути сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF файл|*.pdf";
                saveFileDialog.Title = "Выберите путь для сохранения файла";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    // Создаем PDF документ
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);


                    // Создаем таблицу и добавляем данные
                    PdfPTable pdfTable = new PdfPTable(1);

                    // int i = 1;
                    //while (i < 7){
                    //   PdfPCell cell = new PdfPCell(new Phrase(titleTextBox.Text));
                    //   pdfTable.AddCell(titleTextBox.Text);
                    //   i++;
                    //}

                      
                        pdfTable.AddCell(new PdfPCell(new Phrase(titleTextBox.Text)));
                        pdfTable.AddCell(new PdfPCell(new Phrase(pretitleTextBox.Text)));
                        pdfTable.AddCell(new PdfPCell(new Phrase(main_textTextBox.Text)));
                        pdfTable.AddCell(new PdfPCell(new Phrase(authorTextBox.Text)));
                        


                    // Добавляем таблицу в документ
                    document.Add(pdfTable);
                    document.Close();

                    MessageBox.Show("Данные успешно экспортированы в файл PDF!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при экспорте данных в PDF: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            addArticle addArticle = new addArticle();
            addArticle.Show();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
