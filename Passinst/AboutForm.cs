using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passinst
{
    public partial class AboutForm : Form
    {
        

        public AboutForm()
        {
            InitializeComponent();
            string ver = Application.ProductVersion;
            
            label1.Text = "Password generation program v "+ver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
