namespace backend.Modelo.Piezas;

public interface IPieza
{
    public void Mover(Posicion posicion);

    public List<Posicion?> Movimientos(IPieza[,] tablero);

    public String TipoPiezaUniCode();

    public Color CualColor();
}