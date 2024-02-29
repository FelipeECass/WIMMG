using Microsoft.AspNetCore.Identity;

namespace Parser.Utils
{
	public class FileReader(StreamReader v_streamReader)
	{
		StreamReader m_streamReader = v_streamReader;
		public string ReadLine()
		{
			string v_line = m_streamReader.ReadLine()!;
			while (v_line!.Length == 0)
			{
				v_line = m_streamReader.ReadLine()!;
			}
			return v_line;
		}
	}
}
