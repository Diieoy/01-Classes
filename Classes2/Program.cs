using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Subject steel_wire = new Subject("wire", new Material("steel", 7850), 0.03);

            //2
            Console.WriteLine(steel_wire);

            //3
            Material copper = new Material("copper", 8500);
            steel_wire.Material = copper;
            Console.WriteLine(steel_wire.GetMass());

            Console.ReadKey();
        }
    }
}
