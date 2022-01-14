using System.Text;
using backend.Modelo;

namespace backend.ConsoleView;

public class VistaTablero
{

    public void MostrarTablero(Tablero tablero)
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 7; i > -1; i--)
        {
            Console.Write(i+1+" ");
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

    public void MostrarMovimientos(List<Posicion> posMov,Tablero tablero)
    {
        
    }
}