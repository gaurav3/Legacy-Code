/* SimulationEngine.cs
 * ==========
 * 
 * VolatilityTradingSimulation
 * Copyright © 2008, 2009 Gaurav Bansal (gaurav3@gmail.com). All Rights Reserved.
 * 
 *  This file is part of VolatilityTradingSimulation.

 *  VolatilityTradingSimulation is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  VolatilityTradingSimulation is distributed in the hope that it will be useful,
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

namespace VolatilityTradingSimulation
{
    public class SimulationEngine
    {
        int length;
        double upMargin, downMargin, volatility;

        public SimulationEngine ( int _length, double _upMargin, double _downMargin, double _volatility )
        {
            length = _length;
            upMargin = _upMargin;
            downMargin = _downMargin;
            volatility = _volatility;

            GenerateData ( );
        }

        double[] data;

        private void GenerateData ( )
        {
            Random rand = new Random ( );
            data = new double[ length ];
            data[ 0 ] = 100;
            for ( int i = 1 ; i < length ; i++ )
            {
                double temp = rand.NextDouble ( );
                if ( temp > volatility )
                    data[ i ] = data[ i - 1 ] + ( ( temp - volatility ) / ( 1 - volatility ) );
                else
                    data[ i ] = data[ i - 1 ] - ( 1 - temp / volatility );
            }
        }

        public void Simulate ( out int ups, out int downs ) 
        {
            ups = 0;
            downs = 0;

            for ( int i = 0 ; i < length ; i++ )
            {
                double current = data[ i ];
                double upLevel = current * ( 1 + upMargin );
                double downlevel = current * ( 1 - downMargin );
                for ( int j = i ; j < length ; j++ )
                {
                    if ( data[ j ] >= upLevel )
                    {
                        ups++;
                        break;
                    }
                    if ( data[ j ] <= downlevel )
                    {
                        downs++;
                        break;
                    }
                }
            }
        }

    }
}
