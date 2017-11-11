using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string NaszWyraz = null;
        string ZgadywanyWyraz = null;
        string ZgadywanyWyrazSpacje = null;

        int KrokZgadywania = 1;
        string literka;
        public Form1()
        {
            InitializeComponent();
            
            NaszWyraz = "KABARET";
            ZgadywanyWyraz = "_______";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                literka = textBox1.Text;
                for (int i = 0; i< NaszWyraz.Length; i++)
                {
                    if(literka == NaszWyraz.Substring(i,1))
                    {
                        ZgadywanyWyraz = ZgadywanyWyraz.Remove(i,1);
                        ZgadywanyWyraz = ZgadywanyWyraz.Insert(i, literka);
                        ZgadywanyWyrazSpacje = ZgadywanyWyraz;
                        for(int j = ZgadywanyWyraz.Length-1; j >= 0 ; j--)
                        {
                            ZgadywanyWyrazSpacje = ZgadywanyWyrazSpacje.Insert(j, " ");
                        }

                        label1.Text = ZgadywanyWyrazSpacje;
                    }
                }
            }
           
            textBox1.Text = "";
            KrokZgadywania++;
            if(literka != "")
                label3.Text = "To będzie Twoja " + KrokZgadywania + " próba.";
            if(!ZgadywanyWyraz.Contains("_"))
            {
                label3.Text = "Gratulacje. Udało ci się w " + (KrokZgadywania - 1) + " próbach!";
                PSprawdzania.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //PSprawdzania.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
