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

     

            private void button2_Click(object sender, EventArgs e)
        {


            //8.c

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int év) || év < 1989)
            {
                MessageBox.Show("Hiba! Az évszám nem megfelelő!");
                return;
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
                return;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
                return;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
                return;
            }
        }

       

        
    }
}
