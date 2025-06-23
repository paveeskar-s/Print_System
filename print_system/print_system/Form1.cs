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


namespace print_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                PrintValue(e.Graphics,true);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                //throw
            }

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dia = MessageBox.Show("Do you want print?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    if (PrintDoc())
                    {
                        firstprint.Print();
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
        private bool PrintDoc()
        {

            try
            {
                firstprint.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["a4print"].ToString();
                firstprint.DocumentName = "printbill";
                firstprint.DefaultPageSettings.PaperSize = new PaperSize("printbill", 827, 1167);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }


        }
        public  bool PrintValue(Graphics g, bool status)
        {
            try
            {
                SolidBrush fontcolor = new SolidBrush(Color.CornflowerBlue);
                Font fontname = new Font("Times New Roman", 14, FontStyle.Regular, GraphicsUnit.Point);

                StringFormat textformat = new StringFormat();
                textformat.Alignment = StringAlignment.Center;

                RectangleF firstLetter = new RectangleF(20, 50, 827, 1169);
                g.DrawString("Welcome to My Details", fontname, fontcolor, firstLetter, textformat);

                RectangleF dash = new RectangleF(20, 75, 827, 1169);
                g.DrawString("---------------------------------", fontname, fontcolor, dash, textformat);

                SolidBrush fontcolor1 = new SolidBrush(Color.Black);
                Font fontname1 = new Font("Times New Roman", 12, FontStyle.Regular, GraphicsUnit.Point);
                StringFormat textformat1 = new StringFormat();
                textformat1.Alignment = StringAlignment.Near;
                RectangleF name = new RectangleF(370, 100, 827, 1169);
                g.DrawString("Name      : " + txtname.Text, fontname1, fontcolor1, name, textformat1);
                RectangleF age = new RectangleF(370, 125, 827, 1169);
                g.DrawString("Age         : " + txtage.Text, fontname1, fontcolor1, age, textformat1);
                RectangleF Address = new RectangleF(370, 150, 827, 1169);
                g.DrawString("Address  : " + txtaddress.Text, fontname1, fontcolor1, Address, textformat1);
                RectangleF father = new RectangleF(370, 175, 827, 1169);
                g.DrawString("Father     : " + txtfather.Text, fontname1, fontcolor1, father, textformat1);
                RectangleF mother = new RectangleF(370, 200, 827, 1169);
                g.DrawString("Mother    : " + txtmother.Text, fontname1, fontcolor1, mother, textformat1);


                RectangleF dash2 = new RectangleF(20, 225, 827, 1169);
                g.DrawString("---------------------------------", fontname, fontcolor, dash2, textformat);
                RectangleF thanks = new RectangleF(20, 250, 827, 1169);
                g.DrawString("Thank You", fontname, fontcolor, thanks, textformat);


                return true;

            }
            catch(Exception) 
            { 
                return false; 
            }

        }

        private bool PrintDoc2()
        {

            try
            {
                firstprint.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["a4print"].ToString();
                firstprint.DocumentName = "printbill";
                firstprint.DefaultPageSettings.PaperSize = new PaperSize("printbill", 827, 1167);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }


        }
        public static bool PrintValue2(Graphics g, bool status)
        {
            try
            {
                SolidBrush fontcolor = new SolidBrush(Color.CornflowerBlue);
                Font fontname = new Font("Times New Roman", 14, FontStyle.Regular, GraphicsUnit.Point);
                StringFormat textformat = new StringFormat();
                textformat.Alignment = StringAlignment.Center;
                RectangleF firstLetter = new RectangleF(20, 50, 827, 1169);
                g.DrawString("Welcome", fontname, fontcolor, firstLetter, textformat);

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnFprint_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dia = MessageBox.Show("Do you want print?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    if (PrintDoc2())
                    {
                       print.Print();
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

        private void print_PrintPage(object sender, PrintPageEventArgs e)
        {

            try
            {
                PrintValue2(e.Graphics, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw
            }

        }

        private void btnform_Click(object sender, EventArgs e)
        {

        }
    }   
}
