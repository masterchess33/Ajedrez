namespace JuegoAjedrez.modelo;

public class Caballo : IPieza
{
    private Posicion _posicion;
    private Color _color;
    private bool _objetivo;

    public Caballo(Posicion posicion, Color color)
    {
        _posicion = posicion;
        _color = color;
        _objetivo = false;
    }

    public void Mover(Posicion posicion)
    {
        _posicion = posicion;
    }

    public List<Posicion?>? Movimientos()
    {
        List<Posicion?>? mov = new List<Posicion?>();
        
        
        mov.RemoveAll(item => item == null);
        return mov;
    }
    
    public Color CualColor()
    {
        return _color;
    }

    public bool EsObjetivo()
    {
        return _objetivo;
    }

    public string TipoPiezaUniCode()
    {
        if ( _color== Color.Blanco)
        {
            return "\u2658";
        }
        else
        {
            return "\u265E";
        }
    }

    public Posicion Posicion
    {
        get => _posicion;
        set => _posicion = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Color Color
    {
        get => _color;
        set => _color = value;
    }

    public bool Objetivo
    {
        get => _objetivo;
        set => _objetivo = value;
    }
}