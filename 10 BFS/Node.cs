﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_10;

namespace Module_10
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public Node(int value )
        { 
            Value = value;
            Left = null;
            Right = null;
        
        }

    }
}
