namespace EncoraChallenge.Utils
{
    public static class Helper
    {
        public static string GetValidFilePath(string fileType)
        {
            const int maxAttempts = 3;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.WriteLine($"Please enter the full path for the {fileType} file (type 'exit' to quit):");
                string filePath = Console.ReadLine();

                if (string.Equals(filePath, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting the application.");
                    Environment.Exit(0);
                }

                if (string.IsNullOrEmpty(filePath))
                {
                    Console.WriteLine("No path was entered. Please try again.");
                    attempts++;
                    continue; // Prompt the user again until we reach max attampts
                }

                string requiredExtension = fileType == "input" ? ".json" : ".csv";
                string extension = Path.GetExtension(filePath);
                if (extension.Equals(requiredExtension, StringComparison.OrdinalIgnoreCase))
                {
                    return filePath; // valid file path
                }
                else
                {
                    Console.WriteLine($"The file path must end with a {requiredExtension} extension. Please try again.");
                    attempts++;
                }
            }

            Console.WriteLine("Maximum attempts reached. Exiting the application.");
            Environment.Exit(1);
            return null;
        }
    }

}
