/* ForRunTest.cs
 * ==========
 * 
 * StopLossSimulation
 * Copyright © 2008, 2009 Gaurav Bansal (gaurav3@gmail.com). All Rights Reserved.
 * 
 *  This file is part of StopLossSimulation.

 *  StopLossSimulation is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  StopLossSimulation is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with StopLossSimulation.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StopLossSimulation
{
    public partial class Simulator : Form
    {
        CalculationEngine ce;

        public Simulator()
        {
            InitializeComponent();

            ce = new CalculationEngine ( );
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if ( ce.data == null )
            {
                btnNewData_Click ( sender, e );
            }

            double stopLoss;
            if ( double.TryParse ( txtStoplossLimit.Text, out stopLoss ) )
                ce.stopLossLimit = stopLoss;
            
            double averageProfit;
            ce.Test(out averageProfit);

            txtAverageProfit.Text = averageProfit.ToString ( );

            txtProfitablesTrades.Text = ce.ProfitableTrades.ToString();
            txtLossmakingTrades.Text = ce.LossmakingTrades.ToString();
            txtStoppedOut.Text = ce.StoppedOut.ToString();

            ce.ResetCounters();
        }

        private void btnNewData_Click(object sender, EventArgs e)
        {
            double volatilityFactor;
            if ( Double.TryParse ( txtVolatility.Text, out volatilityFactor ) )
                ce.GenerateData ( volatilityFactor );
            else
                ce.GenerateData ( );
        }
    }
}