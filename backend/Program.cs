// See https://aka.ms/new-console-template for more information

using backend.ConsoleView;
using backend.Modelo;
using backend.Modelo.Piezas;

Tablero tablero = new Tablero(false);

int x = 4;
int y = 3;

VistaTablero vista = new VistaTablero();

tablero.Mesa[x,y] = new Rey(new Posicion(x, y), Color.Blanco);
tablero.Mesa[5, 4] = new Peon(new Posicion(3, 3), Color.Negro, true);
tablero.Mesa[3, 5] = new Caballo(new Posicion(3, 5), Color.Blanco);

vista.MostrarTablero(tablero);

//List<Posicion?> n = tablero.Mesa[1, 2].Movimientos(tablero.Mesa);

Console.WriteLine(tablero.Jaque(new Posicion(x,y),Color.Blanco));

/*foreach (var posicion in n)
{
    Console.WriteLine("({0},{1})",Posicion.Letra(posicion!.X),posicion.Y+1);
}*/

