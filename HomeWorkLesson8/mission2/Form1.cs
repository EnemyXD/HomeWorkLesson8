using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mission2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(numericUpDown1.Value);                      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (Decimal.Parse(textBox1.Text) <= 100)
                {
                    numericUpDown1.Value = Decimal.Parse(textBox1.Text);
                }
                else MessageBox.Show("Слишком большое число", "Ошибка");
            }
            catch (Exception t)
            {
                MessageBox.Show( t.ToString() , "Ошибка");
            }



            
        }
    }
}
