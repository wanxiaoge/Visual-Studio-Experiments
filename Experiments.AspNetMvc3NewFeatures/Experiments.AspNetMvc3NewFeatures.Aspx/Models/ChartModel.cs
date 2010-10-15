﻿using System;
using System.Collections;

namespace Experiments.AspNetMvc3NewFeatures.Aspx.Models
{
    public class ChartModel
    {
        public virtual IList GetChartData()
        {
            return new ArrayList
                       {
                           new { X = DateTime.Now.AddMonths(-2), Y = 200 },
                           new { X = DateTime.Now.AddMonths(-1), Y = 300 },
                           new { X = DateTime.Now, Y = 500 }
                       };
        }
    }
}