// See https://aka.ms/new-console-template for more information

using backend.GUI;
using backend.Modelo;
using backend.Modelo.Piezas;

Tablero tablero = new Tablero(true);

VistaTablero vista = new VistaTablero();
tablero.Mesa[1, 4] = new Caballo(new Posicion(1, 4), Color.Negro);
vista.MostrarTablero(tablero);
List<Posicion?>? n = tablero.MovimientosPosibles(tablero.Mesa[1,4]);

foreach (var posicion in n)
{
    Console.WriteLine("({0},{1})",posicion.X+1,posicion.Y+1);
}

