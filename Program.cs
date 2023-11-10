using EncoraChallenge.Exporter;
using EncoraChallenge.Metrics;
using EncoraChallenge.Serialization;
using EncoraChallenge.Utils;
using System.Text.Json;

namespace EncoraChallenge
{
    public class Program
    {
        public static void Main()
        {
            string jsonFilePath = Helper.GetValidFilePath("input");
            string csvFilePath = Helper.GetValidFilePath("output");

            try
            {
                string jsonString = File.ReadAllText(jsonFilePath);

                ITestResultParser parser = new JsonTestResultParser();
                TestResults testResults = parser.Parse(jsonString);

                if (testResults != null)
                {
                    ICsvExporter exporter = new CsvTestResultExporter();
                    exporter.Export(csvFilePath, testResults);

                    var metricsCalculator = new MetricsCalculator(testResults.Data);
                    metricsCalculator.DisplayMetrics();

                    Console.WriteLine("CSV report file exported successfully.");
                }
                else
                {
                    Console.WriteLine("No data available to process.");
                }
            }
            // catch all possible exceptions
            catch (FileNotFoundException)
            {
                Console.WriteLine("The JSON report file was not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have permission to access one of the specified files.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An I/O error occurred: {e.Message}");
            }
            catch (JsonException e)
            {
                Console.WriteLine($"Invalid JSON format: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An unexpected error occurred: {e.Message}");
            }
        }
    }
}
