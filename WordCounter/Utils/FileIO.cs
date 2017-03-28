namespace WordCounter
{
    public class FileIO
    {
        public static string[] ReadLines(string fileName)
        {
            return System.IO.File.ReadAllLines(fileName);
        }

        public static string ReadAll(string fileName)
        {
            return System.IO.File.ReadAllText(fileName);
        }

        public static void WriteToFile(string fileName, string text)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
            file.WriteLine(text);
            file.Close();
        }
    }
}
