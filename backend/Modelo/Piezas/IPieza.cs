namespace backend.Modelo.Piezas;

public interface IPieza
{
    public void Mover(Posicion posicion);

    public List<Posicion?>? Movimientos();

    public String TipoPiezaUniCode();

    public Color CualColor();

    public bool EsObjetivo();
}