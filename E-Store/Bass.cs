﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store
{
    public class Bass
    {
        public string Brand;
        public int NumStrings;
        public string PickupType;

        public Bass(string brand, int numStrings, string pickupType)
        {
            Brand = brand;
            NumStrings = numStrings;
            PickupType = pickupType;
        }

    }
}
