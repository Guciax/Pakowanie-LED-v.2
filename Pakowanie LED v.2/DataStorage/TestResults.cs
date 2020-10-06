using MST.MES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakowanie_LED_v._2.DataStorage
{
    public class TestResults
    {
        public class TestResultStruct
        {
            public string SerialNo { get; set; }
            public string FuncTestResultString { get; set; }
            public bool? FuncTestOK{
                get{

                    if (FuncTestResultString == null) return null;
                    return FuncTestResultString == "Passed";
                }
            }
            private string _HiPotTestResultString;
            public string HiPotTestResultString
            {
                get
                {
                    if (!HiPotTestRequired) return "Passed";
                    return _HiPotTestResultString;
                }
                set
                {
                    _HiPotTestResultString = value;
                }
            }
            public bool? HiPotTestOK
            {
                get
                {
                    if (!HiPotTestRequired)
                    {
                        return true;
                    }
                    if (HiPotTestResultString == null) return null;
                    return HiPotTestResultString == "Passed";
                }
            }
            public bool HiPotTestRequired { get; set; } = true;
            public DateTime? FuncTestTime { get; set; }
            public DateTime? HiPotTestTime { get; set; }
            public DateTime? OverallTestTime { get
                {
                    if (!FuncTestTime.HasValue || !HiPotTestTime.HasValue) return null;
                    return (new DateTime[] { FuncTestTime.Value, HiPotTestTime.Value }).Min();
                } }
            public bool TestResultOK
            {
                get
                {
                    if(FuncTestOK.HasValue & HiPotTestOK.HasValue)
                    {
                        return FuncTestOK.Value & HiPotTestOK.Value;
                    }
                    return false;
                }
            }
        }
        public static Dictionary<string, TestResultStruct> GetTestRecordsForPcbs(string[] serialsList)
        {
            if (!serialsList.Any()) return new Dictionary<string, TestResultStruct>();
            //Dictionary<int, string> testerIdToName = TesterIdToName();
            Dictionary<string, TestResultStruct> result = new Dictionary<string, TestResultStruct>();
            foreach (var pcb in serialsList)
            {
                result.Add(pcb, new TestResultStruct());
            }
            string connectionString = @"Data Source=MSTMS010;Initial Catalog=MES;User Id=mes;Password=mes;";
            string querry = $@"WITH ranked_messages AS (
                                    SELECT m.*, ROW_NUMBER() OVER (PARTITION BY TEST_TYPE ORDER BY START_DATE_TIME DESC) AS rn
                                    FROM tb_elektronika_tester_pomiary AS m  where UUT_SERIAL_NUMBER = @serial )
                                    SELECT UUT_SERIAL_NUMBER,TEST_TYPE, UUT_STATUS, START_DATE_TIME FROM ranked_messages WHERE rn = 1;";

            using (SqlConnection conn = new SqlConnection(@"Data Source=MSTMS010;Initial Catalog=MES;User Id=mes;Password=mes;")) 
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Connection.ConnectionString = connectionString;
                    cmd.CommandText = querry;
                    SqlParameter pSerial = new SqlParameter() { ParameterName = "@serial" };
                    cmd.Parameters.Add(pSerial);
                    conn.Open();
                    foreach (var serial in serialsList)
                    {
                        pSerial.Value = serial;
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                string serialNo = SqlTools.SafeGetString(rdr, "UUT_SERIAL_NUMBER").Trim();
                                string testResult = SqlTools.SafeGetString(rdr, "UUT_STATUS").Trim();
                                string testType = SqlTools.SafeGetString(rdr, "TEST_TYPE").Trim();
                                DateTime testTime = SqlTools.SafeGetDateTime(rdr, "START_DATE_TIME");

                                result[serialNo].SerialNo = serialNo;
                                
                                if (testType == "Func")
                                {
                                    result[serialNo].FuncTestResultString = testResult;
                                    result[serialNo].FuncTestTime = testTime;
                                }
                                else
                                {
                                    result[serialNo].HiPotTestResultString = testResult;
                                    result[serialNo].HiPotTestTime = testTime;
                                }
                            }
                        }
                    }
                    
                }
            }
            return result;
        }
    }
}
