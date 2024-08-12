using System;
namespace laisuatchovay{
    class Program{
        static void Main(string[] Args){
            double money;
            int month;
            double intersetRate;

            Console.WriteLine("So tien muon gui: ");
            money = Double.Parse(Console.ReadLine());
            Console.WriteLine("So thang muon gui: ");
            month = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Lai suat la: ");
            intersetRate = double.Parse(Console.ReadLine());

            double totalInterset = 0;
            for(int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate/100)/12 * 3; 
            }
            Console.WriteLine("Lai suat nhan duoc: " + totalInterset);

        }
    }
}
