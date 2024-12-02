
using System.Collections.Generic;

public class LabResult
{
    public string PatientId { get; set; }
    public string TestName { get; set; }
    public string Result { get; set; }

    public LabResult(string patientId, string testName, string result) {
        PatientId = patientId;
        TestName = testName;
        Result = result;
    }

    public override string ToString() {
        return $"{TestName}: {Result} Rapor ID: {PatientId}";
    }
}


public class LabResultsTable
{
    private Dictionary<string, List<LabResult>> resultsTable;

    public LabResultsTable() {
        resultsTable = new Dictionary<string, List<LabResult>>();
    }

    public void AddResult(LabResult result) {
        if (!resultsTable.ContainsKey(result.PatientId)) {
            resultsTable[result.PatientId] = new List<LabResult>();
        }
        resultsTable[result.PatientId].Add(result);
    }

    public List<LabResult> GetResults(string patientId) {
        resultsTable.TryGetValue(patientId, out List<LabResult> resultList);
        return resultList;
    }
}
