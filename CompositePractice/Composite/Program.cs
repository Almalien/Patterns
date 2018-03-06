using Composite.BL;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure 

            CompositeElement root =
              new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch

            CompositeElement comp =
              new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Segunda rama

            CompositeElement comp2 =
              new CompositeElement("Three triangles");
            comp2.Add(new PrimitiveElement("Red Triangle"));
            comp2.Add(new PrimitiveElement("Pink Triangle"));
            comp2.Add(new PrimitiveElement("Yellow Triangle"));
            comp.Add(comp2);

            // Add and remove a PrimitiveElement

            PrimitiveElement pe =
              new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes

            root.Display(1);

            // Wait for user

            Console.ReadKey();
        }
    }
}
