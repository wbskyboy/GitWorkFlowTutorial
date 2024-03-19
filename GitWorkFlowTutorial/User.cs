﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWorkFlowTutorial
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime BirthDay { get; set; }
        public Bitmap Picture { get; set; }
    }
}
