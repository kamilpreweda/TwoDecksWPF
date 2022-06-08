﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDecksWPF
{
    public class Card
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }
        public string Name { get { return $"{Value} {Suit}"; } }

        public override string ToString()
        {
            return Name;
        }

        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
    }
}
