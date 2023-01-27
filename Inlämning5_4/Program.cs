using System;

namespace Inlämning5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Eric", "Timothy", "Kingen", "Gud", "Astaghfrihullah" };
            Array.Sort(namn);
            for(int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }

        }
    }
}
