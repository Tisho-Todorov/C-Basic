using System;
class PrintADeckOf52Cards
{
    static void Main()
    {
        char blackClub = '\u2663';
        char redDiamond = '\u2666';
        char redHeart = '\u2665';
        char blackSpade = '\u2660';

        for (int i = 0; i < 1; i++)
        {
            for (int row = 2; row <= 13; row++)
            {
                if (row <= 10)
                {
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", row, blackClub, redDiamond, redHeart, blackSpade);
                }
                switch (row)
                {
                    case 10: Console.WriteLine("J{0} J{1} J{2} J{3}", blackClub, redDiamond, redHeart, blackSpade);
                        break;
                    case 11: Console.WriteLine("Q{0} Q{1} Q{2} Q{3}", blackClub, redDiamond, redHeart, blackSpade);
                        break;
                    case 12: Console.WriteLine("K{0} K{1} K{2} K{3}", blackClub, redDiamond, redHeart, blackSpade);
                        break;
                    case 13: Console.WriteLine("A{0} A{1} A{2} A{3}", blackClub, redDiamond, redHeart, blackSpade);
                        break;
                }
            }
        }
        Console.WriteLine("bye, bye!");
        Console.Title = "Created by T.Todorov";
    }
}