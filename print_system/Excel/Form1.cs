using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Color = System.Drawing.Color;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;


namespace Excel
{
    public partial class Frmexcel : Form
    {
        //  PrintDocument printDoc4 = new PrintDocument();


        //        public Frmexcel()
        //        {
        //            InitializeComponent();
        //        }

        //        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //        {

        //        }


        //        private void btnexcel_Click(object sender, EventArgs e)
        //        {
        //            if (dataGridView1.Rows.Count == 0)
        //            {
        //                MessageBox.Show("No data available to export!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                return;
        //            }
        //            SaveFileDialog saveFileDialog = new SaveFileDialog
        //            {
        //                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
        //                Title = "Save an Excel File",
        //                FileName = "PatientsDetails.xlsx"
        //            };


        //            if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //            {
        //                try
        //                {

        //                    using (XLWorkbook workbook = new XLWorkbook())
        //                    {
        //                        DataTable dt = ((DataTable)dataGridView1.DataSource);
        //                        workbook.Worksheets.Add(dt, "Patients");

        //                        workbook.SaveAs(saveFileDialog.FileName);

        //                        MessageBox.Show("Data successfully exported to Excel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("Error while exporting:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //                }

        //            }
        //        }

        //        private void Frmexcel_Load(object sender, EventArgs e)
        //        {
        //            string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        //            MySqlConnection cnn = new MySqlConnection(connectionString);
        //            MySqlCommand command;
        //            string sql = $"SELECT`id`,`patient_name`,`mobile`,`age`,`address`,`gender` FROM`hospital`.`patients`;";
        //            try
        //            {
        //                cnn.Open();
        //                command = new MySqlCommand(sql, cnn);
        //                MySqlDataReader dr = command.ExecuteReader();
        //                if (dr.HasRows)
        //                {
        //                    DataTable dt = new DataTable();
        //                    dt.Load(dr);
        //                    dataGridView1.DataSource = dt;
        //                    dataGridView1.Columns["id"].Visible = false;
        //                    dataGridView1.Columns["patient_name"].HeaderText = "Patient name";
        //                    dataGridView1.Columns["mobile"].HeaderText = "Moblie No";
        //                    dataGridView1.Columns["age"].HeaderText = "Age";
        //                    dataGridView1.Columns["address"].HeaderText = "Address";
        //                    dataGridView1.Columns["gender"].HeaderText = "Gender";
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Rows not found.");
        //                }
        //                command.Dispose();
        //                cnn.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Can not open connection! " + ex.ToString());
        //            }
        //        }

        //        private void btnexcelex_Click(object sender, EventArgs e)
        //        {
        //            try
        //            {
        //                using (ExcelPackage xlPackage1 = new ExcelPackage())
        //                {
        //                    ExcelWorksheet worksheet = xlPackage1.Workbook.Worksheets.Add("Patients");
        //                    var namedStyle = xlPackage1.Workbook.Styles.CreateNamedStyle("HyperLink");
        //                    namedStyle.Style.Font.UnderLine = true;
        //                    namedStyle.Style.Font.Color.SetColor(Color.Blue);

        //                    const int startRow = 8;
        //                    int row = startRow;
        //                    //Create Headers and format them
        //                    worksheet.Cells["A1"].Value = "ABC Hospital";
        //                    using (ExcelRange r = worksheet.Cells["A1:F1"])
        //                    {
        //                        r.Merge = true;
        //                        r.Style.Font.SetFromFont(new Font("Britannic Bold", 22, FontStyle.Regular));
        //                        r.Style.Font.Color.SetColor(Color.White);
        //                        r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
        //                        r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
        //                        r.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(23, 55, 93));
        //                    }

        //                    worksheet.Cells["A2"].Value = "No 27, Kopay, Jaffna";
        //                    using (ExcelRange r = worksheet.Cells["A2:F2"])
        //                    {
        //                        r.Merge = true;
        //                        r.Style.Font.SetFromFont(new Font("Britannic Bold", 22, FontStyle.Regular));
        //                        r.Style.Font.Color.SetColor(Color.White);
        //                        r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
        //                        r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
        //                        r.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(23, 55, 93));
        //                    }

        //                    worksheet.Cells["A3"].Value = "0776543234";
        //                    using (ExcelRange r = worksheet.Cells["A3:F3"])
        //                    {
        //                        r.Merge = true;
        //                        r.Style.Font.SetFromFont(new Font("Britannic Bold", 22, FontStyle.Regular));
        //                        r.Style.Font.Color.SetColor(Color.White);
        //                        r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
        //                        r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
        //                        r.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(23, 55, 93));
        //                    }

        //                    using (ExcelRange r = worksheet.Cells["A4:F4"])
        //                    {
        //                        r.Merge = true;
        //                        r.Style.Font.SetFromFont(new Font("Britannic Bold", 14, FontStyle.Regular));
        //                        r.Style.Font.Color.SetColor(Color.Black);
        //                        r.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
        //                        r.Style.Fill.PatternType = ExcelFillStyle.Solid;
        //                        r.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
        //                    }

        //                    worksheet.Cells["A5"].Value = "Patients Details";

        //                    using (ExcelRange r = worksheet.Cells["A5:F5"])
        //                    {
        //                        r.Merge = true;
        //                        r.Style.Font.SetFromFont(new Font("Britannic Bold", 18, FontStyle.Regular));
        //                        r.Style.Font.Color.SetColor(Color.Black);
        //                        r.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
        //                        r.Style.Fill.PatternType = ExcelFillStyle.Solid;
        //                        r.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
        //                    }

        //                    worksheet.Cells["A6"].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

        //                    using (ExcelRange r = worksheet.Cells["A6:F6"])
        //                    {
        //                        r.Merge = true;
        //                        r.Style.Font.SetFromFont(new Font("Britannic Bold", 18, FontStyle.Regular));
        //                        r.Style.Font.Color.SetColor(Color.Black);
        //                        r.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
        //                        r.Style.Fill.PatternType = ExcelFillStyle.Solid;
        //                        r.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
        //                    }


        //                    worksheet.Cells["A7"].Value = "ID";
        //                    worksheet.Cells["B7"].Value = "Patient name";
        //                    worksheet.Cells["C7"].Value = "Mobile";
        //                    worksheet.Cells["D7"].Value = "Age";
        //                    worksheet.Cells["E7"].Value = "Address";
        //                    worksheet.Cells["F7"].Value = "Gender";


        //                    worksheet.Cells["A7:F7"].Style.Fill.PatternType = ExcelFillStyle.Solid;
        //                    worksheet.Cells["A7:F7"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(23, 55, 93));
        //                    worksheet.Cells["A7:F7"].Style.Font.Color.SetColor(Color.White);
        //                    worksheet.Cells["A7:F7"].Style.Font.Bold = true;


        //                    foreach (DataGridViewRow rows in dataGridView1.Rows) // Loop over the rows.
        //                    {
        //                        if (row % 2 == 0)
        //                        {
        //                            worksheet.Cells[$"A{row}:F{row}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
        //                            worksheet.Cells[$"A{row}:F{row}"].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
        //                        }
        //                        worksheet.Cells[$"A{row}"].Value = rows.Cells["id"].Value.ToString();
        //                        worksheet.Cells[$"B{row}"].Value = rows.Cells["patient_name"].Value.ToString();
        //                        worksheet.Cells[$"C{row}"].Value = rows.Cells["mobile"].Value.ToString();
        //                        worksheet.Cells[$"D{row}"].Value = rows.Cells["age"].Value.ToString();
        //                        worksheet.Cells[$"E{row}"].Value = rows.Cells["address"].Value.ToString();
        //                        worksheet.Cells[$"F{row}"].Value = rows.Cells["gender"].Value.ToString();

        //                        row++;
        //                    }

        //                    //worksheet.Cells[startRow, 2, row - 1, 3].Style.Numberformat.Format = "#,##0.00";
        //                    // worksheet.Cells[startRow, 2, row - 1, 2].Style.Numberformat.Format = "yyyy/mm/dd";
        //                    // worksheet.Cells[startRow, 10, row - 1, 10].Style.Numberformat.Format = "yyyy/mm/dd HH:mm:ss";
        //                    worksheet.Cells[startRow, 3, row - 1, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

        //                    worksheet.Cells[$"A{row+2}:F{row+2}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
        //                    worksheet.Cells[$"A{row + 2}:F{row + 2}"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
        //                    //worksheet.Cells["A" + (row + 2) + ":D" + (row + 2)].Style.Font.Bold = true;

        //                    worksheet.Column(1).Width = 35;
        //                    worksheet.Column(2).Width = 30;
        //                    worksheet.Column(3).Width = 20;
        //                    worksheet.Column(4).Width = 25;
        //                    worksheet.Column(5).Width = 25;
        //                    worksheet.Column(6).Width = 25;

        //                    SaveFileDialog saveDlg = new SaveFileDialog();
        //                    saveDlg.InitialDirectory = @"C:\Desktop";
        //                    saveDlg.Filter = "Excel files (*.xlsx)|*.xlsx";
        //                    saveDlg.FilterIndex = 0;
        //                    saveDlg.RestoreDirectory = true;
        //                    saveDlg.Title = "Export Excel File To";
        //                    if (saveDlg.ShowDialog() == DialogResult.OK)
        //                    {
        //                        try
        //                        {
        //                            var fullpath = new FileInfo($"{saveDlg.FileName}");
        //                            // xlWorkbook.SaveCopyAs(path);
        //                            // ExcelLibrary.DataSetHelper.CreateWorkbook(fullpath, ds);
        //                            xlPackage1.SaveAs(fullpath);
        //                            MessageBox.Show($"File is Created in {fullpath.ToString()}", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            MessageBox.Show(ex.Message);
        //                        }
        //                    }

        //                }
        //            }

        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.ToString());
        //                //throw;
        //            }


        //        }


        //    }
        //}    



        public Frmexcel()
        {
            InitializeComponent();

        //    printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage_1);

         //   Frmexcel_Load(null, null);
            //dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

          //  btnprint.Enabled = false;
        }

        private void Frmexcel_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
            string sql = "SELECT `id`, `patient_name`, `mobile`, `age`, `address`, `gender` FROM `hospital`.`patients`";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    MySqlCommand command = new MySqlCommand(sql, cnn);
                    MySqlDataReader dr = command.ExecuteReader();

                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt;

                        dataGridView1.Columns["id"].Visible = false;
                        dataGridView1.Columns["patient_name"].HeaderText = "Patient Name";
                        dataGridView1.Columns["mobile"].HeaderText = "Mobile No";
                        dataGridView1.Columns["age"].HeaderText = "Age";
                        dataGridView1.Columns["address"].HeaderText = "Address";
                        dataGridView1.Columns["gender"].HeaderText = "Gender";
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnprint.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

       

        private bool ConfigurePrinter()
        {
            try
            {
                printDocument1.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["posPrint"].ToString();
                printDocument1.DocumentName = "PatientPrint";
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 500, 800);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printer configuration error: " + ex.Message);
                return false;
            }
        }



        private void DrawPatientDetails(Graphics g)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    g.DrawString("No patient selected.", new Font("Arial", 14), Brushes.Red, 10, 10);
                    return;
                }

                var row = dataGridView1.SelectedRows[0];

                string[] labels = { "Patient Name", "Mobile", "Age", "Address", "Gender" };
                string[] values = {
                    row.Cells["patient_name"].Value?.ToString(),
                    row.Cells["mobile"].Value?.ToString(),
                    row.Cells["age"].Value?.ToString(),
                    row.Cells["address"].Value?.ToString(),
                    row.Cells["gender"].Value?.ToString()
                };

                Font headerFont = new Font("Arial", 18, FontStyle.Bold);
                Font bodyFont = new Font("Arial", 9, FontStyle.Regular);
                SolidBrush brush = new SolidBrush(Color.Black);
                Pen dashedPen = new Pen(Color.Black) { DashStyle = DashStyle.Dot };
                StringFormat leftAlign = new StringFormat { Alignment = StringAlignment.Near };

                int y = 0;

                g.DrawString("Patient Details", headerFont, brush, new RectangleF(0, y, 245, 30), new StringFormat { Alignment = StringAlignment.Center });
                y += 35;
                g.DrawLine(dashedPen, 0, y, 245, y);
                y += 10;

                for (int i = 0; i < labels.Length; i++)
                {
                    g.DrawString(labels[i] + ":", bodyFont, brush, new RectangleF(0, y, 100, 25), leftAlign);
                    g.DrawString(values[i], bodyFont, brush, new RectangleF(110, y, 135, 25), leftAlign);
                    y += 30;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Drawing error: " + ex.Message);
            }
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            DrawPatientDetails(e.Graphics);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnprint_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a patient to print.");
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to print?", "Print Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (ConfigurePrinter())
                {
                    try
                    {
                        printDocument1.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Print error: " + ex.Message);
                    }
                }
            }
            //if (dataGridView1.Rows.Count == 0)
            //{
            //    MessageBox.Show("No data to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //SaveFileDialog saveFileDialog = new SaveFileDialog
            //{
            //    Filter = "Excel Workbook (*.xlsx)|*.xlsx",
            //    Title = "Save Excel File",
            //    FileName = "PatientsDetails.xlsx"
            //};

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        using (XLWorkbook workbook = new XLWorkbook())
            //        {
            //            DataTable dt = (DataTable)dataGridView1.DataSource;
            //            workbook.Worksheets.Add(dt, "Patients");
            //            workbook.SaveAs(saveFileDialog.FileName);
            //            MessageBox.Show("Exported to Excel successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Export error:\n" + ex.Message);
            //    }
           // }
        }
    }
}
