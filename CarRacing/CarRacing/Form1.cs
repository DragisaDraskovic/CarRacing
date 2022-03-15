using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {
        RoadLines roadLines;
        RoadLinesCoordinator coordinator;
        Enemy enemy;
        EnemysCoordinator enemysCoordinator;
        Coin coin;
        CoinsCoordinator coinsCoordinator;
        Car mainCar;
        Score score;
        GameOver gameOver;
        public Form1()
        {
            InitializeComponent();
            roadLines = GameSetUpFactory.CreateRoadLines(line1, line2, line3, line4);
            coordinator = GameSetUpFactory.CreateRoadLinesCoordinator();
            enemy = GameSetUpFactory.CreateEnemy(enemy1, enemy2, enemy3);
            enemysCoordinator = GameSetUpFactory.CreateEnemysCoordinator();
            coin = GameSetUpFactory.CreateCoin(coin1, coin2, coin3);
            coinsCoordinator = GameSetUpFactory.CreateCoinsCoordinator();
            mainCar = new Car(car);
            score = new Score(lblCoins);
            gameOver = new GameOver(timer1, lblGameOver);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(15);
            Enemy(15);
            GameOver();
            Coins(7);
            CoinsCollection();

        }

        internal void MoveLine(int speed)
        {

            foreach(var line in roadLines.allRoadLines)
            {
                coordinator.MoveRoadLine(line, speed);  
            }
          /*  if (pB1.Top >= 500)
            {
                pB1.Top = -50;
            }
            else
            {
                pB1.Top += speed;
            }
            if (pB2.Top >= 500)
            {
                pB2.Top = -50;
            }
            else
            {
                pB2.Top += speed;
            }
            if (pB3.Top >= 500)
            {
                pB3.Top = -50;
            }
            else
            {
                pB3.Top += speed;
            }
            if (pB4.Top >= 500)
            {
                pB4.Top = -50;
            }
            else
            {
                pB4.Top += speed;
            } */
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                mainCar.MoveCarRight();
            }
            if (e.KeyCode == Keys.Right)
            {
                mainCar.MoveCarLeft();
            }
        }

        Random r = new Random();

        internal void Coins(int speed)
        {
            foreach (var coin in coin.allCoins)
            {
                coinsCoordinator.MoveCoin(coin, speed);
            }
            /*   if (Coin1.Top >= 500)
               {
                   var x = r.Next(0, 200);
                   Coin1.Location = new Point(x, 0);
               }
               else
               {
                   Coin1.Top += speed;
               }
               if (Coin2.Top >= 500)
               {
                   var x = r.Next(100, 300);
                   Coin2.Location = new Point(x, 0);
               }
               else
               {
                   Coin2.Top += speed;
               }
               if (Coin3.Top >= 500)
               {
                   var x = r.Next(0, 400);
                   Coin3.Location = new Point(x, 0);
               }
               else
               {
                   Coin3.Top += speed;
               } */
        }

        internal void CoinsCollection()
        { 
            if(coin.CheckWereBoundsTouched(mainCar))
            {
                // int temp = Convert.ToInt32(lblCoins.Text);
                // temp++;
                // lblCoins.Text = temp.ToString();
                score.SetScore();
            }/*
            if (mainCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                int temp = Convert.ToInt32(lblCoins.Text);
                temp++;
                lblCoins.Text = temp.ToString();
                coin1.Location = new Point(0, 200);
            }
            if (mainCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                int temp = Convert.ToInt32(lblCoins.Text);
                temp++; 
                coin2.Location = new Point(100, 300);
            }
            if (mainCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                int temp = Convert.ToInt32(lblCoins.Text);
                temp++;
                coin3.Location = new Point(200, 400);
            } */
        }

        internal void Enemy(int speed)
        {
            foreach (var enemy in enemy.allEnemys)
            {
                enemysCoordinator.MoveEnemy(enemy, speed);
            }
            /*
            if (enemy1.Top >= 500)
            {
                var x = r.Next(0, 200);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }
            if(enemy2.Top >= 500)
            {
                var x = r.Next(200, 400);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top >= 500)
            {
                var x = r.Next(0, 400);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            } */
        }

        internal void GameOver()
        {
            if (enemy.CheckWereBoundsTouched(mainCar))
            {
                gameOver.setGameLabel();
            }
            /*
            if (mainCar.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
            if (mainCar.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
            if (mainCar.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            } */
        }
    }
}
