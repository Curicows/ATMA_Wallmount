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
        Vars vars = new Vars();
        
        
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           textBox1.Text = ((Form1)f).geckoWebBrowser1.Url.ToString();
           textBox2.Text = ((Form1)f).geckoWebBrowser2.Url.ToString();
           textBox3.Text = ((Form1)f).geckoWebBrowser5.Url.ToString();
           textBox4.Text = ((Form1)f).geckoWebBrowser3.Url.ToString();
           //textBox5.Text = ((Form1)f).geckoWebBrowser4.Url.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //((Form1)f).geckoWebBrowser1.Navigate(textBox1.Text.ToString());,
            navigateCorrect(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //((Form1)f).geckoWebBrowser2.Navigate(textBox2.Text.ToString());
            navigateCorrect(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //((Form1)f).geckoWebBrowser5.Navigate(textBox3.Text.ToString());
            navigateCorrect(3);
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
            Properties.Settings.Default.Fav1 = textBox1.Text.ToString();
          // Properties.Settings.Default.Save();
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            ((Form1)f).ColumnHide(2, "top");
            ((Form1)f).ColumnHide(3, "top");
            ((Form1)f).RowHide(3);
            ((Form1)f).ColumnChange(1, 100,"top");
            unRed();
            unBorder();
            OffButton.FlatAppearance.BorderColor = Color.Red;
            OffButton.FlatAppearance.BorderSize = 3;
            ReadOnlyText();
            //textBox1.ReadOnly = false;
            vars.actualScreen = 1;
            hideText();
            button8.BackgroundImage = ATMA.Properties.Resources._1;
        }

        private void Vertical2Button_Click(object sender, EventArgs e)
        {
            ((Form1)f).ColumnShow(2, "top");
            ((Form1)f).ColumnHide(3, "top");
            ((Form1)f).RowHide(3);
            ((Form1)f).ColumnChange(1,50,"top");
            ((Form1)f).ColumnChange(2,50,"top");
            unRed();
            unBorder();
            Vertical2Button.FlatAppearance.BorderColor = Color.Red;
            Vertical2Button.FlatAppearance.BorderSize = 3;
            ReadOnlyText();
           // textBox1.ReadOnly = false;
           // textBox2.ReadOnly = false;
            vars.actualScreen = 3;
            hideText();
            button8.BackgroundImage = ATMA.Properties.Resources._3;
        }

        private void Screen4Button_Click(object sender, EventArgs e)
        {
            ((Form1)f).ColumnShow(2, "top");
            ((Form1)f).ColumnHide(3, "top");
            ((Form1)f).ColumnShow(2, "bottom");
            ((Form1)f).ColumnChange(1, 50, "top");
            ((Form1)f).ColumnChange(2, 50, "top");
            ((Form1)f).ColumnChange(1, 50, "bottom");
            ((Form1)f).ColumnChange(2, 50, "bottom");
            ((Form1)f).RowShow(3);
            unRed();
            unBorder();
            Screen4Button.FlatAppearance.BorderColor = Color.Red;
            Screen4Button.FlatAppearance.BorderSize = 3;
          //  textBox1.ReadOnly = false;
          //  textBox2.ReadOnly = false;
          //  textBox3.ReadOnly = false;
          //  textBox4.ReadOnly = false;
            vars.actualScreen = 8;
            hideText();
            button8.BackgroundImage = ATMA.Properties.Resources._8;
        }

        private void Horizontal2Button_Click(object sender, EventArgs e)
        {
            ((Form1)f).ColumnHide(2, "top");
            ((Form1)f).ColumnHide(2, "bottom");
            ((Form1)f).ColumnHide(3, "top");
            ((Form1)f).ColumnChange(1, 100,"top");
            ((Form1)f).ColumnChange(1, 100, "bottom");
            ((Form1)f).RowShow(3);
            unRed();
            unBorder();
            Horizontal2Button.FlatAppearance.BorderColor = Color.Red;
            Horizontal2Button.FlatAppearance.BorderSize = 3;
            ReadOnlyText();
           // textBox1.ReadOnly = false;
           // textBox3.ReadOnly = false;
            vars.actualScreen = 4;
            hideText();
            button8.BackgroundImage = ATMA.Properties.Resources._4;
        }

        private void Bot2Button_Click(object sender, EventArgs e)
        {
            ((Form1)f).ColumnShow(2, "top");
            ((Form1)f).ColumnHide(2, "bottom");
            ((Form1)f).ColumnHide(3, "top");
            ((Form1)f).ColumnChange(1, 50, "bottom");
            ((Form1)f).ColumnChange(1, 50, "top");
            ((Form1)f).ColumnChange(2, 50, "top");
            ((Form1)f).RowShow(3);
            unRed();
            unBorder();
            Bot2Button.FlatAppearance.BorderColor = Color.Red;
            Bot2Button.FlatAppearance.BorderSize = 3;
            ReadOnlyText();
         //   textBox1.ReadOnly = false;
         //   textBox2.ReadOnly = false;
         //   textBox3.ReadOnly = false;
            vars.actualScreen = 6;
            hideText();
            button8.BackgroundImage = ATMA.Properties.Resources._6;
        }

        private void Top3Button_Click(object sender, EventArgs e)
        {
            ((Form1)f).ColumnShow(2, "bottom");
            ((Form1)f).ColumnHide(2, "top");
            ((Form1)f).ColumnHide(3, "top");
            ((Form1)f).ColumnChange(1, 50, "top");
            ((Form1)f).ColumnChange(1, 50, "bottom");
            ((Form1)f).ColumnChange(2, 50, "bottom");
            ((Form1)f).RowShow(3);
            unRed();
            unBorder();
            Top3Button.FlatAppearance.BorderColor = Color.Red;
            Top3Button.FlatAppearance.BorderSize = 3;
            ReadOnlyText();
          //  textBox1.ReadOnly = false;
          //  textBox3.ReadOnly = false;
          //  textBox4.ReadOnly = false;
            vars.actualScreen = 5;
            hideText();
            button8.BackgroundImage = ATMA.Properties.Resources._5;
        }

        private void Screen3Button_Click(object sender, EventArgs e)
        {
            ((Form1)f).ColumnShow(2, "top");
            ((Form1)f).ColumnShow(3, "top");
            ((Form1)f).ColumnChange(1, 33, "top");
            ((Form1)f).ColumnChange(2, 33, "top");
            ((Form1)f).ColumnChange(3, 33, "top");
            ((Form1)f).RowHide(3);
            unRed();
            unBorder();
            Screen3Button.FlatAppearance.BorderColor = Color.Red;
            Screen3Button.FlatAppearance.BorderSize = 3;
            ReadOnlyText();
           // textBox1.ReadOnly = false;
           // textBox2.ReadOnly = false;
            //textBox5.ReadOnly = false;
            vars.actualScreen = 7;
            hideText();
            button8.BackgroundImage = ATMA.Properties.Resources._7;
        }
        private void Screen2Button_Click(object sender, EventArgs e)
        {
            ((Form1)f).ColumnShow(1, "top");
            ((Form1)f).ColumnShow(2, "top");
            ((Form1)f).ColumnChange(1,70, "top");
            ((Form1)f).ColumnChange(2, 30, "top");
            ((Form1)f).ColumnHide(3, "top");
            ((Form1)f).RowHide(3);
            unRed();
            unBorder();
            Screen2Button.FlatAppearance.BorderColor = Color.Red;
            Screen2Button.FlatAppearance.BorderSize = 3;
            ReadOnlyText();
           // textBox1.ReadOnly = false;
           // textBox2.ReadOnly = false;
            vars.actualScreen = 2;
            hideText();
            button8.BackgroundImage = ATMA.Properties.Resources._2;
        }

        private void unRed()
        {
            OffButton.FlatAppearance.BorderColor = Color.Empty;
            Screen3Button.FlatAppearance.BorderColor = Color.Empty;
            Top3Button.FlatAppearance.BorderColor = Color.Empty;
            Vertical2Button.FlatAppearance.BorderColor = Color.Empty;
            Screen4Button.FlatAppearance.BorderColor = Color.Empty;
            Horizontal2Button.FlatAppearance.BorderColor = Color.Empty;
            Bot2Button.FlatAppearance.BorderColor = Color.Empty;
            Screen2Button.FlatAppearance.BorderColor = Color.Empty;
        }

        private void unBorder()
        {
            OffButton.FlatAppearance.BorderSize = 0;
            Screen3Button.FlatAppearance.BorderSize = 0;
            Top3Button.FlatAppearance.BorderSize = 0;
            Vertical2Button.FlatAppearance.BorderSize = 0;
            Screen4Button.FlatAppearance.BorderSize = 0;
            Horizontal2Button.FlatAppearance.BorderSize = 0;
            Bot2Button.FlatAppearance.BorderSize = 0;
            Screen2Button.FlatAppearance.BorderSize = 0;
        }

        private void ReadOnlyText()
        {
          /*  textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            //textBox5.ReadOnly = true;*/
        }

        private void NavegarButton4_Click(object sender, EventArgs e)
        {
            //((Form1)f).geckoWebBrowser3.Navigate(textBox4.Text.ToString());
            navigateCorrect(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //((Form1)f).geckoWebBrowser4.Navigate(textBox5.Text.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ((Form1)f).geckoWebBrowser1.Refresh();
            ((Form1)f).geckoWebBrowser1.Reload();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ((Form1)f).geckoWebBrowser2.Refresh();
            ((Form1)f).geckoWebBrowser2.Reload();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ((Form1)f).geckoWebBrowser5.Refresh();
            ((Form1)f).geckoWebBrowser5.Reload();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ((Form1)f).geckoWebBrowser3.Refresh();
            ((Form1)f).geckoWebBrowser3.Reload();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ((Form1)f).geckoWebBrowser4.Refresh();
            ((Form1)f).geckoWebBrowser4.Reload();
        }

        private void hideText()
        {
            if (vars.actualScreen == 1)
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button5.Visible = true;
                button6.Visible = false;
                button4.Visible = false;
                button3.Visible = false;
                NavegarButton1.Visible = true;
                NavegarButton2.Visible = false;
                NavegarButton3.Visible = false;
                NavegarButton4.Visible = false;
            }
            else if (vars.actualScreen == 2)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
                button4.Visible = false;
                button3.Visible = false;
                NavegarButton1.Visible = true;
                NavegarButton2.Visible = true;
                NavegarButton3.Visible = false;
                NavegarButton4.Visible = false;
            }
            else if (vars.actualScreen == 3)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
                button4.Visible = false;
                button3.Visible = false;
                NavegarButton1.Visible = true;
                NavegarButton2.Visible = true;
                NavegarButton3.Visible = false;
                NavegarButton4.Visible = false;
            }
            else if (vars.actualScreen == 4)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
                button4.Visible = false;
                button3.Visible = false;
                NavegarButton1.Visible = true;
                NavegarButton2.Visible = true;
                NavegarButton3.Visible = false;
                NavegarButton4.Visible = false;
            }
            else if (vars.actualScreen == 5)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
                button4.Visible = true;
                button3.Visible = false;
                NavegarButton1.Visible = true;
                NavegarButton2.Visible = true;
                NavegarButton3.Visible = true;
                NavegarButton4.Visible = false;
            }
            else if (vars.actualScreen == 6)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
                button4.Visible = true;
                button3.Visible = false;
                NavegarButton1.Visible = true;
                NavegarButton2.Visible = true;
                NavegarButton3.Visible = true;
                NavegarButton4.Visible = false;
            }
            else if (vars.actualScreen == 7)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
                button4.Visible = true;
                button3.Visible = false;
                NavegarButton1.Visible = true;
                NavegarButton2.Visible = true;
                NavegarButton3.Visible = true;
                NavegarButton4.Visible = false;
            }
            else if (vars.actualScreen == 8)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button4.Visible = true;
                button3.Visible = true;
                NavegarButton1.Visible = true;
                NavegarButton2.Visible = true;
                NavegarButton3.Visible = true;
                NavegarButton4.Visible = true;
            }

        }

        private void navigateCorrect(int buttonPressed)
        {
            if (vars.actualScreen == 1)
            {
                if (buttonPressed == 1)
                {
                    ((Form1)f).geckoWebBrowser1.Navigate(textBox1.Text.ToString());
                }
            }
            else if (vars.actualScreen == 2)
            {
                if (buttonPressed == 1)
                {
                    ((Form1)f).geckoWebBrowser1.Navigate(textBox1.Text.ToString());
                }
                else if (buttonPressed == 2)
                {
                    ((Form1)f).geckoWebBrowser2.Navigate(textBox2.Text.ToString());
                }
            }
            else if (vars.actualScreen == 3)
            {
                if (buttonPressed == 1)
                {
                    ((Form1)f).geckoWebBrowser1.Navigate(textBox1.Text.ToString());
                }
                else if (buttonPressed == 2)
                {
                    ((Form1)f).geckoWebBrowser2.Navigate(textBox2.Text.ToString());
                }
            }
            else if (vars.actualScreen == 4)
            {
                if (buttonPressed == 1)
                {
                    ((Form1)f).geckoWebBrowser1.Navigate(textBox1.Text.ToString());
                }
                else if (buttonPressed == 2)
                {
                    ((Form1)f).geckoWebBrowser3.Navigate(textBox2.Text.ToString());
                }
            }
            else if (vars.actualScreen == 5)
            {
                if (buttonPressed == 1)
                {
                    ((Form1)f).geckoWebBrowser1.Navigate(textBox1.Text.ToString());
                }
                else if (buttonPressed == 2)
                {
                    ((Form1)f).geckoWebBrowser3.Navigate(textBox2.Text.ToString());
                }
                else if (buttonPressed == 3)
                {
                    ((Form1)f).geckoWebBrowser4.Navigate(textBox3.Text.ToString());
                }
            }
            else if (vars.actualScreen == 6)
            {
                if (buttonPressed == 1)
                {
                    ((Form1)f).geckoWebBrowser1.Navigate(textBox1.Text.ToString());
                }
                else if (buttonPressed == 2)
                {
                    ((Form1)f).geckoWebBrowser2.Navigate(textBox2.Text.ToString());
                }
                else if (buttonPressed == 3)
                {
                    ((Form1)f).geckoWebBrowser3.Navigate(textBox3.Text.ToString());
                }
            }
            else if (vars.actualScreen == 7)
            {
                if (buttonPressed == 1)
                {
                    ((Form1)f).geckoWebBrowser1.Navigate(textBox1.Text.ToString());
                }
                else if (buttonPressed == 2)
                {
                    ((Form1)f).geckoWebBrowser2.Navigate(textBox2.Text.ToString());
                }
                else if (buttonPressed == 3)
                {
                    ((Form1)f).geckoWebBrowser5.Navigate(textBox3.Text.ToString());
                }
            }
            else if (vars.actualScreen == 8)
            {
                if (buttonPressed == 1)
                {
                    ((Form1)f).geckoWebBrowser1.Navigate(textBox1.Text.ToString());
                }
                else if (buttonPressed == 2)
                {
                    ((Form1)f).geckoWebBrowser2.Navigate(textBox2.Text.ToString());
                }
                else if (buttonPressed == 3)
                {
                    ((Form1)f).geckoWebBrowser3.Navigate(textBox3.Text.ToString());
                }
                else if (buttonPressed == 4)
                {
                    ((Form1)f).geckoWebBrowser4.Navigate(textBox4.Text.ToString());
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
