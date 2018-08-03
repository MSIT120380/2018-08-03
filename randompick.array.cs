using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Random k = new Random();
        double DD;
        DD = k.NextDouble();// >= 0 && < 1 的 double
        Console.WriteLine("DD == " + DD);
        ArrayList P = null;

        ArrayList originalArr = new ArrayList(new string[] { "黃建安", "科雅恆", "陳美安", "張家豪" });

        P = new ArrayList(  new string[] { "黃建安", "科雅恆", "陳美安", "張家豪" } );

        Console.WriteLine("??????????????????????????");
        for (int i = 0; i < P.Count; i++)
        {
            Console.Write(" " + P[i]);
        }
        Console.WriteLine();
        Console.WriteLine("##########################");
        // fix #1 隨機抽出每一個
        int Left ;
        int howMany = P.Count;
        {
           
            for (int i = 0; i < howMany; i++)
            {
                Left = P.Count;

                DD = k.NextDouble();
                int index = (int)(Left * DD);
                Console.WriteLine(index);
                Console.Write(" " + P[index]);
                // 移除
                {
                    P.RemoveAt( index );
                   
                }
            }
        }
        Console.WriteLine();
        for (int i = 0; i < originalArr.Count; i++)
        {
            P.Add(originalArr[i]);
        }
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$");
        
        Console.WriteLine();
        Console.WriteLine();
    }

}
