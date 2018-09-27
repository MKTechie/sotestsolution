using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SO_TEST_1_2
{
    public class Game
    {
        public string MacroPolo(int range)
        {
            if (range > 0)
            {
                StringBuilder resultGame = new StringBuilder();
                for (int i = 1; i <= range; i++)
                {
                    if(i != 1 ) resultGame.Append(",");
                    resultGame.Append(
                        (i % 28 == 0) ? "macropolo"
                        : (i % 4 == 0) ? "macro"
                        : (i % 7 == 0) ? "polo"
                        : i.ToString()
                        );
                }
                return resultGame.ToString();
            }
            else
            {
                return "Invalid range";
            }
            
        }
    }
}
