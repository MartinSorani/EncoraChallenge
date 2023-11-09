using EncoraChallenge.Serialization;

namespace EncoraChallenge.Metrics
{
    public class MetricsCalculator
    {
        private readonly List<TestCase> _testCases;

        public MetricsCalculator(List<TestCase> testCases)
        {
            _testCases = testCases ?? throw new ArgumentNullException(nameof(testCases));
        }

        public int TotalTestCasesExecuted => _testCases.Count;

        public int TotalTestCasesPassed => _testCases.Count(tc => tc.Status.Equals("Pass", StringComparison.OrdinalIgnoreCase));

        public int TotalTestCasesFailed => _testCases.Count(tc => tc.Status.Equals("Fail", StringComparison.OrdinalIgnoreCase));

        public double AverageExecutionTime => _testCases.Average(tc => tc.ExecutionTime);

        public int MinimumExecutionTime => _testCases.Min(tc => tc.ExecutionTime);

        public int MaximumExecutionTime => _testCases.Max(tc => tc.ExecutionTime);

        public void DisplayMetrics()
        {
            Console.WriteLine("Metrics:");
            Console.WriteLine($"Total number of test cases executed: {TotalTestCasesExecuted}");
            Console.WriteLine($"Number of test cases passed: {TotalTestCasesPassed}");
            Console.WriteLine($"Number of test cases failed: {TotalTestCasesFailed}");
            Console.WriteLine($"Average execution time for all test cases: {AverageExecutionTime:F2} ms");
            Console.WriteLine($"Minimum execution time among all test cases: {MinimumExecutionTime} ms");
            Console.WriteLine($"Maximum execution time among all test cases: {MaximumExecutionTime} ms");
        }
    }
}
