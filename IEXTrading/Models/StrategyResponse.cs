﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEXTrading.Models
{
    public class StrategyResponse
    {
        public StrategyResponse() { }
        public string symbol { get; set; }
        public string companyName { get; set; }
        public float? StrategyValue { get; set; }

    }
}
