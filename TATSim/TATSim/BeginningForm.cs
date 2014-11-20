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
    public partial class TATSimForm : Form
    {
        public TATSimForm()
        {
            InitializeComponent();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstructionsForm instForm = new InstructionsForm();
            instForm.Show();
        }
    }
}
