using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mission1
{
    public partial class Form1 : Form
    {

        public string s;

        public Form1()
        {
            InitializeComponent();
        }

        private void bttnRef_Click(object sender, EventArgs e)
        {
            string[] proper = new string[16];

            proper = Ref.ShowDateTime();

            foreach (var i in proper)
            {
                TbForRef.AppendText(i);
            }

        }    
    }
}
