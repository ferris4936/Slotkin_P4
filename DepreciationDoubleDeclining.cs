using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotkin_P4
{
    public class DepreciationDoubleDeclining : DepreciationStraightLine
    {
        public DepreciationDoubleDeclining() : base()
        { 
        }
        public override void Calc()
        {
            decimal depreciableAsset = StartOfLifeValue - SalvageValue;
            decimal annualDepreciation = (2 * DepreciationStraightLineMethod()) * (depreciableAsset);  
        } 

        new public string ToString()  
        {
            return base.ToString() + " using the Double Declining Depreciation method.";
        }
    }
}
