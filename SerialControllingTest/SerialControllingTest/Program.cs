using System;
using System.IO.Ports;

namespace SerialControllingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerialPort serialPort = new SerialPort("COM4", 9600);
            serialPort.Open();
            serialPort.ReadTimeout = 1;

            while (serialPort.IsOpen)
            {
                try
                {
                    switch (serialPort.ReadByte())
                    {
                        case 1:
                            Console.WriteLine("RT");
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 2:
                            Console.WriteLine("LT");
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;

                        default:
                            break;
                    }
                    break;
                }
                catch (Exception)
                {
                    throw new Exception("You have a error");
                    break;
                }
            }
        }
    }
}
