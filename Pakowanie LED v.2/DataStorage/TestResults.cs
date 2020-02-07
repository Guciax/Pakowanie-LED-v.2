using MST.MES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakowanie_LED_v._2.DataStorage
{
    class TestResults
    {

        public static Dictionary<string, OrderStructureByOrderNo.TestRecord> GetTestRecordsForPcbs(string[] pcbs)
        {
            if (!pcbs.Any()) return new Dictionary<string, OrderStructureByOrderNo.TestRecord>();
            //Dictionary<int, string> testerIdToName = TesterIdToName();
            Dictionary<string, OrderStructureByOrderNo.TestRecord> result = new Dictionary<string, OrderStructureByOrderNo.TestRecord>();
            foreach (var pcb in pcbs)
            {
                result.Add(pcb, new OrderStructureByOrderNo.TestRecord());
            }
            string connectionString = @"Data Source=MSTMS010;Initial Catalog=MES;User Id=mes;Password=mes;";
            string query = $@"  Select * FROM (SELECT serial_no, result, DataCzas,ng_type,
                               ROW_NUMBER() OVER (PARTITION BY serial_no ORDER BY DataCzas desc) AS RowNumber
                               FROM [MES].[dbo].[tb_tester_measurements]
                               where serial_no in ({string.Join(",", pcbs.Select(p => $"'{p}'"))})) AS a
                               WHERE   a.RowNumber = 1";

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
                            string serialNo = SqlTools.SafeGetString(rdr, "serial_no");

                            OrderStructureByOrderNo.TestRecord testRecord = new OrderStructureByOrderNo.TestRecord();
                            testRecord.serialNo = serialNo;
                            testRecord.testResultOk = SqlTools.SafeGetString(rdr, "result") == "OK";
                            testRecord.ngTyppe = SqlTools.SafeGetString(rdr, "ng_type");
                            testRecord.testTime = SqlTools.SafeGetDateTime(rdr, "DataCzas");

                            result[serialNo] = testRecord;
                        }
                    }
                }
            }
            return result;
        }
    }
}
