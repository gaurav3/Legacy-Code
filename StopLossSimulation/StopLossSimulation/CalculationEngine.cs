/* CalculationEngine.cs
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
using System.Text;

namespace StopLossSimulation
{
    public class CalculationEngine
    {
        public double[] data;
        int length = 100000;
        public double stopLossLimit = 1; //in percent
        double volatilityFactor = 2;
        int trades = 100000;
        public int ProfitableTrades, LossmakingTrades, StoppedOut;

        Random rand = new Random ( );

        public void GenerateData ( )
        {
            data = new double[ length ];
            data[ 0 ] = 100;
            for ( int i = 1 ; i < length ; i++ )
            {
                double temp = rand.NextDouble ( );

                data[ i ] = data[ i - 1 ] + volatilityFactor * ( temp - 0.5 );

            }
        }

        public void GenerateData (double _volatilityFactor )
        {
            volatilityFactor = _volatilityFactor;
            GenerateData ( );
        }

        public void Test ( out double _averageProfit )
        {
            int start;
            double temp_profit, sum_profit = 0;

            for ( int i = 0 ; i < trades ; i++ )
            {
                //pick up a trade position
                start = rand.Next ( length );
                //trade
                temp_profit = Trade ( start );
                sum_profit += temp_profit;
            }

            _averageProfit = sum_profit / trades;
        }

        public double Trade ( int start )
        {
            double highest = 0, stopLoss = 0, current, profit;


            int currentPosition = start;
            current = data[ start ];

            while ( true )
            {
                if ( highest < current )
                {
                    highest = current;
                    stopLoss = ( ( 100 - stopLossLimit ) / 100 ) * highest;
                }
                if ( stopLoss > current )
                {
                    StoppedOut++;
                    break;
                }

                currentPosition++;
                if ( currentPosition >= length )
                    break;
                current = data[ currentPosition ];
            }

            profit = ( current - data[ start ] ) * 100 / data[ start ]; //in percentage

            if ( profit > 0 )
                ProfitableTrades++;
            else if ( profit < 0 )
                LossmakingTrades++;

            return profit;
        }

        public void ResetCounters ( )
        {
            StoppedOut = 0;
            ProfitableTrades = 0;
            LossmakingTrades = 0;
        }

    }
}
