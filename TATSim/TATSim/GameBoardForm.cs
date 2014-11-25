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
    public partial class GameBoardForm : Form
    {
        TATSimForm originalForm;
        public Motorcycle playersMotoObj;
        public GameBoardForm(TATSimForm incomingForm)
        {
            // Links the two forms together so we can 
            // carry over the players moto object
            originalForm = incomingForm;
            InitializeComponent();
        }

        //to make sure program closes completely if X is used to close program
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GameBoardForm_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(originalForm.playersMoto.Name.ToString());
            //Console.WriteLine(originalForm.playersMoto.Performance.ToString());
            //Console.WriteLine(originalForm.playersMoto.Range.ToString());
            //Console.WriteLine(originalForm.playersMoto.Weight.ToString());
            //Console.WriteLine(originalForm.playersMoto.Tires.Cost.ToString());
            //Console.WriteLine(originalForm.playersMoto.Tires.Name.ToString());
            //Console.WriteLine(originalForm.playersMoto.GasTank.Name.ToString());
            //Console.WriteLine(originalForm.playersMoto.GasTank.Cost.ToString());
            //Console.WriteLine(originalForm.playersMoto.TheExhaust.Name.ToString());
            //Console.WriteLine(originalForm.playersMoto.TheExhaust.Cost.ToString());
        }
    }
}
