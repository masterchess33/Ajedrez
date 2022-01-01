// See https://aka.ms/new-console-template for more information

using JuegoAjedrez.GUI;
using JuegoAjedrez.modelo;

Tablero tablero = new Tablero(true);

VistaTablero vista = new VistaTablero();
tablero.Mesa[1, 4] = new Caballo(new Posicion(1, 4), Color.Negro);
vista.mostrarTablero(tablero);
List<Posicion?>? n = tablero.MovimientosPosibles(tablero.Mesa[1,4]);

foreach (var posicion in n)
{
    Console.WriteLine(posicion.X+","+(posicion.Y));
}

