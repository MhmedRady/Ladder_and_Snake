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
        
        bool Player = true;
        int lastLeft = -60;
        IDictionary<string, int> Player_1_Position = new Dictionary<string, int>() { 
            { "score", 0 }, { "row", 1}, { "col", 0 } 
        };
        IDictionary<string, int> Player_2_Position = new Dictionary<string, int>() { 
            { "score", 0 }, { "row", 1}, { "col", 0 } 
        };

        IDictionary<string, int> ladders = new Dictionary<string, int>() {
            { "ladder_1", 38 }, { "ladder_4", 14 }, { "ladder_9", 31 }, 
            { "ladder_21", 42 }, { "ladder_28", 84 }, { "ladder_51", 67 },
            { "ladder_71", 91 }, { "ladder_80", 100 }
        };

        IDictionary<string, int> snakes = new Dictionary<string, int>() {
            { "snake_17", 7 }, { "snakes_54", 34 }, { "snake_62", 19 },
            { "snake_64", 60 }, { "snake_87", 24 }, { "snake_93", 73 },
            { "snake_95", 75 }, { "snake_98", 79 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.playerBox.Image = Form1.getImagePath($@"images\player\" + (!Player ? "2P" : "1P") + ".png");
            this.playerBox.Refresh();

            this.button1.Enabled = false;
            this.button1.Visible = false;

            //CHANGE DICE BOX IN RANDOM FACE
            for (int i = 1; i <= 6; i++)
            {
                this.pictureDiceBox.Image = Form1.getImagePath($@"images\dice\dice_{Form1.randDice(i)}.jpg");
                this.pictureDiceBox.Refresh();
                Thread.Sleep(800);
            }

            Debug.WriteLine("no sleep");
            this.dice = Form1.randDice(this.dice);
            this.pictureDiceBox.Image = Form1.getImagePath($@"images\dice\dice_{dice}.jpg");
            this.button1.Visible = true;
            this.button1.Enabled = true;
            this.updatePlayerScore();

            this.Player = !this.Player;
        }

        private void updatePlayerScore()
        {
            if (this.Player)
            {
                Player_1_Position["score"] = Player_1_Position["score"] + dice > 100 ? 100 : Player_1_Position["score"] + dice;
                this.Player_1_Score.Text = Player_1_Position["score"].ToString();

                // CHANGE PALYER ONE POSITION
                this.get_player_position(player1Box, (Dictionary<string, int>)this.Player_1_Position);
                ladder((Dictionary<string, int>)this.Player_1_Position, player1Box); // CHANGE PLAYER BOX IF SCORE IN LADDERS DICTIONARY
                snakeHead((Dictionary<string, int>)this.Player_1_Position, player1Box); // CHANGE PLAYER BOX IF SCORE IN SNAKES DICTIONARY
            }
            else
            {
                Player_2_Position["score"] = Player_2_Position["score"] + dice > 100 ? 100 : Player_2_Position["score"] + dice;
                this.Player_2_Score.Text = Player_2_Position["score"].ToString();

                // CHANGE PALYER TOW POSITION
                this.get_player_position(player2Box, (Dictionary<string, int>)this.Player_2_Position);
                ladder((Dictionary<string, int>)this.Player_1_Position, player1Box); // CHANGE PLAYER BOX IF SCORE IN LADDERS DICTIONARY
                snakeHead((Dictionary<string, int>)this.Player_1_Position, player1Box); // CHANGE PLAYER BOX IF SCORE IN SNAKES DICTIONARY
            }
        }
        // SNAKE CAHNGE PLAYER SCORE
        public void snakeHead(Dictionary<string, int> PlayerPosition, PictureBox PlayerBox)
        {
            if(snakes.ContainsKey("snake_" + PlayerPosition["score"])) {
                this.outBox.Visible = true;
                this.outBox.BackgroundImage = Form1.getImagePath($@"images\snake.png");
                this.outBox.Refresh();
                Thread.Sleep(800);
                this.get_player_position(PlayerBox, (Dictionary<string, int>)this.Player_1_Position);
            }else
            {
                this.outBox.Visible = false;
                this.outBox.Image = null;
                this.outBox.Refresh();
            }
        }

        // LADDER CAHNGE PLAYER SCORE
        public void ladder(Dictionary<string, int> PlayerPosition, PictureBox PlayerBox)
        {
            if (ladders.ContainsKey("ladder_" + PlayerPosition["score"]))
            {
                this.outBox.Visible = true;
                this.outBox.BackgroundImage = Form1.getImagePath($@"images\ladder.png");
                this.outBox.Refresh();
                Thread.Sleep(800);
                this.get_player_position(PlayerBox, (Dictionary<string, int>)this.Player_1_Position);
            }
            else
            {
                this.outBox.Visible = false;
                this.outBox.Image = null;
                this.outBox.Refresh();
            }
        }

        public bool winnerPlayer()
        {
            this.outBox.Visible = true;
            this.outBox.BackgroundImage = Form1.getImagePath($@"images\you-win.jpg");
            this.outBox.Refresh();
            Thread.Sleep(2000);
            Application.Exit();
            return true;
        }

        public void get_player_position(PictureBox PlayerBox, Dictionary<string, int> PlayerPosition)
        {

            if(PlayerPosition["score"] >= 100) winnerPlayer();
            float position = (float)PlayerPosition["score"] / 10;
            int row = position == 1?1:(int)Math.Floor(position)+1; // NEW ROW NUMBER
            Debug.WriteLine($"left before: {PlayerBox.Left}");
            Array _col = position.ToString().Split('.');
            int col = position == 1 || _col.Length == 1 ?10: int.Parse(position.ToString().Split('.')[1]); // NEW ROW NUMBER

            int newCol = col + PlayerPosition["col"];

            col = newCol > 10 ? newCol - col: col ;

            if (PlayerPosition["row"] != row)
            {
                PlayerBox.Top -= 40 * row; // Move To Up ROW
                PlayerPosition["row"] = row;
            }

            PlayerBox.Left = lastLeft;
            if (row%2 != 0) {
                PlayerBox.Left += PlayerBox.Width * col; //Move Player Box To Right
            }
            else{
                PlayerBox.Left = 780 - 80 * col; //Move Player Box To Left
            }
            PlayerPosition["col"] = col;
            Debug.WriteLine($"last col: {PlayerPosition["col"]}");
        }
    }
}
