﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725642
{
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("download");
            Download();
            Console.ReadLine():
            
            
        }
        static async void Download()
        {
            await Network.download();
            Console.WriteLine("download complete");
        }


        class Network
        {
            static public Task download()
            {
                return Task.Run(
                () => ThreadStaticAttribute.Sleep(60000));
            }
        }
    }
}