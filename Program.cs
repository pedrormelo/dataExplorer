using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //criar contadores de desempenho
        PerformanceCounter cpuCounter = new PerformanceCounter("Processor","% Processor Time", "_Total");
        PerformanceCounter ramCounter = new PerformanceCounter("Memory","Available MBytes");

        Console.WriteLine("Monitor de Sistema");
        Console.WriteLine("------------------");

        while (true)
        {

            //obter dados de cpu e ram
            float cpuUsage = cpuCounter.NextValue();
            float availableRAM = ramCounter.NextValue();

            //exibir resultados no console
            Console.Clear();
            Console.WriteLine("Monitor de Sistema");
            Console.WriteLine("------------------");
            Console.WriteLine($"Uso de CPU: {cpuUsage:F2}%");
            Console.WriteLine($"Memória disponível: {availableRAM:F2} MB");

            // pausar para atualizar a cada segundo
            System.Threading.Thread.Sleep(1000);
        }
    }
}