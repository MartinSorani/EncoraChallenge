using EncoraChallenge.Serialization;

namespace EncoraChallenge.Exporter
{
    public interface ICsvExporter
    {
        void Export(string filePath, TestResults testResults);
    }
}
