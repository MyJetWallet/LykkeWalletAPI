﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LykkeApi2.Models.Affiliate
{
    public class AffiliateStatisticsResponse
    {
        public int ReferralsCount { get; set; }

        public double TotalBonus { get; set; }

        public double TotalTradeVolume { get; set; }
    }
}
