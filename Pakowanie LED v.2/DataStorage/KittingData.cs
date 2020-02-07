using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakowanie_LED_v._2.DataStorage
{
    public class KittingData
    {
        public static MST.MES.OrderStructureByOrderNo.Kitting CurrentOrder { get; set; }
        public static void ReloadOrder(string orderNo)
        {
            CurrentOrder = MST.MES.SqlDataReaderMethods.Kitting.GetOneOrderByDataReader(orderNo);
        }
    }
}
