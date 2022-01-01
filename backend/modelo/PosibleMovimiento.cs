namespace JuegoAjedrez.modelo;

public class PosibleMovimiento: IPieza
{
    private Color _color;
    
    public PosibleMovimiento()
    {
        _color = Color.SinColor;
    }
    
    public void Mover(Posicion posicion)
    {
        
    }

    public List<Posicion?>? Movimientos()
    {
        return null;
    }

    public string TipoPiezaUniCode()
    {
        return "*";
    }
    
    public Color CualColor()
    {
        return _color;
    }

    public bool EsObjetivo()
    {
        return false;
    }
}