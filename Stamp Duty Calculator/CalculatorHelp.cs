using System;
using System.Collections.Generic;
using System.Text;

namespace StampDutyCalculator
{
    class CalculatorHelp
    {

        public static double Calculator(double purchasePrice) {

            double price = purchasePrice;
            double stampDuty = 0;
            if (purchasePrice <= 125000) {

                return 0;
            }

            else if (purchasePrice > 125000 && purchasePrice <= 250000)
            {
                stampDuty = ((purchasePrice - 125000) * 0.02);
            }

            else if (purchasePrice > 250000 && purchasePrice <= 925000) {
                stampDuty = (((purchasePrice - 250000) * 0.05) + ((250000 - 125000) * 0.02));
            }

            else if (purchasePrice > 925000 && purchasePrice <= 1500000) {
                stampDuty = (((purchasePrice - 925000) * 0.1) + ((925000 - 250000) * 0.05) + ((250000 - 125000) * 0.02));
            }

            else if(purchasePrice > 1500000) {
                stampDuty = (((purchasePrice - 1500000) * 0.12) + ((1500000 - 925000) * 0.1) + ((925000 - 250000) * 0.05) + ((250000 - 125000) * 0.02));
            }

            return stampDuty;
        }

    }
}
