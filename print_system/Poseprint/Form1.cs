using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Poseprint
{
    public partial class PoseForm : Form
    {
        public object ConfigurationManager { get; private set; }

        public PoseForm()
        {
            InitializeComponent();
        }
        public bool PrintValue(Graphics g, bool status)
        {
            try
            {
                SolidBrush fontcolor = new SolidBrush(Color.CornflowerBlue);
                SolidBrush fontcolor1 = new SolidBrush(Color.Black);

                Font fontname = new Font("Times New Roman", 14, FontStyle.Regular, GraphicsUnit.Point);
                Font fontname1 = new Font("Times New Roman", 12, FontStyle.Regular, GraphicsUnit.Point);

                StringFormat textformat = new StringFormat();
                textformat.Alignment = StringAlignment.Center;

                StringFormat textformat1 = new StringFormat();
                textformat1.Alignment = StringAlignment.Near;

                StringFormat textformat2 = new StringFormat();
                textformat2.Alignment = StringAlignment.Far;

                RectangleF firstLetter = new RectangleF(10, 50, 245, 700);
                g.DrawString("Stock Transfer Note", fontname, fontcolor, firstLetter, textformat);

                RectangleF dash = new RectangleF(0, 75, 245, 700);
                g.DrawString("------------------------", fontname, fontcolor, dash, textformat1);

                RectangleF b_no = new RectangleF(10, 100, 5, 700);
                g.DrawString("B.No   : 250602001", fontname1, fontcolor1, b_no, textformat1);

                RectangleF no_pcs = new RectangleF(10, 125, 245, 700);
                g.DrawString("No Of Pcs   : 5", fontname1, fontcolor1, no_pcs, textformat1);

                RectangleF no_items = new RectangleF(10, 150, 245, 700);
                g.DrawString("No Of Items  : 1", fontname1, fontcolor1, no_items, textformat1);

                RectangleF cashier = new RectangleF(10, 175, 245, 700);
                g.DrawString("Cashier  : admin", fontname1, fontcolor1, cashier, textformat1);



                RectangleF date = new RectangleF(30, 100, 245, 700);
                g.DrawString("Date      : 02-06-2025", fontname1, fontcolor1, date, textformat2);

                RectangleF from = new RectangleF(30, 125, 245, 700);
                g.DrawString("From         : Pharmacy", fontname1, fontcolor1, from, textformat2);

                RectangleF to = new RectangleF(30, 150, 245, 700);
                g.DrawString("To  : WARD", fontname1, fontcolor1, to, textformat2);


                RectangleF dash2 = new RectangleF(20, 225, 245, 700);
                g.DrawString("--------------------------------------", fontname, fontcolor, dash2, textformat1);

                RectangleF thanks = new RectangleF(20, 250, 5, 700);
                g.DrawString("Thank You", fontname, fontcolor, thanks, textformat1);


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
                printDocument1.PrinterSettings.PrinterName = ConfigurationManager.appSettings["a4print"].ToString();
                printDocument1.DocumentName = "printbill";
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("printbill", 500, 700);
                return true;
            }
            catch
            {
                return false;
                throw;
            }


        }


        private void btnposeprint_Click(object sender, EventArgs e)
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
                //throw
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
                //throw
            }
        }
    }
}
