using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace print_system
{
    public partial class formposprint : Form
    {
        public formposprint()
        {
            InitializeComponent();
        }

        public bool PrintValue(Graphics g, bool status)
        {
            try
            {
                SolidBrush fontcolor = new SolidBrush(Color.CornflowerBlue);
                SolidBrush fontcolor1 = new SolidBrush(Color.Black);

                Font fontname = new Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Point);
                Font fontname1 = new Font("Times New Roman", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font fontname2 = new Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point);
                Font fontname3 = new Font("Times New Roman", 12, FontStyle.Regular, GraphicsUnit.Point);

                StringFormat textformat = new StringFormat();
                textformat.Alignment = StringAlignment.Center;

                StringFormat textformat1 = new StringFormat();
                textformat1.Alignment = StringAlignment.Near;

                StringFormat textformat2 = new StringFormat();
                textformat2.Alignment = StringAlignment.Far;

                RectangleF firstLetter = new RectangleF(10, 50, 245, 20);
                g.DrawString("Stock Transfer Note", fontname, fontcolor, firstLetter, textformat);

                g.DrawLine(new Pen(fontcolor, 1), 0, 75, 280, 70);

                RectangleF b_no = new RectangleF(10, 85, 245, 20);
                g.DrawString("B.No: 250602001", fontname1, fontcolor1, b_no, textformat1);

                RectangleF no_pcs = new RectangleF(10, 110, 245, 20);
                g.DrawString("No Of Pcs: 5", fontname1, fontcolor1, no_pcs, textformat1);

                RectangleF no_items = new RectangleF(10, 135, 245, 20);
                g.DrawString("No Of Items: 1", fontname1, fontcolor1, no_items, textformat1);

                RectangleF cashier = new RectangleF(10, 160, 245, 20);
                g.DrawString("Cashier: admin", fontname1, fontcolor1, cashier, textformat1);

                RectangleF date = new RectangleF(30, 85, 245, 20);
                g.DrawString("Date: 02-06-2025", fontname1, fontcolor1, date, textformat2);

                RectangleF from = new RectangleF(30, 110, 245, 20);
                g.DrawString("From: Pharmacy", fontname1, fontcolor1, from, textformat2);

                RectangleF to = new RectangleF(30, 135, 245, 20);
                g.DrawString("To: WARD", fontname1, fontcolor1, to, textformat2);

                g.DrawLine(new Pen(fontcolor,1),0,190,280,190);

                RectangleF code = new RectangleF(30, 200, 245, 20);
                g.DrawString("I.Code", fontname2, fontcolor1, code, textformat1);

                RectangleF name = new RectangleF(30, 200, 245, 20);
                g.DrawString("I.Name", fontname2, fontcolor1, name, textformat);

                RectangleF qty = new RectangleF(30, 200, 245, 20);
                g.DrawString("Qty", fontname2, fontcolor1, qty, textformat2);

                g.DrawLine(new Pen(fontcolor, 1), 0, 220, 280, 220);

                RectangleF lop = new RectangleF(10, 240, 245, 20);
                g.DrawString("LOPMED 2MG (LOPERAMIDE CAP)", fontname3, fontcolor1, lop, textformat1);

                RectangleF amout1 = new RectangleF(10, 260, 245, 20);
                g.DrawString("1200", fontname1, fontcolor1, amout1, textformat1);

                RectangleF amout = new RectangleF(30, 260, 245, 20);
                g.DrawString("5.000", fontname1, fontcolor1, amout, textformat2);

                g.DrawLine(new Pen(fontcolor, 1), 0, 280, 280, 280);

                RectangleF total = new RectangleF(10, 300, 245, 20);
                g.DrawString("Transfer Total", fontname2, fontcolor1, total, textformat1);

                RectangleF amout2 = new RectangleF(30, 300, 245, 20);
                g.DrawString("125.00", fontname2, fontcolor1, amout2, textformat2);

                g.DrawLine(new Pen(fontcolor, 1), 0, 320, 280, 320);

                // RectangleF thanks = new RectangleF(20, 250, 5, 20);
                // g.DrawString("Thank You", fontname, fontcolor, thanks, textformat1);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool PrintDoc()
        {
            try
            {
                printDocument1.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["posPrint"].ToString();
                printDocument1.DocumentName = "printbill";
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("printbill", 500, 700);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dia = MessageBox.Show("Do you want print?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    if (PrintDoc())
                    {
                        printDocument1.Print();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                PrintValue(e.Graphics, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void posprint_Load(object sender, EventArgs e)
        {
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDocument1;
                previewDialog.WindowState = FormWindowState.Maximized;
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying preview:\n" + ex.Message);
            }
        }
    }
}