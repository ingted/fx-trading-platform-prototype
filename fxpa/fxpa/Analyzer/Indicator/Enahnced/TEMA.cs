// -----
// GNU General Public License
// The Forex Professional Analyzer is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version. 
// The Forex Professional Analyzer is distributed in the hope that it will be useful, but without any warranty; without even the implied warranty of merchantability or fitness for a particular purpose.  
// See the GNU Lesser General Public License for more details.
// -----

//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace fxpa
//{
//    /// <summary>
//    /// INTERPETATION : 
//    /// The most popular method of interpreting a moving average is to compare the relationship between a 
//    /// moving average of the security's closing price and the security's closing price itself. A sell signal 
//    /// is generated when the security's price falls below its moving average and a buy signal is generated 
//    /// when the security's price rises above its moving average.
//    /// </summary>
//    public class TEMA : Indicator
//    {
//        const int TimePeriod = 20;

//        /// <summary>
//        /// 
//        /// </summary>
//        public TEMA(DataProvider dataProvider)
//            : base(dataProvider)
//        {
//        }

//        public enum EMAStates
//        {
//            UpDownCross = -1,
//            Default = 0,
//            DownUpCross = 1
//        }

//        public string FullName
//        {
//            get { return "Triple Exponential Moving Average"; }
//        }

//        public Type StateEnumType
//        {
//            get { return typeof(EMAStates); }
//        }

//        protected override void Calculate(int startingIndex, int indecesCount)
//        {
//            base.Clear();

//            double[] closeValues = _dataProvider.GetDataValues(startingIndex, indecesCount, DataProvider.DataValueSourceEnum.Close);

//            double[] temaResult = new double[indecesCount];
//            int beginIndex = 0;
//            int numberElements = 0;
//            TicTacTec.TA.Library.Core.Tema(/*startingIndex*/ 0, /*startingIndex +*/ indecesCount - 1, closeValues, TimePeriod,
//                out beginIndex, out numberElements, temaResult);

//            AddResultSet(beginIndex, numberElements, temaResult);

//            // Calculate states - WE NEED TO USE THE RESULT SET HERE, as it is different to the temaResult!!
//            float[] resultSignals = CalculateDefaultCrossingSignal(beginIndex, ResultSets[0], closeValues);
//            SetResultSignals(resultSignals);
//        }

//    }
//}
