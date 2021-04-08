
namespace GUI_Task
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBarCargo = new System.Windows.Forms.ProgressBar();
            this.tBarMotoCycle = new System.Windows.Forms.TrackBar();
            this.tBarCar = new System.Windows.Forms.TrackBar();
            this.tBarTruck = new System.Windows.Forms.TrackBar();
            this.tBarTarinCar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewBoat = new System.Windows.Forms.Button();
            this.lblMotoCycle = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblTruck = new System.Windows.Forms.Label();
            this.lblTarinCar = new System.Windows.Forms.Label();
            this.lblCapacityAndLoad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarMotoCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTarinCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::GUI_Task.Properties.Resources.cargoship;
            this.pictureBox1.Location = new System.Drawing.Point(74, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 280);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pBarCargo
            // 
            this.pBarCargo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pBarCargo.ForeColor = System.Drawing.Color.Goldenrod;
            this.pBarCargo.Location = new System.Drawing.Point(197, 56);
            this.pBarCargo.Name = "pBarCargo";
            this.pBarCargo.Size = new System.Drawing.Size(459, 141);
            this.pBarCargo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBarCargo.TabIndex = 1;
            // 
            // tBarMotoCycle
            // 
            this.tBarMotoCycle.Location = new System.Drawing.Point(74, 343);
            this.tBarMotoCycle.Name = "tBarMotoCycle";
            this.tBarMotoCycle.Size = new System.Drawing.Size(183, 45);
            this.tBarMotoCycle.TabIndex = 2;
            this.tBarMotoCycle.Tag = "";
            this.tBarMotoCycle.Scroll += new System.EventHandler(this.tBarMotoCycle_Scroll);
            // 
            // tBarCar
            // 
            this.tBarCar.Location = new System.Drawing.Point(74, 433);
            this.tBarCar.Name = "tBarCar";
            this.tBarCar.Size = new System.Drawing.Size(183, 45);
            this.tBarCar.TabIndex = 3;
            this.tBarCar.Tag = "";
            this.tBarCar.Scroll += new System.EventHandler(this.tBarCar_Scroll);
            // 
            // tBarTruck
            // 
            this.tBarTruck.Location = new System.Drawing.Point(481, 343);
            this.tBarTruck.Name = "tBarTruck";
            this.tBarTruck.Size = new System.Drawing.Size(183, 45);
            this.tBarTruck.TabIndex = 4;
            this.tBarTruck.Tag = "";
            this.tBarTruck.Scroll += new System.EventHandler(this.tBarTruck_Scroll);
            // 
            // tBarTarinCar
            // 
            this.tBarTarinCar.Location = new System.Drawing.Point(481, 433);
            this.tBarTarinCar.Name = "tBarTarinCar";
            this.tBarTarinCar.Size = new System.Drawing.Size(183, 45);
            this.tBarTarinCar.TabIndex = 5;
            this.tBarTarinCar.Tag = "";
            this.tBarTarinCar.Scroll += new System.EventHandler(this.tBarTarinCar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Motor Cycle (3 units)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cars (5 units)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trucks (11 units)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Train Car (17 units)";
            // 
            // btnNewBoat
            // 
            this.btnNewBoat.Location = new System.Drawing.Point(87, 515);
            this.btnNewBoat.Name = "btnNewBoat";
            this.btnNewBoat.Size = new System.Drawing.Size(75, 23);
            this.btnNewBoat.TabIndex = 10;
            this.btnNewBoat.Text = "New Boat";
            this.btnNewBoat.UseVisualStyleBackColor = true;
            this.btnNewBoat.Click += new System.EventHandler(this.btnNewBoat_Click);
            // 
            // lblMotoCycle
            // 
            this.lblMotoCycle.AutoSize = true;
            this.lblMotoCycle.Location = new System.Drawing.Point(144, 327);
            this.lblMotoCycle.Name = "lblMotoCycle";
            this.lblMotoCycle.Size = new System.Drawing.Size(0, 13);
            this.lblMotoCycle.TabIndex = 11;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(144, 419);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(0, 13);
            this.lblCar.TabIndex = 12;
            // 
            // lblTruck
            // 
            this.lblTruck.AutoSize = true;
            this.lblTruck.Location = new System.Drawing.Point(537, 327);
            this.lblTruck.Name = "lblTruck";
            this.lblTruck.Size = new System.Drawing.Size(0, 13);
            this.lblTruck.TabIndex = 13;
            // 
            // lblTarinCar
            // 
            this.lblTarinCar.AutoSize = true;
            this.lblTarinCar.Location = new System.Drawing.Point(537, 419);
            this.lblTarinCar.Name = "lblTarinCar";
            this.lblTarinCar.Size = new System.Drawing.Size(0, 13);
            this.lblTarinCar.TabIndex = 14;
            // 
            // lblCapacityAndLoad
            // 
            this.lblCapacityAndLoad.AutoSize = true;
            this.lblCapacityAndLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCapacityAndLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacityAndLoad.Location = new System.Drawing.Point(204, 204);
            this.lblCapacityAndLoad.Name = "lblCapacityAndLoad";
            this.lblCapacityAndLoad.Size = new System.Drawing.Size(0, 29);
            this.lblCapacityAndLoad.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 550);
            this.Controls.Add(this.lblCapacityAndLoad);
            this.Controls.Add(this.lblTarinCar);
            this.Controls.Add(this.lblTruck);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblMotoCycle);
            this.Controls.Add(this.btnNewBoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBarTarinCar);
            this.Controls.Add(this.tBarTruck);
            this.Controls.Add(this.tBarCar);
            this.Controls.Add(this.tBarMotoCycle);
            this.Controls.Add(this.pBarCargo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarMotoCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTarinCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pBarCargo;
        private System.Windows.Forms.TrackBar tBarMotoCycle;
        private System.Windows.Forms.TrackBar tBarCar;
        private System.Windows.Forms.TrackBar tBarTruck;
        private System.Windows.Forms.TrackBar tBarTarinCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewBoat;
        private System.Windows.Forms.Label lblMotoCycle;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblTruck;
        private System.Windows.Forms.Label lblTarinCar;
        private System.Windows.Forms.Label lblCapacityAndLoad;
    }
}

