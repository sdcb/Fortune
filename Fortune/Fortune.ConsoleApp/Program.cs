using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fortune.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter you name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Your score is: {GetScoreByName(name)}.");
            }
        }

        private static int Clamp(int v, int min, int max)
        {
            if (v < min) return min;
            else if (v > max) return max;
            return v;
        }

        private static int GetScoreByName(string name)
        {
            int hashCode = GetHashScore(name);

            if (name.StartsWith("li"))
            {
                return Clamp(
                    Math.Abs(hashCode % 100) + 10,
                    0, 100);
            }

            int score = Math.Abs(hashCode % 100);
            return score;
        }

        private static int GetHashScore(string name)
        {
            name += "3";
            var bytesArray = Encoding.UTF8.GetBytes(name);
            using (var hash = SHA256.Create())
            {
                var theHash = hash.ComputeHash(bytesArray);

                var result = 0;
                for (var i = 0; i < theHash.Length / 4; ++i)
                {
                    var v1 = theHash[i * 4 + 0] << 0;
                    var v2 = theHash[i * 4 + 1] << 8;
                    var v3 = theHash[i * 4 + 2] << 16;
                    var v4 = theHash[i * 4 + 3] << 24;

                    result ^= v1 + v2 + v3 + v4;
                }
                return result;
            }
        }
    }
}
