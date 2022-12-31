using System;
using System.Collections;

namespace Work1{
    internal class Program{
        static void Main (string[] args){
            ArrayList prime = new ArrayList();
            ArrayList notPrime = new ArrayList();
            int count = 20 , inp = 0 , primeTotal  = 0, notPrimeTotal = 0;

            do{
                if(int.TryParse(Console.ReadLine() ,out inp) && inp >= 0){
                    bool stat = true;
                    for(int i=2; i<=inp/2;i++){
                        if(inp % i == 0){
                            notPrime.Add(inp);
                            notPrimeTotal += inp;
                            stat = false;
                            break;
                        }
                    }
                    if(stat){ 
                        if(inp > 1){
                            prime.Add(inp);
                            primeTotal += inp;
                        }else{
                            notPrime.Add(inp);
                            notPrimeTotal += inp;
                        }
                        
                    }
                    count --;
                }else{
                    count ++;
                    continue;
                }
            }while(count > 0);


            Console.WriteLine("PRIME ARRAY ------------------");
            prime.Sort();
            foreach(int item in prime){
                Console.Write($"{item}\t");
            }

            Console.WriteLine("\nNOT PRIME ARRAY ------------------");
            notPrime.Sort();
            foreach(int item in notPrime){
                Console.Write($"{item}\t");
            }

            Console.WriteLine($"\nPrime Avg: {(primeTotal / prime.Count):F2}");
            Console.WriteLine($"Not Prime Avg: {(notPrimeTotal / notPrime.Count):F2}");




        }
    }
}