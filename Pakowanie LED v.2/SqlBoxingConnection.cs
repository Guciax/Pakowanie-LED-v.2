using MST.MES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakowanie_LED_v._2
{
    public class SqlBoxingConnection
    {
        private static SqlConnection conn = null;

        private static void CheckIfConnOpen()
        {
            if(conn == null)
            {
                conn = new SqlConnection
                {
                    ConnectionString = @"Data Source=MSTMS010;Initial Catalog=MES;User Id=mes;Password=mes;"
                };
            }
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public static void CloseConnection()
        {
            if(conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public static int HowManyModulesMovedAsLp100(string movedAsLp100)
        {
            CheckIfConnOpen();
            string query = @"SELECT Count(*) FROM MES.dbo.tb_wyrobMST_opakowanie WHERE lp100_przesuniecia=@lp100";

            using (var cmd = conn.CreateCommand())
            {
                var parameter = cmd.CreateParameter();
                parameter.ParameterName = "@lp100";
                parameter.Value = movedAsLp100;
                cmd.Parameters.Add(parameter);

                cmd.Connection = conn;
                cmd.CommandText = query;
                var r = cmd.ExecuteScalar();
                return Convert.ToInt32(r);
            }
        }
        public static MST.MES.OrderStructureByOrderNo.BoxingInfo GetBoxingForPcb(string pcbSerialNo)
        {
            CheckIfConnOpen();
            string query = @"SELECT lp100_przesuniecia,Data_przesuniecia,serial_no,order_no,Box_LOT_NO,Boxing_Date,orderNo_box,orderNo_pcb FROM MES.dbo.tb_wyrobMST_opakowanie WHERE serial_no=@serial";

            using (var cmd = conn.CreateCommand())
            {
                var parameter = cmd.CreateParameter();
                parameter.ParameterName = "@serial";
                parameter.Value = pcbSerialNo;
                cmd.Parameters.Add(parameter);
                
                cmd.Connection = conn;
                cmd.CommandText = query;

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        MST.MES.OrderStructureByOrderNo.BoxingInfo boxEntry = new MST.MES.OrderStructureByOrderNo.BoxingInfo();
                        boxEntry.boxId = SqlTools.SafeGetString(rdr, "Box_LOT_NO");
                        boxEntry.serialNo = SqlTools.SafeGetString(rdr, "serial_no");
                        boxEntry.boxingDate = SqlTools.SafeGetDateTime(rdr, "Boxing_Date");
                        boxEntry.orderNo = SqlTools.SafeGetString(rdr, "orderNo_box");
                        boxEntry.orderNoPcb = SqlTools.SafeGetString(rdr, "orderNo_pcb");
                        boxEntry.moveToWarehouseDate = SqlTools.SafeGetDateTimeNullable(rdr, "Data_przesuniecia");
                        boxEntry.movedByLp100 = SqlTools.SafeGetString(rdr, "lp100_przesuniecia");
                        return boxEntry;
                    }
                }
            }
            
            return null;
        }
        public static void InsertNewPcb(string pcbSerialNo, string boxSerial, string userName)
        {
            CheckIfConnOpen();
            string orderBox = boxSerial.Split('_')[1];
            string orderPcb = pcbSerialNo.Split('_')[1];
            string save = "INSERT into tb_wyrobMST_opakowanie (serial_no, Box_LOT_NO, Boxing_Date,order_no, orderNo_box, orderNo_pcb,operator_pakowania) VALUES (@serial_no, @Box_LOT_NO, @Boxing_Date,@order_no, @orderNo_box, @orderNo_pcb,@operator_pakowania)";
            using (SqlCommand querySave = new SqlCommand(save))
            {
                querySave.Connection = conn;

                querySave.Parameters.Add("@serial_no", SqlDbType.NVarChar).Value = pcbSerialNo;
                querySave.Parameters.Add("@Box_LOT_NO", SqlDbType.NVarChar).Value = boxSerial;
                querySave.Parameters.Add("@order_no", SqlDbType.NVarChar).Value = orderBox;
                querySave.Parameters.Add("@orderNo_box", SqlDbType.NVarChar).Value = orderBox;
                querySave.Parameters.Add("@orderNo_pcb", SqlDbType.NVarChar).Value = orderPcb;
                querySave.Parameters.Add("@Boxing_Date", SqlDbType.SmallDateTime).Value = DateTime.Now;
                querySave.Parameters.Add("@operator_pakowania", SqlDbType.NVarChar).Value = userName;

                querySave.ExecuteNonQuery();
            }
        }

        public static void UpdateBoxIdForMovedByLp100(string movedByLp100, string newBoxId)
        {
            using (SqlConnection openCon = new SqlConnection(@"Data Source=MSTMS010;Initial Catalog=MES;User Id=mes;Password=mes;"))
            {
                openCon.Open();
                string updString = "UPDATE tb_wyrobMST_opakowanie SET Box_LOT_NO=@newBox  WHERE lp100_przesuniecia = @lp100_przesuniecia";
                using (SqlCommand querySave = new SqlCommand(updString))
                {
                    querySave.Connection = openCon;
                    querySave.Parameters.AddWithValue("@newBox", newBoxId);
                    querySave.Parameters.AddWithValue("@lp100_przesuniecia", movedByLp100);
                    querySave.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateBoxIdForSerial(string serialNo, string newBoxId)
        {
            CheckIfConnOpen();
            string updString = "UPDATE tb_wyrobMST_opakowanie SET Box_LOT_NO=@newBox  WHERE serial_no = @serial";
            using (SqlCommand querySave = new SqlCommand(updString))
            {
                querySave.Connection = conn;
                querySave.Parameters.AddWithValue("@newBox", newBoxId);
                querySave.Parameters.AddWithValue("@serial", serialNo);
                querySave.ExecuteNonQuery();
            }
        }
    }
}
