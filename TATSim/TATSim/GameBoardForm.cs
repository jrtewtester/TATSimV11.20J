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
        public Player player = new Player();
        public int day = 1;
        public int cash;
        public int miles;
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
            gameBoardPanel.Visible = false;
            routeSelectPanel1.Visible = true;

            playersMotoObj = originalForm.playersMoto;
            playersMotoPB.Image = playersMotoObj.Image;

            player.Enjoyment = 10;
            player.Exhaustion = 10;
            player.Hunger = 10;

            cash = originalForm.startCash;
            cashTextBox.Text = "$" + cash.ToString();
            dayNumTextBox.Text = day.ToString();

            Mechanics.CalcRangeofMoto(playersMotoObj);
            fuelRangeTB.Text = playersMotoObj.Range.ToString() + " miles";
            miles = Mechanics.CaclDaysMileage();

            mileageTextBox.Text = miles.ToString();

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

        private void routeStartBtn1_Click(object sender, EventArgs e)
        {
            if (!capeHRouteRadBut.Checked && !nyRouteRadBut.Checked)
                MessageBox.Show("Please select a route!", "Message", MessageBoxButtons.OK);
            else
            {
                if (capeHRouteRadBut.Checked)
                    player.Route = "cape hatteras";
                else
                    player.Route = "new york";

                routeSelectPanel1.Visible = false;
                gameBoardPanel.Visible = true;
            }
        }

        private void nextDayBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
