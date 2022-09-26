using System;
using System.Drawing;

namespace ladder_and_snake
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.pictureDiceBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Player_2_Score = new System.Windows.Forms.Label();
            this.Player_1_Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player2Box = new System.Windows.Forms.PictureBox();
            this.player1Box = new System.Windows.Forms.PictureBox();
            this.outBox = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiceBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.outBox);
            this.panel2.Controls.Add(this.playerBox);
            this.panel2.Controls.Add(this.pictureDiceBox);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(1055, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 826);
            this.panel2.TabIndex = 1;
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.White;
            this.playerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerBox.Location = new System.Drawing.Point(110, 34);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(105, 101);
            this.playerBox.TabIndex = 4;
            this.playerBox.TabStop = false;
            // 
            // pictureDiceBox
            // 
            this.pictureDiceBox.BackgroundImage = global::Ladder_And_Snake.Properties.Resources.dice_0;
            this.pictureDiceBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureDiceBox.Location = new System.Drawing.Point(68, 160);
            this.pictureDiceBox.Name = "pictureDiceBox";
            this.pictureDiceBox.Size = new System.Drawing.Size(186, 179);
            this.pictureDiceBox.TabIndex = 3;
            this.pictureDiceBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Player_2_Score);
            this.panel3.Controls.Add(this.Player_1_Score);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(68, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 122);
            this.panel3.TabIndex = 2;
            // 
            // Player_2_Score
            // 
            this.Player_2_Score.AutoSize = true;
            this.Player_2_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_2_Score.Location = new System.Drawing.Point(123, 78);
            this.Player_2_Score.Name = "Player_2_Score";
            this.Player_2_Score.Size = new System.Drawing.Size(15, 16);
            this.Player_2_Score.TabIndex = 3;
            this.Player_2_Score.Text = "0";
            // 
            // Player_1_Score
            // 
            this.Player_1_Score.AutoSize = true;
            this.Player_1_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_1_Score.Location = new System.Drawing.Point(123, 23);
            this.Player_1_Score.Name = "Player_1_Score";
            this.Player_1_Score.Size = new System.Drawing.Size(15, 16);
            this.Player_1_Score.TabIndex = 2;
            this.Player_1_Score.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1 :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(68, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Dice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 751);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 65);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BackgroundImage = global::Ladder_And_Snake.Properties.Resources.b1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.player2Box);
            this.panel1.Controls.Add(this.player1Box);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 826);
            this.panel1.TabIndex = 2;
            // 
            // player2Box
            // 
            this.player2Box.BackColor = System.Drawing.Color.Transparent;
            this.player2Box.BackgroundImage = global::Ladder_And_Snake.Properties.Resources._2P;
            this.player2Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2Box.Location = new System.Drawing.Point(-80, 750);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(100, 70);
            this.player2Box.TabIndex = 0;
            this.player2Box.TabStop = false;
            // 
            // player1Box
            // 
            this.player1Box.BackColor = System.Drawing.Color.Transparent;
            this.player1Box.BackgroundImage = global::Ladder_And_Snake.Properties.Resources._1P1;
            this.player1Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1Box.Location = new System.Drawing.Point(-80, 750);
            this.player1Box.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(100, 70);
            this.player1Box.TabIndex = 0;
            this.player1Box.TabStop = false;
            // 
            // outBox
            // 
            this.outBox.BackColor = System.Drawing.Color.White;
            this.outBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outBox.Location = new System.Drawing.Point(63, 596);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(204, 145);
            this.outBox.TabIndex = 5;
            this.outBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 844);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiceBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outBox)).EndInit();
            this.ResumeLayout(false);

        }

        public static int randDice(int x) //CHANGE DICE BOX IN RANDOM FACE
        {
            Random r = new Random();
            int dice = r.Next(1, 7);
            return dice == x ? r.Next(1, 7) : dice;
        }

        public static Image getImagePath(string dir = "", bool _static = true) //GET IMAGES FILE FROM path => root/static + dirFilePath
        {
             return Image.FromFile(AppDomain.CurrentDomain.BaseDirectory.Split(new string[] { "bin" }, @StringSplitOptions.None)[0] + (_static ? $"static\\{dir}" : dir));
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Player_1_Score;
        private System.Windows.Forms.Label Player_2_Score;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureDiceBox;
        private System.Windows.Forms.PictureBox player1Box;
        private System.Windows.Forms.PictureBox player2Box;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.PictureBox outBox;
    }
}

