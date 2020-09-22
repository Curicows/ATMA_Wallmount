using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace ATMA
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form2"];
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            //geckoWebBrowser1.Navigate("www.google.com.br");
            //geckoWebBrowser2.Navigate("www.google.com.br");
            //geckoWebBrowser3.Navigate("www.google.com.br");
            TopPanel.RowCount = 2;
           // tableLayoutPanel1.SetRow()
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (IsFormOpen("Form2") == false)
            {
                f.Show();
            }            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        public static bool IsFormOpen(string formname)
        {
            
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == formname)
                {
                    return (true);
                }

            }
            return (false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tableLayoutPanel1.ColumnCount = 2;
            // tableLayoutPanel1.Controls.Remove(button4);
            /*  TableLayoutRowStyleCollection styles = this.MainPanel.RowStyles;
              int i = 0;
              foreach (RowStyle style in styles)
              {
                  i++;
                  // if (style.SizeType == SizeType.Absolute)
                  if (i == 3) {
                      style.SizeType = SizeType.Absolute;
                      style.Height = 0;
                      style.SizeType = SizeType.Percent;
                      style.width = 
                  }
                  //MessageBox.Show(style.ToString());
                  //style.SizeType = SizeType.AutoSize;
                  //}*/
            TableLayoutColumnStyleCollection styles = this.TopPanel.ColumnStyles;
            int i = 0;
            foreach (ColumnStyle style in styles)
            {
                i++;
                if (i == 1)
                {
                    style.SizeType = SizeType.Percent;
                    style.Width = 66;
                } else if (i == 3) {
                    style.SizeType = SizeType.Absolute;
                    style.Width = 0;
                }
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
           // tableLayoutPanel1.Controls.Add(button4,0,0);
           
        }

        public void ColumnHide(int row,int column)
        {
            // column
            TableLayoutColumnStyleCollection styles = this.TopPanel.ColumnStyles;
            int i = 0;
            foreach (ColumnStyle style in styles)
            {
                i++;
                if (i == column)
                {
                 /*   style.SizeType = SizeType.Absolute;
                    style.Width = 0;*/
                }
            }
        }
    }
}
