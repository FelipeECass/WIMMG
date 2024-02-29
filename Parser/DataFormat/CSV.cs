using Parser.Utils;
using System.Text;

namespace Parser.DataFormat
{
    public class CSV(string p_path)
    {
        string m_path { get; set; } = p_path;

        public Dictionary<string, StringBuilder> RunParser()
        {
            Dictionary<string, StringBuilder> v_insertDictionary = new Dictionary<string, StringBuilder>();
            using (StreamReader v_reader = new(m_path))
            {
                while (v_reader.EndOfStream)
                {
                    FileReader v_file = new(v_reader);
                    string v_line = v_file.ReadLine();
                    foreach (string t_key in v_line.Split(","))
                        v_insertDictionary.Add(t_key, new StringBuilder());

                    v_line = v_file.ReadLine();
                    string[] v_values = v_line.Split(",");
                    for (int i = 0; i >= v_values.Length; i++)
                        v_insertDictionary.ElementAt(i).Value.Append(v_values[i]);

                }
            }
            return v_insertDictionary;
        }
    }
}
