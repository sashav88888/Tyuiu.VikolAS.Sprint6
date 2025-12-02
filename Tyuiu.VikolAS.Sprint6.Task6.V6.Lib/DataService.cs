using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VikolAS.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            string text = File.ReadAllText(path);

            string[] words = text.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();

            foreach (string w in words)
            {
                // Берём слово, если в нём есть маленькая буква 'b'
                if (w.Contains('b'))
                {
                    result.Add(w);
                }
            }

            return string.Join(" ", result);
        }
    }
}
