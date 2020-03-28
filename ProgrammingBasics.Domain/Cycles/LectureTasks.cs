using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingBasics.Domain.Cycles
{
    public class LectureTasks
    {
        public string RemoveSpaces(string text)
        {
            return text.TrimStart();
        }

        public (string fl, string sl, string tl) GetFramedText(string text)
        {
            string l = new string('-', text.Length);

            string fl = string.Format("+-{0}-+", l);
            string sl = string.Format("| {0} |", text);
            string tl = string.Format("+-{0}-+", l);

            return (fl, sl, tl);
        }

        public string[] GenerateChessBoard(int size)
        {
            var chessBoardLines = new string[size];

            for (int i = 0; i < size; i++)
            {
                var line = new char[size];
                
                for (int j = 0; j < size; j++)
                    line[j] = (i + j) % 2 == 0 ? '#' : '.';

                chessBoardLines[i] = new string(line);
            }

            return chessBoardLines;
        }
    }
}
