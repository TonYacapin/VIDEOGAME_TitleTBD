using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TBD_FarmingGame_Abakus
{
    public partial class Form1 : Form
    {
        // Game state variables
        private int cropsplanted = 0;
        private int coins = 10;
        private int cropstosell = 0;
        //1=till, 2=water, 3=plant, 4=harvest
        private string selectedaction = "Till";


      
        Tile tile1 = new Tile();
        Tile tile2 = new Tile();
        Tile tile3 = new Tile();

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
            lblselectedAction.Text = "Selected Action: " + selectedaction;

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

        private void Btn_Till_Click(object sender, EventArgs e)
        {
            selectedaction = "Till";
            UpdateGameState();
        }
        private void btn_water_Click(object sender, EventArgs e)
        {
            selectedaction = "Water";
            UpdateGameState();
        }
        private void btn_plant_Click(object sender, EventArgs e)
        {
            selectedaction = "Plant";
            UpdateGameState();
        }
        private void btn_harvest_Click(object sender, EventArgs e)
        {
            selectedaction = "Harvest";
            UpdateGameState();
        }

        private void Btn_Tile1_Click(object sender, EventArgs e)
        {

            switch (selectedaction)
            {
                // till the tile
                case "Till":
                   if(tile1.IsNormal)
                    {
                            
                        tile1.IsTilled = true;
      
                        tile1.IsNormal = false;

                        Btn_Tile1.ImageIndex = 1;


                        MessageBox.Show("Tilling");
                    }

                    break;

                case "Water":
                    if (tile1.IsTilled &&  !tile1.IsWatered  )
                    {
                        tile1.IsWatered = true;
               
                        MessageBox.Show("Watering");

                        Btn_Tile1.ImageIndex = 2;
                    }

                    if (tile1.IsSeeded && !tile1.IsCropReady)
                    {
                        progressbar_tile1.Show();

                        Tile1_Timer.Start();

                        Btn_Tile1.ImageIndex = 3;

                    }
                    break;

                case "Plant":
                    if (tile1.IsTilled && !tile1.IsSeeded && !tile1.IsWatered)
                    {
                        tile1.IsSeeded = true;
                        Btn_Tile1.ImageIndex = 4;

                        MessageBox.Show("Planting");
                    }


                    if (tile1.IsWatered && !tile1.IsCropReady)
                    {

                    
                        Btn_Tile1.ImageIndex = 3;
                        progressbar_tile1.Show();

                        Tile1_Timer.Start();
                    }

                    break;
                case "Harvest":
                    if (tile1.IsCropReady)
                    {
                        tile1.IsNormal = true;
                        tile1.IsTilled = false;
                        tile1.IsWatered = false;
                        tile1.IsSeeded = false;
                        tile1.IsHarvested = false;
                        tile1.IsCropReady = false;
                        Btn_Tile1.ImageIndex = 0;
                        MessageBox.Show("Harvesting");

                        cropstosell += 1;
                        UpdateGameState();
                    }
                    break;
                default:
                
                    break;
            }
        }

        private void Tile1_Timer_Tick(object sender, EventArgs e)
        {
            progressbar_tile1.Value += 1;

            if (progressbar_tile1.Value == 100)
            {
               Tile1_Timer.Stop();

                tile1.IsCropReady = true;

                progressbar_tile1.Value = 0;
             
            }
            UpdateGameState();

        }
    }
    }
