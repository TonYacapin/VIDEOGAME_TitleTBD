namespace TBD_FarmingGame_Abakus
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblCropsPlanted = new System.Windows.Forms.Label();
            this.btnPlantCrop_Tile1 = new System.Windows.Forms.Button();
            this.btnHarvestCrop_Tile1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblCropstoSell = new System.Windows.Forms.Label();
            this.btnSellCrops = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.Btn_Tile1 = new System.Windows.Forms.Button();
            this.Btn_Tile2 = new System.Windows.Forms.Button();
            this.Btn_Tile3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Btn_Till = new System.Windows.Forms.Button();
            this.btn_water = new System.Windows.Forms.Button();
            this.btn_harvest = new System.Windows.Forms.Button();
            this.btn_plant = new System.Windows.Forms.Button();
            this.lblselectedAction = new System.Windows.Forms.Label();
            this.progressbar_tile1 = new System.Windows.Forms.ProgressBar();
            this.PlantCrop_Timer = new System.Windows.Forms.Timer(this.components);
            this.Tile1_Timer = new System.Windows.Forms.Timer(this.components);
            this.TileState = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Location = new System.Drawing.Point(12, 9);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(44, 16);
            this.lblCoins.TabIndex = 0;
            this.lblCoins.Text = "Coins:";
            // 
            // lblCropsPlanted
            // 
            this.lblCropsPlanted.AutoSize = true;
            this.lblCropsPlanted.Location = new System.Drawing.Point(12, 41);
            this.lblCropsPlanted.Name = "lblCropsPlanted";
            this.lblCropsPlanted.Size = new System.Drawing.Size(95, 16);
            this.lblCropsPlanted.TabIndex = 1;
            this.lblCropsPlanted.Text = "Crops Planted:";
            // 
            // btnPlantCrop_Tile1
            // 
            this.btnPlantCrop_Tile1.Location = new System.Drawing.Point(343, 334);
            this.btnPlantCrop_Tile1.Name = "btnPlantCrop_Tile1";
            this.btnPlantCrop_Tile1.Size = new System.Drawing.Size(91, 23);
            this.btnPlantCrop_Tile1.TabIndex = 2;
            this.btnPlantCrop_Tile1.Text = "PlantCrop";
            this.btnPlantCrop_Tile1.UseVisualStyleBackColor = true;
            this.btnPlantCrop_Tile1.Visible = false;
            this.btnPlantCrop_Tile1.Click += new System.EventHandler(this.btnPlantCrops_Click_1);
            // 
            // btnHarvestCrop_Tile1
            // 
            this.btnHarvestCrop_Tile1.Location = new System.Drawing.Point(343, 363);
            this.btnHarvestCrop_Tile1.Name = "btnHarvestCrop_Tile1";
            this.btnHarvestCrop_Tile1.Size = new System.Drawing.Size(91, 23);
            this.btnHarvestCrop_Tile1.TabIndex = 3;
            this.btnHarvestCrop_Tile1.Text = "HarvestCrops";
            this.btnHarvestCrop_Tile1.UseVisualStyleBackColor = true;
            this.btnHarvestCrop_Tile1.Visible = false;
            this.btnHarvestCrop_Tile1.Click += new System.EventHandler(this.btnHarvestCrops_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(343, 392);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(91, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // lblCropstoSell
            // 
            this.lblCropstoSell.AutoSize = true;
            this.lblCropstoSell.Location = new System.Drawing.Point(21, 409);
            this.lblCropstoSell.Name = "lblCropstoSell";
            this.lblCropstoSell.Size = new System.Drawing.Size(86, 16);
            this.lblCropstoSell.TabIndex = 5;
            this.lblCropstoSell.Text = "Crops to Sell:";
            // 
            // btnSellCrops
            // 
            this.btnSellCrops.Location = new System.Drawing.Point(16, 437);
            this.btnSellCrops.Name = "btnSellCrops";
            this.btnSellCrops.Size = new System.Drawing.Size(91, 23);
            this.btnSellCrops.TabIndex = 6;
            this.btnSellCrops.Text = "Sell Crops";
            this.btnSellCrops.UseVisualStyleBackColor = true;
            this.btnSellCrops.Click += new System.EventHandler(this.btnSellCrops_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(190, 141);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(91, 23);
            this.progressBar2.TabIndex = 7;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(303, 141);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(91, 23);
            this.progressBar3.TabIndex = 8;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(74, 300);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(91, 23);
            this.progressBar4.TabIndex = 9;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(190, 261);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(91, 23);
            this.progressBar5.TabIndex = 10;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(303, 261);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(91, 23);
            this.progressBar6.TabIndex = 11;
            // 
            // Btn_Tile1
            // 
            this.Btn_Tile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Tile1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Tile1.ImageIndex = 0;
            this.Btn_Tile1.ImageList = this.TileState;
            this.Btn_Tile1.Location = new System.Drawing.Point(56, 67);
            this.Btn_Tile1.Name = "Btn_Tile1";
            this.Btn_Tile1.Size = new System.Drawing.Size(128, 128);
            this.Btn_Tile1.TabIndex = 12;
            this.Btn_Tile1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Tile1.UseVisualStyleBackColor = true;
            this.Btn_Tile1.Click += new System.EventHandler(this.Btn_Tile1_Click);
            // 
            // Btn_Tile2
            // 
            this.Btn_Tile2.Location = new System.Drawing.Point(190, 81);
            this.Btn_Tile2.Name = "Btn_Tile2";
            this.Btn_Tile2.Size = new System.Drawing.Size(91, 54);
            this.Btn_Tile2.TabIndex = 13;
            this.Btn_Tile2.Text = "button2";
            this.Btn_Tile2.UseVisualStyleBackColor = true;
            // 
            // Btn_Tile3
            // 
            this.Btn_Tile3.Location = new System.Drawing.Point(303, 81);
            this.Btn_Tile3.Name = "Btn_Tile3";
            this.Btn_Tile3.Size = new System.Drawing.Size(91, 54);
            this.Btn_Tile3.TabIndex = 14;
            this.Btn_Tile3.Text = "button3";
            this.Btn_Tile3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 54);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(190, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 54);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(303, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 54);
            this.button6.TabIndex = 17;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Btn_Till
            // 
            this.Btn_Till.Location = new System.Drawing.Point(589, 81);
            this.Btn_Till.Name = "Btn_Till";
            this.Btn_Till.Size = new System.Drawing.Size(91, 54);
            this.Btn_Till.TabIndex = 18;
            this.Btn_Till.Text = "Till ";
            this.Btn_Till.UseVisualStyleBackColor = true;
            this.Btn_Till.Click += new System.EventHandler(this.Btn_Till_Click);
            // 
            // btn_water
            // 
            this.btn_water.Location = new System.Drawing.Point(589, 141);
            this.btn_water.Name = "btn_water";
            this.btn_water.Size = new System.Drawing.Size(91, 54);
            this.btn_water.TabIndex = 19;
            this.btn_water.Text = "Water";
            this.btn_water.UseVisualStyleBackColor = true;
            this.btn_water.Click += new System.EventHandler(this.btn_water_Click);
            // 
            // btn_harvest
            // 
            this.btn_harvest.Location = new System.Drawing.Point(589, 261);
            this.btn_harvest.Name = "btn_harvest";
            this.btn_harvest.Size = new System.Drawing.Size(91, 54);
            this.btn_harvest.TabIndex = 21;
            this.btn_harvest.Text = "Harvest";
            this.btn_harvest.UseVisualStyleBackColor = true;
            this.btn_harvest.Click += new System.EventHandler(this.btn_harvest_Click);
            // 
            // btn_plant
            // 
            this.btn_plant.Location = new System.Drawing.Point(589, 201);
            this.btn_plant.Name = "btn_plant";
            this.btn_plant.Size = new System.Drawing.Size(91, 54);
            this.btn_plant.TabIndex = 20;
            this.btn_plant.Text = "Plant";
            this.btn_plant.UseVisualStyleBackColor = true;
            this.btn_plant.Click += new System.EventHandler(this.btn_plant_Click);
            // 
            // lblselectedAction
            // 
            this.lblselectedAction.AutoSize = true;
            this.lblselectedAction.Location = new System.Drawing.Point(573, 384);
            this.lblselectedAction.Name = "lblselectedAction";
            this.lblselectedAction.Size = new System.Drawing.Size(107, 16);
            this.lblselectedAction.TabIndex = 22;
            this.lblselectedAction.Text = "Selected Action: ";
            // 
            // progressbar_tile1
            // 
            this.progressbar_tile1.Location = new System.Drawing.Point(56, 201);
            this.progressbar_tile1.Name = "progressbar_tile1";
            this.progressbar_tile1.Size = new System.Drawing.Size(128, 23);
            this.progressbar_tile1.TabIndex = 23;
            this.progressbar_tile1.Visible = false;
            // 
            // PlantCrop_Timer
            // 
            this.PlantCrop_Timer.Interval = 1000;
            this.PlantCrop_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tile1_Timer
            // 
            this.Tile1_Timer.Tick += new System.EventHandler(this.Tile1_Timer_Tick);
            // 
            // TileState
            // 
            this.TileState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TileState.ImageStream")));
            this.TileState.TransparentColor = System.Drawing.Color.Transparent;
            this.TileState.Images.SetKeyName(0, "tile000.png");
            this.TileState.Images.SetKeyName(1, "tile001.png");
            this.TileState.Images.SetKeyName(2, "tile002.png");
            this.TileState.Images.SetKeyName(3, "tile003.png");
            this.TileState.Images.SetKeyName(4, "tile004.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.progressbar_tile1);
            this.Controls.Add(this.lblselectedAction);
            this.Controls.Add(this.btn_harvest);
            this.Controls.Add(this.btn_plant);
            this.Controls.Add(this.btn_water);
            this.Controls.Add(this.Btn_Till);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Btn_Tile3);
            this.Controls.Add(this.Btn_Tile2);
            this.Controls.Add(this.Btn_Tile1);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btnSellCrops);
            this.Controls.Add(this.lblCropstoSell);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnHarvestCrop_Tile1);
            this.Controls.Add(this.btnPlantCrop_Tile1);
            this.Controls.Add(this.lblCropsPlanted);
            this.Controls.Add(this.lblCoins);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblCropsPlanted;
        private System.Windows.Forms.Button btnPlantCrop_Tile1;
        private System.Windows.Forms.Button btnHarvestCrop_Tile1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblCropstoSell;
        private System.Windows.Forms.Button btnSellCrops;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Button Btn_Tile1;
        private System.Windows.Forms.Button Btn_Tile2;
        private System.Windows.Forms.Button Btn_Tile3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Btn_Till;
        private System.Windows.Forms.Button btn_water;
        private System.Windows.Forms.Button btn_harvest;
        private System.Windows.Forms.Button btn_plant;
        private System.Windows.Forms.Label lblselectedAction;
        private System.Windows.Forms.ProgressBar progressbar_tile1;
        private System.Windows.Forms.Timer PlantCrop_Timer;
        private System.Windows.Forms.Timer Tile1_Timer;
        private System.Windows.Forms.ImageList TileState;
    }
}

