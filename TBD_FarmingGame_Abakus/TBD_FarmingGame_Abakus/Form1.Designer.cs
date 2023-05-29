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
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblCropsPlanted = new System.Windows.Forms.Label();
            this.btnPlantCrop_Tile1 = new System.Windows.Forms.Button();
            this.btnHarvestCrop_Tile1 = new System.Windows.Forms.Button();
            this.PlantCrop_Timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblCropstoSell = new System.Windows.Forms.Label();
            this.btnSellCrops = new System.Windows.Forms.Button();
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
            this.lblCropsPlanted.Location = new System.Drawing.Point(12, 25);
            this.lblCropsPlanted.Name = "lblCropsPlanted";
            this.lblCropsPlanted.Size = new System.Drawing.Size(95, 16);
            this.lblCropsPlanted.TabIndex = 1;
            this.lblCropsPlanted.Text = "Crops Planted:";
            // 
            // btnPlantCrop_Tile1
            // 
            this.btnPlantCrop_Tile1.Location = new System.Drawing.Point(74, 155);
            this.btnPlantCrop_Tile1.Name = "btnPlantCrop_Tile1";
            this.btnPlantCrop_Tile1.Size = new System.Drawing.Size(91, 23);
            this.btnPlantCrop_Tile1.TabIndex = 2;
            this.btnPlantCrop_Tile1.Text = "PlantCrop";
            this.btnPlantCrop_Tile1.UseVisualStyleBackColor = true;
            this.btnPlantCrop_Tile1.Click += new System.EventHandler(this.btnPlantCrops_Click_1);
            // 
            // btnHarvestCrop_Tile1
            // 
            this.btnHarvestCrop_Tile1.Location = new System.Drawing.Point(74, 184);
            this.btnHarvestCrop_Tile1.Name = "btnHarvestCrop_Tile1";
            this.btnHarvestCrop_Tile1.Size = new System.Drawing.Size(91, 23);
            this.btnHarvestCrop_Tile1.TabIndex = 3;
            this.btnHarvestCrop_Tile1.Text = "HarvestCrops";
            this.btnHarvestCrop_Tile1.UseVisualStyleBackColor = true;
            this.btnHarvestCrop_Tile1.Click += new System.EventHandler(this.btnHarvestCrops_Click_1);
            // 
            // PlantCrop_Timer
            // 
            this.PlantCrop_Timer.Interval = 1000;
            this.PlantCrop_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(74, 126);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(91, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // lblCropstoSell
            // 
            this.lblCropstoSell.AutoSize = true;
            this.lblCropstoSell.Location = new System.Drawing.Point(605, 184);
            this.lblCropstoSell.Name = "lblCropstoSell";
            this.lblCropstoSell.Size = new System.Drawing.Size(86, 16);
            this.lblCropstoSell.TabIndex = 5;
            this.lblCropstoSell.Text = "Crops to Sell:";
            // 
            // btnSellCrops
            // 
            this.btnSellCrops.Location = new System.Drawing.Point(608, 203);
            this.btnSellCrops.Name = "btnSellCrops";
            this.btnSellCrops.Size = new System.Drawing.Size(91, 23);
            this.btnSellCrops.TabIndex = 6;
            this.btnSellCrops.Text = "Sell Crops";
            this.btnSellCrops.UseVisualStyleBackColor = true;
            this.btnSellCrops.Click += new System.EventHandler(this.btnSellCrops_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Timer PlantCrop_Timer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblCropstoSell;
        private System.Windows.Forms.Button btnSellCrops;
    }
}

