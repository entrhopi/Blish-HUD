﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Blish_HUD.Controls {

    public class RegionChangedEventArgs:EventArgs {
        public Rectangle PreviousRegion { get; }
        public Rectangle CurrentRegion  { get; }

        public RegionChangedEventArgs(Rectangle previousRegion, Rectangle currentRegion) {
            this.PreviousRegion = previousRegion;
            this.CurrentRegion  = currentRegion;
        }
    }

}
