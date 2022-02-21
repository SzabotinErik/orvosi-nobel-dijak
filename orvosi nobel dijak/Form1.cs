using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace orvosi_nobel_dijak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ellenőrzések
            //8.b
           



            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
                return;
            }

            //8.c
            if (!int.TryParse(textBox1.Text, out int év) || év < 1989)
            {
                MessageBox.Show("Hiba! Az évszám nem megfelelő!");
                return;
            }
            //Mentés
            try
            {
                StreamWriter sw = new StreamWriter("uj_dijazott.txt");
                sw.WriteLine("Év;Név;SzületésHalálozás;Országkód");
                sw.WriteLine(textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba az állomány írásánál!\n{ex.Message}");
                throw;
            }
        }
    }
}
