using System.Text.Json;

namespace EncoraChallenge.Serialization
{
    public class JsonTestResultParser : ITestResultParser
    {
        public TestResults Parse(string content)
        {
            return JsonSerializer.Deserialize<TestResults>(content);
        }
    }
}
