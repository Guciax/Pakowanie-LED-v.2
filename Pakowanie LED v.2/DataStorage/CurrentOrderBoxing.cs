using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakowanie_LED_v._2.DataStorage
{
    class CurrentOrderBoxing
    {
        public static List<MST.MES.OrderStructureByOrderNo.BoxingInfo> AllBoxesForOrder { get; set; } = new List<MST.MES.OrderStructureByOrderNo.BoxingInfo>();
        public static Label lOtherBoxesInfo;
        public static DataGridView dgvBoxesList;

        public static void ReloadBoxes()
        {
            
            AllBoxesForOrder = new List<MST.MES.OrderStructureByOrderNo.BoxingInfo>();
            if (CurrentBoxData.CurrentBoxId == null) return;

            var splittedBox = CurrentBoxData.CurrentBoxId.Split('_');
            if (splittedBox.Length != 3) return;

            var orderNo = splittedBox[1];
            var boxingData = MST.MES.SqlDataReaderMethods.Boxing.GetBoxingForBoxOrder(orderNo);
            var boxesId = boxingData.Select(b => b.boxId).Distinct().ToArray();
            var completeBoxingData = MST.MES.SqlDataReaderMethods.Boxing.GetBoxingForBoxIds(boxesId);
            AllBoxesForOrder = completeBoxingData.Where(b => b.boxId != CurrentBoxData.CurrentBoxId).ToList();
            DisplayOtherBoxesInfo();
        }

        public static void DisplayOtherBoxesInfo()
        {
            var currentBoxList = CurrentBoxData.CurrentBoxingList.Select(x => new MST.MES.OrderStructureByOrderNo.BoxingInfo
            {
                boxId = CurrentBoxData.CurrentBoxId,
                orderNoPcb = x.BoxingData.orderNoPcb,
                orderNoBox = x.BoxingData.orderNoBox
            });
            var allBoxes = currentBoxList.Concat(AllBoxesForOrder).ToList();
            lOtherBoxesInfo.Text = "";
            dgvBoxesList.Rows.Clear();
            var grouppedByBoxId = allBoxes.GroupBy(b => b.boxId).OrderBy(b=>b.Key);
            int i = 1;
            foreach (var boxIdGr in grouppedByBoxId)
            {
                dgvBoxesList.Rows.Add(i, boxIdGr.Key, $"{boxIdGr.Count()}szt.");
                //lOtherBoxesInfo.Text += $"{i}. {boxIdGr.Key} - {boxIdGr.Count()}szt." + Environment.NewLine;
                i++;
            }

            lOtherBoxesInfo.Text += $"Łącznie - {allBoxes.Count()}szt." + Environment.NewLine + Environment.NewLine;
            lOtherBoxesInfo.Text += $"Ilości po zleceniach:" + Environment.NewLine;
            var otherOrders = allBoxes.GroupBy(b => b.orderNoPcb).OrderByDescending(o=>o.Count());
            foreach (var orderEntry in otherOrders)
            {
                lOtherBoxesInfo.Text += $"{orderEntry.Key} - {orderEntry.Count()}szt." + Environment.NewLine;
            }
        }

    }
}
