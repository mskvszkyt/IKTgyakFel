using System.IO;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F1(string[] nums)
            {
                if (nums.Length % 2 != 0 && nums.Length != 0)
                {
                    int kozepsoI = nums.Length / 2;
                    int kozepso = Convert.ToInt32(nums[kozepsoI]);
                    int hatvany = Convert.ToInt32(nums[kozepsoI + 1]) < Convert.ToInt32(nums[kozepsoI - 1]) ?
                            Convert.ToInt32(nums[kozepsoI - 1]) / Convert.ToInt32(nums[kozepsoI + 1]) :
                            Convert.ToInt32(nums[kozepsoI + 1]) / Convert.ToInt32(nums[kozepsoI - 1]);
                    return Math.Pow(kozepso, hatvany);
                }
                else
                {
                    Console.WriteLine("nem megfelelő argumentum szám");
                    return -1;
                }
            }

            void F2()
            {
                List<string> szavak = File.ReadAllLines("szavak.txt").ToList();
                char[] maganhangzok = ['A', 'E', 'I', 'O', 'U'];
                Console.WriteLine($"több mint 4 magánhangzós: {szavak.Count(x => x.Count(y => maganhangzok.Contains(y)) > 4)}");
                Console.WriteLine($"legnagyobb szotagszam: {szavak.Max(x => x.Count(y => maganhangzok.Contains(y)))}");
            }

            void F3()
            {
                int[,] matrix = new int[6, 6];
                Random rand = new();
                for (int i = 0; i < 6; i++)
                {
                    for (int v = 0; v < 6; v++)
                    {
                        matrix[i, v] = rand.Next(55, 156);
                        if (v == 5)
                        {
                            Console.WriteLine(matrix[i, v]);
                        }
                        else
                        {
                            Console.Write(matrix[i, v] + "\t");
                        }
                    }
                }
                Console.WriteLine($"szélsó elemek átlaga: {new List<int> { matrix[0,0], matrix[0,5], matrix[5,0], matrix[5,5] }.Average()}");
            }

            Console.WriteLine(F1(args));

            F2();

            F3();
        }
    }
}
