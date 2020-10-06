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
        public class VisialInspectionRecord
        {
            public string ngReason { get; set; }
            public string typeNgScr { get; set; }
            public DateTime ngRegistrationDate { get; set; }
            public string ngSerialNo { get; set; }
            public string viOperator { get; set; }
            public bool? oqaInspectionOk { get; set; }
            public bool? postReworkViOK { get; set; }
            public DateTime? reworkDatetime { get; set; }
            public bool? reworkOK { get; set; }
            public string ReworkOperator { get; set; }
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
        public class VisualInspectionStruct
        {
            public bool HasNgRecords { get { return InspectionRecords.Count > 0; } }
            public List<VisialInspectionRecord> InspectionRecordsOld { get; set; } = new List<VisialInspectionRecord>();
            public List<MST.MES.DrvIgn.VisualInspection.NgStructure> InspectionRecords { get; set; } = new List<MST.MES.DrvIgn.VisualInspection.NgStructure>();
            public string ngReason { get { return string.Join(", ", InspectionRecords.Select(x => x.ngReason)); } }
            public string ngTypeAndReason { get { return string.Join(", ", InspectionRecords.Select(x => $"{x.typeNgScr}-{x.ngReason}")); } }
            public string ngSerialNo { get { return InspectionRecords.First().ngSerialNo; } }
            public bool CurrentOverallState
            {
                get
                {
                    return InspectionRecords.Select(x => x.CurrentOverallState).All(x => x);
                }
            }
        }

        public static Dictionary<string, VisualInspectionStruct> GetViRecordsForPcbs(string[] pcbs)
        {
            Dictionary<string, VisualInspectionStruct> result = new Dictionary<string, VisualInspectionStruct>();
            if (!pcbs.Any()) return result;
            foreach (var pcb in pcbs)
            {
                result.Add(pcb, new VisualInspectionStruct());
            }
            string connectionString = @"Data Source=MSTMS010;Initial Catalog=MES;User Id=mes;Password=mes;";
            string query = @"SELECT * FROM MES.dbo.v_NG_IGN_DRV WHERE serial_no in (" + string.Join(",", pcbs.Select(p => $"'{p}'")) +")";
            //[Reason]
            //  ,[serial_no]
            //  ,[Rodzaj_wady]
            //  ,[Nr_zlecenia]
            //  ,[Data_rejestracji]
            //  ,[Wynik_naprawy]
            //  ,[Data_naprawy]
            //  ,[OQA_zatw]
            //  ,[Data_OQA]
            //  ,[Vi_po_naprawie_wynik]
            //  ,[Vi_po_naprawie_data]
            //  ,[Ng_Rejestr_Nazwisko]
            //  ,[Ng_Rejestracja_Imie]
            //  ,[Naprawa_Imie]
            //  ,[Naprawa_Nazwisko]
            //  ,[Kontr_Finalna_Imie]
            //  ,[Kontrola_Finalna_Nazwisko]
            
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
                            VisialInspectionRecord ngRecord = new VisialInspectionRecord();
                            ngRecord.ngReason = SqlTools.SafeGetString(rdr, "Reason");
                            ngRecord.typeNgScr = SqlTools.SafeGetString(rdr, "Rodzaj_wady");
                            ngRecord.ngRegistrationDate = SqlTools.SafeGetDateTime(rdr, "Data_rejestracji");
                            ngRecord.ngSerialNo = SqlTools.SafeGetString(rdr, "serial_no");
                            ngRecord.viOperator = SqlTools.SafeGetString(rdr, "Rejestr_imie_nazwisko");
                            ngRecord.oqaInspectionOk = SqlTools.SafeGetBoolNullableBinary(rdr, "OQA_zatw");
                            ngRecord.postReworkViOK = SqlTools.SafeGetBoolNullableBinary(rdr, "Vi_po_naprawie_wynik");
                            ngRecord.reworkDatetime = SqlTools.SafeGetDateTime(rdr, "Data_naprawy");
                            ngRecord.reworkOK = SqlTools.SafeGetBoolNullableBinary(rdr, "Wynik_naprawy");
                            ngRecord.ReworkOperator = SqlTools.SafeGetString(rdr, "Naprawa_imie_nazwisko");
                            ngRecord.postReworkViOperator = SqlTools.SafeGetString(rdr, "Vi_po_naprawie_imie_nazwisko");
                            result[ngRecord.ngSerialNo].InspectionRecords.Add(ngRecord);
                        }
                    }
                }
            }
            return result;
        }
    }
}
