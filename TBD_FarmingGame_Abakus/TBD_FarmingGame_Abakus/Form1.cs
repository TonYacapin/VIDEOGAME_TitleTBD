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

        private Point characterPosition;





        Tile tile1 = new Tile();
        Tile tile2 = new Tile();
        Tile tile3 = new Tile();

        public Form1()
        {
            InitializeComponent();
            characterPosition = new Point(400,270);
            this.KeyDown += MainForm_KeyDown;
            this.KeyUp += MainForm_KeyUp;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle key presses for character movement
            switch (e.KeyCode)
            {
                case Keys.W:
                    MoveCharacter(0, -10);  // Move character up
                    break;
                case Keys.A:
                    MoveCharacter(-10, 0);  // Move character left
                    break;
                case Keys.S:
                    MoveCharacter(0, 10);  // Move character down
                    break;
                case Keys.D:
                    MoveCharacter(10, 0);  // Move character right
                    break;
           
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            // Handle key releases for character movement
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.A:
                case Keys.S:
                case Keys.D:
                    StopCharacter();  // Stop character movement
                    break;
            }
        }

        private void StopCharacter()
        {
            // Perform any necessary actions when character movement stops
            // For example, stop animation, play sound, etc.
        }

        private void MoveCharacter(int deltaX, int deltaY)
        {
            // Update character position based on movement
            characterPosition.X += deltaX;
            characterPosition.Y += deltaY;

            // Update character's visual representation
            characterPictureBox.Location = characterPosition;

            // Perform additional actions or checks based on the new position
            // For example, interact with crops, objects, or other game elements
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

       
      

        private void btnHarvestCrops_Click_1(object sender, EventArgs e)
        {
            cropstosell += cropsplanted;
            cropsplanted = 0;



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
                    if (tile1.IsNormal)
                    {
                        timer_Action.Start();
                        DisableAction(true);
                        tile1.IsTilled = true;

                        tile1.IsNormal = false;

                        Btn_Tile1.ImageIndex = 1;

                    }

                    break;

                case "Water":
                    if (tile1.IsTilled && !tile1.IsWatered)
                    {

                        timer_Action.Start();
                        DisableAction(true);
                        tile1.IsWatered = true;

                        Btn_Tile1.ImageIndex = 2;

                    }

                    if (tile1.IsSeeded && !tile1.IsCropReady)
                    {
                        timer_Action.Start();
                        DisableAction(true);
                        Tile1_Timer.Start();
                      

                        Btn_Tile1.ImageIndex = 3;

                    }
                    break;

                case "Plant":
                    if (tile1.IsTilled && !tile1.IsSeeded && !tile1.IsWatered)
                    {

                        timer_Action.Start();
                        DisableAction(true);
                        tile1.IsSeeded = true;
                        Btn_Tile1.ImageIndex = 4;

                    }

                    if (tile1.IsWatered && !tile1.IsCropReady)
                    {
                        timer_Action.Start();
                        DisableAction(true);
                        Btn_Tile1.ImageIndex = 3;
                        progressbar_tile1.Show();

                        Tile1_Timer.Start();
                    }

                    break;
                case "Harvest":
                    if (tile1.IsCropReady)
                    {
                        timer_Action.Start();
                        DisableAction(true);
                        tile1.IsNormal = true;
                        tile1.IsTilled = false;
                        tile1.IsWatered = false;
                        tile1.IsSeeded = false;
                        tile1.IsHarvested = false;
                        tile1.IsCropReady = false;
                        Btn_Tile1.ImageIndex = 0;
                      
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
            progressbar_tile1.Value += 25;

            if (progressbar_tile1.Value == 100)
            {
               Tile1_Timer.Stop();


                Btn_Tile1.ImageIndex = 5;
                tile1.IsCropReady = true;
                progressbar_tile1.Hide();
                progressbar_tile1.Value = 0;
             
            }
            UpdateGameState();

        }

        private void timer_Action_Tick(object sender, EventArgs e)
        {
        
            progressBar_Action.Value += 25;

            if (progressBar_Action.Value == 100)
            {
              
                timer_Action.Stop();

                DisableAction(false);
                progressBar_Action.Value = 0;
            }

       
        }

        private void DisableAction(Boolean boolean) {

            if (boolean == false)
            {
                Btn_Till.Enabled = true;
                btn_harvest.Enabled = true;
                btn_plant.Enabled = true;
                btn_water.Enabled = true;
            }
            else
            {
                Btn_Till.Enabled = false;
                btn_harvest.Enabled = false;
                btn_plant.Enabled = false;
                btn_water.Enabled = false;
            }

        }
    }
    }
