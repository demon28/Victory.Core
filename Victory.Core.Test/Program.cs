using System;
using Victory.Core.Models;

namespace Victory.Core.Test
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello World:" + Helpers.MachineHelper.GetCpuId());
        }
    }
}
