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
            /*
            Debug.WriteLine(Player);
            Debug.WriteLine(Player_1);
            Debug.WriteLine(Player_2);
            */
            //this.player1Box.Top -= (this.player1Box.Height * 1);
            
            this.Player = !this.Player;
        }

        private void updatePlayerScore()
        {
            if (this.Player)
            {
                Player_1 = Player_1 + dice > 100 ? 100 : Player_1 + dice;
                this.Player_1_Score.Text = Player_1.ToString();
                //this.player1Box.Left = dice == 1 ? (this.player1Box.Width * 2) - 20 : (this.player1Box.Width * dice) - 20;
                this.player2Box.Visible = !this.player2Box.Visible ? true : false;
                Debug.WriteLine(Player_1);
                this.get_player_postion(Player_1);
            }
            else
            {
                Player_2 = Player_2 + dice > 100 ? 100 : Player_2 + dice;
                this.Player_2_Score.Text = Player_2.ToString();
                //this.player2Box.Left = dice == 1 ? (this.player2Box.Width * 2) - 20 : (this.player2Box.Width * dice) - 20;
                Debug.WriteLine(Player_2);
                this.get_player_postion(Player_2);
            }
            //this.Player = !this.Player;
        }

        public  void get_player_postion(int score)
        {
            float postion = (float)score /10;
            int row = postion <1?1: (int)Math.Floor(postion);
            string col = postion.ToString();
            Debug.WriteLine($"Row: {row}");
            Debug.WriteLine($"Col: {col[col.Length-1]}");  
        }

        private void pictureDiceBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
