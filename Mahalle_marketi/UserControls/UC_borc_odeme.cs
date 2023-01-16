using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Mahalle_marketi.UserControls
{
    public partial class UC_borc_odeme : UserControl
    {
        public UC_borc_odeme()
        {
            InitializeComponent();
        }


        private void UC_borc_odeme_Load(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            dataGridView1.DataSource = model.müsteri.ToList();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MusteriBorcuSilFormu form = new MusteriBorcuSilFormu();
            form.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count> 0)
            {

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf) |*.pdf ";
                save.FileName = "Rapor.pdf";
                bool ErrorMessage = false;
                if(save.ShowDialog()==DialogResult.OK)
                {
                    if(File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unab´le to write data to disk"+ ex.Message);
                        }
                    }
                    if(!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage= 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridView1.Rows) { 
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            
                            }
                            using (FileStream fileStream = new FileStream(save.FileName,FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data export basarili", "info");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error while exporting data" + ex.Message);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("No record Found");
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
