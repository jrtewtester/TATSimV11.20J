using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TATSim
{
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //InstructionsForm instForm = new InstructionsForm();
            //instForm.Visible = false;

            TATSimForm beginningForm = new TATSimForm();
            beginningForm.Show();
        }
    }
}
