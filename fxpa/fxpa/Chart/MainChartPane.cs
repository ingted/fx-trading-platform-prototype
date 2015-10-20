// -----
// GNU General Public License
// The Forex Professional Analyzer is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version. 
// The Forex Professional Analyzer is distributed in the hope that it will be useful, but without any warranty; without even the implied warranty of merchantability or fitness for a particular purpose.  
// See the GNU Lesser General Public License for more details.
// -----

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace fxpa
{
    public class MainChartPane : ChartPane
    {
        public delegate void CrossHairShowDelegate(MainChartPane pane, Point location);
        public event CrossHairShowDelegate CrossHairShowEvent;

        /// <summary>
        /// 
        /// </summary>
        public MainChartPane()
        {
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (CrosshairVisible && CrossHairShowEvent != null)
            {
                CrossHairShowEvent(this, e.Location);
            }
        }

    }
}
