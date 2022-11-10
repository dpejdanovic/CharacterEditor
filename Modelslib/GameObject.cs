﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelslib
{
    public abstract class GameObject
    {
        public string? Name { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public Image? Icon { get; set; }
    }
}
