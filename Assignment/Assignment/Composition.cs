using System;

namespace Assignment
{
    // This program demo. how to create composition
    class Composition
    {
        static void Main()
        {
            Table table1 = new Table();
            Chair chair1 = new Chair(table1,23,"Wood");
            table1.AddChair(chair1.NoOfTables,chair1.Material);
            Console.ReadLine();

        }
    }
    class Table:IDisposable

    { 
        public List<Chair> Chairs { get; set; }
        public void  AddChair()
        {
            Chairs.Add(new Chair(this, noOfTables, material));
        }

        public void Dispose()
        {
            foreach(var ch in Chairs)
            {
                ch.Dispose();
            }
            this.Dispose();
        }
    }
    class Chair:IDisposable
    {
        public int NoOfTables { get; set; }
        public string Material { get; set; }
        public Chair(int noOfTables, string material)
        {
            this.NoOfTables = noOfTables;
            this.Material = material;
        }

        public void Dispose()
        {
            this.Dispose();  
        }
    }

}
