using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PowerManagerV2
{
    public partial class Form1 : Form
    {
        bool sure = false; // create bool for checkbox
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sure = checkBox1.Checked; // change bool state with checkbox check
        }

        private void button1_Click(object sender, EventArgs e) // execute if button1 pressed
        {
            if (sure == true) // allow if checkbox cheked
            {
                Process.Start("shutdown", "/s /t 0 /f"); // immediantly shutdown computer
            }
        }

        private void button2_Click(object sender, EventArgs e) // execute if button2 pressed
        {
            if (sure == true) // allow if checkbox cheked
            {
                Process.Start("shutdown", "/r /t 0 /f"); // immediantly restart computer
            }
        }

        private void button3_Click(object sender, EventArgs e) // execute if button3 pressed
        {
            if (sure == true) // allow if checkbox cheked
            {
                Process.Start("shutdown", "/h /f"); // immediantly hybernate computer
            }
        }
    }
}
// with codEwU? Black Angel