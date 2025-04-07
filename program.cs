class Program
{
    static void Main(string[] args)
    {
        ArbolBinario arbol = new ArbolBinario();

        // Construcción de ejemplo
        arbol.Raiz = new Nodo(1);
        arbol.Raiz.Izquierdo = new Nodo(2);
        arbol.Raiz.Derecho = new Nodo(3);

        Console.WriteLine("Recorrido InOrden:");
        arbol.InOrden(arbol.Raiz);
    }
}
