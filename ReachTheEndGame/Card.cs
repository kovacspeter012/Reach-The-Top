﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReachTheEndGame
{
    internal class Card
    {
        public string BackImage { get; set; }
        public string FrontImage { get; set; }
        public int Id { get; set; }
        public Card(string backImage, string frontImage, int id)
        {
            BackImage = backImage;
            FrontImage = frontImage;
            Id = id;
        }
    }
}
