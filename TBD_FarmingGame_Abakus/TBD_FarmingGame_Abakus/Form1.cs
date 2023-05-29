using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBD_FarmingGame_Abakus
{
    public partial class Form1 : Form
    {
        // Game state variables
        private int cropsplanted = 0;
        private int coins = 10;
        private int cropstosell = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize the game state
            UpdateGameState();
        }

        private void UpdateGameState()
        {
            // Update the labels to reflect the game state
            lblCropsPlanted.Text = "Crops Planted: " + cropsplanted;
            lblCoins.Text = "Coins: " + coins;
            lblCropstoSell.Text = "Crops to Sell: " + cropstosell;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGameState();
        }

        private void btnPlantCrops_Click_1(object sender, EventArgs e)
        {
            if (coins > 0)
            {
                coins--;
                btnPlantCrop_Tile1.Enabled = false;
                PlantCrop_Timer.Start();
            } 
        }
      

        private void btnHarvestCrops_Click_1(object sender, EventArgs e)
        {
            cropstosell += cropsplanted;
            cropsplanted = 0;



            UpdateGameState();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value += 20;

            if (progressBar1.Value == 100)
            {
                PlantCrop_Timer.Enabled = false;
     
                btnPlantCrop_Tile1.Enabled = true;
                progressBar1.Value = 0;
                cropsplanted++;
            }
            UpdateGameState();

        }

        private void btnSellCrops_Click(object sender, EventArgs e)
        {
            coins += cropstosell * 2;

             cropstosell = 0;

            UpdateGameState();

        }
    }
    }
