using System;
using System.Collections;

namespace Work1{
    internal class Program{
        public static void Main(string[] args){
            int[] arr = new int[20];
            int minSum = 0 , maxSum = 0;
            float ortMin =0, ortMax=0;

            for(int i=0;i<20;i++){
                if(!int.TryParse(Console.ReadLine() , out arr[i])){
                    i--;
                }
            }
            Array.Sort(arr);
            for(int i=0; i<3;i++){
                minSum += arr[i];
                maxSum += arr[arr.Length-i-1];
            }
            ortMax  = maxSum/3 ;
            ortMin = (float)minSum /3;
            Console.WriteLine($"Kucuk toplam ortalama : {ortMin:F2}\nBuyuk toplam ortalama : {ortMax:F2}\nOrtalama toplamlari : {(ortMax + ortMin):F2}");



        }
    }
}