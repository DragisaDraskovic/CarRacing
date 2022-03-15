namespace CarRacing
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.pB6 = new System.Windows.Forms.PictureBox();
            this.pB5 = new System.Windows.Forms.PictureBox();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Score:";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.Color.Yellow;
            this.lblCoins.Location = new System.Drawing.Point(66, 9);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(14, 13);
            this.lblCoins.TabIndex = 7;
            this.lblCoins.Text = "0";
            // 
            // coin2
            // 
            this.coin2.Image = global::CarRacing.Properties.Resources.Coin_icon;
            this.coin2.Location = new System.Drawing.Point(250, 250);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(25, 25);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 10;
            this.coin2.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Image = global::CarRacing.Properties.Resources.Coin_icon;
            this.coin1.Location = new System.Drawing.Point(80, 80);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(25, 25);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 9;
            this.coin1.TabStop = false;
            // 
            // car
            // 
            this.car.Image = global::CarRacing.Properties.Resources.Car_Front_Red_icon__2_;
            this.car.Location = new System.Drawing.Point(69, 365);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(25, 65);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car.TabIndex = 8;
            this.car.TabStop = false;
            // 
            // pB6
            // 
            this.pB6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pB6.Location = new System.Drawing.Point(373, -3);
            this.pB6.Name = "pB6";
            this.pB6.Size = new System.Drawing.Size(10, 467);
            this.pB6.TabIndex = 5;
            this.pB6.TabStop = false;
            // 
            // pB5
            // 
            this.pB5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pB5.Location = new System.Drawing.Point(3, -3);
            this.pB5.Name = "pB5";
            this.pB5.Size = new System.Drawing.Size(10, 467);
            this.pB5.TabIndex = 4;
            this.pB5.TabStop = false;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line4.Location = new System.Drawing.Point(171, 365);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(10, 122);
            this.line4.TabIndex = 3;
            this.line4.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line3.Location = new System.Drawing.Point(171, 228);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(10, 122);
            this.line3.TabIndex = 2;
            this.line3.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line2.Location = new System.Drawing.Point(171, 91);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 122);
            this.line2.TabIndex = 1;
            this.line2.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line1.Location = new System.Drawing.Point(171, -48);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 122);
            this.line1.TabIndex = 0;
            this.line1.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.Image = global::CarRacing.Properties.Resources.Coin_icon;
            this.coin3.Location = new System.Drawing.Point(80, 270);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(25, 25);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 11;
            this.coin3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = global::CarRacing.Properties.Resources.Car_Front_Red_icon__2_;
            this.enemy1.Location = new System.Drawing.Point(110, 110);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(30, 30);
            this.enemy1.TabIndex = 12;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = global::CarRacing.Properties.Resources.Car_Front_Red_icon__2_;
            this.enemy2.Location = new System.Drawing.Point(250, 70);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(30, 30);
            this.enemy2.TabIndex = 13;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::CarRacing.Properties.Resources.Car_Front_Red_icon__2_;
            this.enemy3.Location = new System.Drawing.Point(50, 200);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(30, 30);
            this.enemy3.TabIndex = 14;
            this.enemy3.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(90, 200);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(186, 31);
            this.lblGameOver.TabIndex = 15;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pB6);
            this.Controls.Add(this.pB5);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Name = "Form1";
            this.Text = "Car racing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox pB5;
        private System.Windows.Forms.PictureBox pB6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label lblGameOver;
    }
}

