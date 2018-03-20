﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Wanderer_Game.Model;

namespace Wanderer_Game.Controller
{
    public class Player : Character
    {
        int currentExp;
        int nextLevelExp;
        double positionX;
        double positionY;
        Canvas canvas;
        string playerSprite;

        public Player(Canvas canvas, int currentHP = 10, int maximumHP = 10, int attackPower = 5, int currentExp = 0, int nextLevelExp = 100, int level = 1, double positionX = 0, double positionY = 0):base(currentHP, maximumHP, attackPower, level) 
        {
            this.canvas = canvas;
            this.currentHP = currentHP;
            this.maximumHP = maximumHP;
            this.attackPower = attackPower;
            this.currentExp = currentExp;
            this.nextLevelExp = nextLevelExp;
            this.level = level;
            this.positionX = positionX;
            this.positionY = positionY;
            playerSprite = Assets.Images.heroDown;
        }

        public Point GetPosition()
        {
            return new Point(positionX, positionY);
        }

        public string GetImage()
        {
            return playerSprite;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Move(string direction)
        {
            if (direction.Equals("up"))
            {
                playerSprite = Assets.Images.HeroUp;
                if (!((positionY - canvas.Height/10) < 0))
                {
                    positionY -= canvas.Height / 10;
                }
            }
            else if (direction.Equals("right"))
            {
                playerSprite = Assets.Images.heroRight;
                if (!(positionX + (canvas.Height / 10) >= canvas.Width))
                {
                    positionX += canvas.Height / 10;
                }                
            }
            else if (direction.Equals("down"))
            {
                playerSprite = Assets.Images.heroDown;

                if (!(positionY + canvas.Height / 10 >= canvas.Height))
                {
                    positionY += canvas.Height / 10;
                }
            }
            else if (direction.Equals("left"))
            {
                playerSprite = Assets.Images.heroLeft;

                if (!(positionX - canvas.Height / 10 < 0))
                {
                    positionX -= canvas.Height / 10;
                }
            }
        }
    }
}
