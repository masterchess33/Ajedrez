using System.Text;
using JuegoAjedrez.modelo;

namespace JuegoAjedrez.GUI;

public class VistaTablero
{

    public void mostrarTablero(Tablero tablero)
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 0; i < 8; i++)
        {
            Console.Write(8-i+" ");
            for (int j = 0; j < 8; j++)
            {
                if (tablero.Mesa[j, i] is not null)
                {
                    Console.Write("["+tablero.Mesa[j, i].TipoPiezaUniCode()+" ]");
                }
                else
                {
                    Console.Write("[  ]");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("   A   B   C   D   E   f   G   H");
    }

    public void mostrarMovimientos(List<Posicion> posMov,Tablero tablero)
    {
        for (int i = 0; i < posMov.Count; i++)
        {
            tablero.Mesa[posMov[i].X, posMov[i].Y] = new PosibleMovimiento();
        }
    }
}