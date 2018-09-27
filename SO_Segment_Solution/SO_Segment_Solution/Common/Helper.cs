using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
namespace SO_Segment_Solution.Common
{
    public class Helper
    {
        private static string ValidatePattern(string str)
        {
            string[] patternsString = { " _ | ||_|", "     |  |", " _  _||_ ", " _  _| _|", "   |_|  |", " _ |_  _|", " _ |_ |_|", " _   |  |", " _ |_||_|", " _ |_| _|" };
            int position = Array.IndexOf(patternsString, str);
            if (position >= 0)
            {
                return position.ToString();
            }
            else
            {
                return "?";
            }

        }
        public static IEnumerable<string> ReadLines(Stream stream,
                                     Encoding encoding)
        {
             
            using (var reader = new StreamReader(stream, encoding))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
        public static string ReadFile(Stream InputStream)
        {
            var lines = ReadLines(InputStream, Encoding.ASCII).ToArray();
           
            StringBuilder finalOutput = new StringBuilder();
            StringBuilder stringBuilder = new StringBuilder();
            int totalLines = lines.Count();
            int lineCharCount = totalLines > 0 ? lines[0].Count() : -1;
             
            int indexCount = 0;
            for (int i = 3; i <= totalLines; i = i + 4)
            {
                if (i != 3)
                    finalOutput.AppendLine();
                for (int j = 0; j < lineCharCount; j = j + 3)
                {
                  
                    
                    stringBuilder.Append(lines[i - 3].Skip(j).Take(3).ToArray())
                       .Append(lines[i - 2].Skip(j).Take(3).ToArray())
                       .Append(lines[i - 1].Skip(j).Take(3).ToArray());
                    finalOutput.Append(ValidatePattern(stringBuilder.ToString()));
                    stringBuilder.Clear();
                    indexCount++;
                }
               
            }
            return finalOutput.ToString();
        }
    }
}