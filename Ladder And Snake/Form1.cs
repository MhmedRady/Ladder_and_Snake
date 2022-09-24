using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Runtime.CompilerServices;

namespace ladder_and_snake
{
    public partial class Form1 : Form
    {
        int dice = 0;
        int Player_1 = 0;
        int Player_2 = 0;
        bool Player = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            for (int i = 1; i <= 6; i++)
            {
                Debug.WriteLine(Form1.randDice(i));
                this.pictureDiceBox.Image = Image.FromFile(Form1.getFilePath($@"images\dice\dice_{Form1.randDice(i)}.jpg"));
                this.pictureDiceBox.Refresh();
                Thread.Sleep(800);
            }
            this.button1.Visible = true;

            Debug.WriteLine("no sleep");
            this.dice = Form1.randDice(this.dice);
            this.pictureDiceBox.Image = Image.FromFile(Form1.getFilePath($@"images\dice\dice_{dice}.jpg"));
            this.button1.Enabled = true;
            this.updatePlayerScore();
            Debug.WriteLine(Player);
            Debug.WriteLine(Player_1);
            Debug.WriteLine(Player_2);
            this.Player = !this.Player;
        }

        private void updatePlayerScore()
        {
            if (this.Player)
            {
                Player_1 = Player_1 + dice > 100 ? 100 : Player_1 + dice;
                this.Player_1_Score.Text = Player_1.ToString();
            }
            else
            {
                Player_2 = Player_2 + dice > 100 ? 100 : Player_2 + dice;
                this.Player_2_Score.Text = Player_2.ToString();
            }
            //this.Player = !this.Player;
        }

        private void pictureDiceBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
