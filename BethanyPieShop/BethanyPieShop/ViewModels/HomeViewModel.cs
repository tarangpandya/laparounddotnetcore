﻿using BethanyPieShop.Models;
using System.Collections.Generic;

namespace BethanyPieShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public IEnumerable<Pie> Pies { get; set; }
    }
}