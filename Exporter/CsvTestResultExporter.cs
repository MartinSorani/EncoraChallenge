using EncoraChallenge.Serialization;
using System.Text;

namespace EncoraChallenge.Exporter
{
    public class CsvTestResultExporter : ICsvExporter
    {
        public void Export(string filePath, TestResults testResults)
        {
            var csvContent = ConvertToCsv(testResults.Data);
            File.WriteAllText(filePath, csvContent);
        }

        private static string ConvertToCsv(List<TestCase> testCases)
        {
            var csvBuilder = new StringBuilder();
            csvBuilder.AppendLine("TestCaseName,Status,ExecutionTime,Timestamp");

            foreach (var testCase in testCases)
            {
                var line = $"\"{testCase.TestCaseName}\",\"{testCase.Status}\",{testCase.ExecutionTime},\"{testCase.Timestamp:O}\"";
                csvBuilder.AppendLine(line);
            }

            return csvBuilder.ToString();
        }
    }
}
