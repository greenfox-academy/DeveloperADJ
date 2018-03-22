﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;
using Wanderer_Game.Controller;
using Wanderer_Game.Model;
using Wanderer_Game.View;

namespace Wanderer_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Draw graphics;
        public Player player;
        Enemies enemies;
        GameSetup gameSetup;
        HUD HUD;

        int turnCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);

            gameSetup = new GameSetup(canvas, 500);
            enemies = new Enemies();
            HUD = new HUD(canvas);
            player = new Player("Hero", HUD, enemies, canvas, Images.heroDown);
            graphics = new Draw(canvas, foxDraw, enemies, HUD, player);

            Characters.AddToList(player);

            enemies.Add(new Enemy("Boss", player, canvas, Images.boss, 9, 9, true, 100, 100, 10));
            enemies.Add(new Enemy("SkeletonA", player, canvas, Images.skeleton, 0, 5));
            enemies.Add(new Enemy("SkeletonB", player, canvas, Images.skeleton, 4, 3));
            enemies.Add(new Enemy("SkeletonC", player, canvas, Images.skeleton, 7, 8));

            graphics.Refresh();
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (!player.isInBattle)
            {
                turnCount++;

                if (e.Key == Key.Left)
                {
                    player.Move("left");
                    graphics.Refresh();
                }

                if (e.Key == Key.Right)
                {
                    player.Move("right");
                    graphics.Refresh();
                }

                if (e.Key == Key.Up)
                {
                    player.Move("up");
                    graphics.Refresh();
                }

                if (e.Key == Key.Down)
                {
                    player.Move("down");
                    graphics.Refresh();
                }

                if (turnCount % 2 == 0)
                {
                    enemies.Move();
                }
            }
            else
            {
                if (e.Key == Key.Space)
                {
                    if (!player.isDead && player.isInBattle)
                    {
                        player.isInBattle = false;
                        HUD.playerStatus.Text = player.GetStatus();
                    }
                    else
                    {
                        HUD.playerStatus.Text = "GAME OVER\nStats:\n " + player.GetStatus();
                    }

                    graphics.Refresh();
                }
            }
        }
    }
}
