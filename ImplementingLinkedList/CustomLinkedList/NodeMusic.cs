﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class NodeMusic
    {
        public NodeMusic(string src)
        {
            Value = src;

        }
        public string Value { get; set; }
        public NodeMusic Next { get; set; }
        public NodeMusic Previous { get; set; }

        


    }
}
