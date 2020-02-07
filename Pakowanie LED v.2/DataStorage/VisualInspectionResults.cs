using MST.MES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakowanie_LED_v._2.DataStorage
{
    public class VisualInspectionResults
    {
        public class VisualInspectionStruct
        {
            public string ngReason { get; set; }
            public string viInspectionResult { get; set; } 
            public DateTime ngRegistrationDate { get; set; }
            public string ngSerialNo { get; set; }
            public string viOperator { get; set; }
            public bool? oqaInspectionOk { get; set; }
            public bool? postReworkViOK { get; set; }
            public DateTime? reworkDatetime { get; set; }
            public bool? reworkOK { get; set; }
            public string postReworkViOperator { get; set; }
            public bool CurrentOverallState
            {
                get
                {
                    if (ngReason == null) return true;
                    if (!oqaInspectionOk.HasValue) return false;
                    if (!postReworkViOK.HasValue) return false;
                    if (!oqaInspectionOk.HasValue) return false;
                    if (!oqaInspectionOk.Value) return false;
                    if (!postReworkViOK.Value) return false;
                    if (!oqaInspectionOk.Value) return false;
                    return true;
                }
            }
        }

        public static Dictionary<string, VisualInspectionStruct> GetViRecordsForPcbs(string[] pcbs)
        {
            Dictionary<string, VisualInspectionStruct> result = new Dictionary<string, VisualInspectionStruct>();
            foreach (var pcb in pcbs)
            {
                result.Add(pcb, new VisualInspectionStruct());
            }
            string connectionString = @"Data Source=MSTMS010;Initial Catalog=MES;User Id=mes;Password=mes;";
            string query = @"SELECT order_no,serial_no,result,ng_type,datetime,rework_result,rework_datetime,post_rework_vi_result,vi_Operator,post_rework_OQA_result,First_vi_operator FROM MES.dbo.tb_NG_tracking WHERE serial_no in (" + string.Join(",", pcbs.Select(p => $"'{p}'")) +")";
            // All columns
            //order_no nvarchar(50)
            //First_vi_operator
            //serial_no nvarchar(50)
            //result nvarchar(5)
            //ng_type nvarchar(50)
            //datetime smalldatetime
            //rework_result nvarchar(5)
            //rework_datetime smalldatetime
            //post_rework_vi_result nvarchar(5)
            //vi_Operator nvarchar(50)
            //post_rework_OQA_result nvarchar(5)

            using (SqlConnection conn = new SqlConnection(@"Data Source=MSTMS010;Initial Catalog=MES;User Id=mes;Password=mes;"))
            {
                using (var cmd = conn.CreateCommand())
                {
                    

                    cmd.Connection.ConnectionString = connectionString;
                    cmd.CommandText = query;
                    conn.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            VisualInspectionStruct ngEntry = new VisualInspectionStruct();
                            ngEntry.ngReason = SqlTools.SafeGetString(rdr, "ng_type");
                            ngEntry.ngRegistrationDate = SqlTools.SafeGetDateTime(rdr, "datetime");
                            ngEntry.ngSerialNo = SqlTools.SafeGetString(rdr, "serial_no");
                            ngEntry.viOperator = SqlTools.SafeGetString(rdr, "First_vi_operator");
                            ngEntry.oqaInspectionOk = SqlTools.SafeGetOkNgBoolNullable(rdr, "post_rework_OQA_result");
                            ngEntry.postReworkViOK = SqlTools.SafeGetOkNgBoolNullable(rdr, "post_rework_vi_result");
                            ngEntry.reworkDatetime = SqlTools.SafeGetDateTime(rdr, "rework_datetime");
                            ngEntry.reworkOK = SqlTools.SafeGetOkNgBoolNullable(rdr, "rework_result");
                            ngEntry.viInspectionResult = SqlTools.SafeGetString(rdr, "result"); //NG, SCRAP??
                            ngEntry.postReworkViOperator = SqlTools.SafeGetString(rdr, "vi_Operator");
                            
                            result[ngEntry.ngSerialNo] = ngEntry;
                        }
                    }
                }
            }
            return result;
        }
    }
}
