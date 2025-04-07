using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear el grafo
        Dictionary<string, List<string>> grafo1 = new Dictionary<string, List<string>>();

        // Agregar nodos y sus adyacentes
        grafo1["A"] = new List<string> { "B", "C" };
        grafo1["B"] = new List<string> { "A", "D" };
        grafo1["C"] = new List<string> { "A", "D" };
        grafo1["D"] = new List<string> { "B", "C" };

        // Mostrar el grafo
        MostrarGrafo(grafo1);
    }

    static void MostrarGrafo(Dictionary<string, List<string>> grafo)
    {
        foreach (var nodo in grafo)
        {
            Console.Write($"{nodo.Key}: ");
            foreach (var adyacente in nodo.Value)
            {
                Console.Write($"{adyacente} ");
            }
            Console.WriteLine();
        }
    }
}
