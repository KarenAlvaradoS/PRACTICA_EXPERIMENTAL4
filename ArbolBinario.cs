public class ArbolBinario
{
    public Nodo? Raiz { get; set; }

    public ArbolBinario()
    {
        Raiz = null;
    }

    public void InOrden(Nodo? nodo)
    {
        if (nodo != null)
        {
            InOrden(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            InOrden(nodo.Derecho);
        }
    }
}
