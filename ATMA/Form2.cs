using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMA
{
    public partial class Form2 : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
          // textBox1.Text = ((Form1)f).geckoWebBrowser1.Url.ToString();
           //textBox2.Text = ((Form1)f).geckoWebBrowser2.Url.ToString();
          // textBox3.Text = ((Form1)f).geckoWebBrowser3.Url.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  ((Form1)f).geckoWebBrowser1.Navigate(textBox1.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  ((Form1)f).geckoWebBrowser2.Navigate(textBox2.Text.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
          //  ((Form1)f).geckoWebBrowser3.Navigate(textBox3.Text.ToString());
        }

        public static bool hasHttpFunc(string a)
        {
            /*  StringBuilder bar3 = new StringBuilder();
              string text = textBox3.Text.ToString();
              if (hasHttpFunc(text) == true)
              {
                  Uri uri3 = new Uri(text);
                  ((Form1)f).webBrowser3.Url = uri3;
              }
              else
              {
                  bar3.Append("http://");
                  bar3.Append(text);
                  Uri uri3 = new Uri(bar3.ToString());
                  textBox3.Text = bar3.ToString();
                  ((Form1)f).webBrowser3.Url = uri3;
                  bar3.Clear();
              }*/
            StringBuilder bar1 = new StringBuilder();
             int count = 0;
             string bar2;
             foreach (char b in a)
             {
                 if (count <= 3)
                 {
                     bar1.Append(b);
                     count++;
                 }
                 else
                 {

                 }
             }
            count = 0;
            bar2 = bar1.ToString();
            bar1.Clear();
            if (bar2 == "http")
            {
                return(true);
            }
            else if (bar2 == "HTTP")
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
