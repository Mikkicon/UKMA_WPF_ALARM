﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.APZRPMJ2018.WalletSimulator.Models
{
    public class Alarm
    {

        public List<int> Hours { get; set; }
        public List<int> Minutes { get; set; }


        public Alarm()
        {
            Initialize();
        }
        public void Initialize()
        {
            Hours = new List<int>();
            Minutes = new List<int>();
            for (int i = 0; i < 24; i++)
            {
                Hours.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                Minutes.Add(i);
            }
        }
    }
}