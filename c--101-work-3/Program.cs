using System; 
using System.Collections;

namespace Work1{
    internal class Program{
        public static void Main(string[] args){
            char[] vowelsPath = {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            List<char> vowelsInText = new List<char>();
            string inp = Console.ReadLine();

            foreach(char c in inp){
                if(vowelsPath.Contains(c)){
                    vowelsInText.Add(c);
                }
            }
            vowelsInText.Sort();
            printElementsInArray<char>(vowelsInText);
        }
        public static void printElementsInArray<T>(List<T> arr){
            foreach(var value in arr){
                Console.Write($"{value} ");
            }
        }
    }
}