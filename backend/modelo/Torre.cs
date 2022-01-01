namespace JuegoAjedrez.modelo;

public class Torre : IPieza
{
    private Posicion _posicion;
    private Color _color;
    private bool _primerMovimiento;
    private bool _objetivo;

    public Torre(Posicion posicion, Color color, bool primerMovimiento = true)
    {
        _color = color;
        _posicion = posicion;
        _primerMovimiento = primerMovimiento;
        _objetivo = false;
    }

    public void Mover(Posicion posicion)
    {
        _posicion = posicion;
    }
    
    public List<Posicion?>? Movimientos()
    {
        List<Posicion?>? mov = new List<Posicion?>();
        for (int i = 1; i < 8; i++)
        {
            /*mov.Add(Posicion.CrearPosicionValida(_posicion.X + i, _posicion.Y));
            mov.Add(Posicion.CrearPosicionValida(_posicion.X - i, _posicion.Y));
            mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y + i));
            mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y - i));*/
        }

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
            return "\u2656";
        }
        else
        {
            return "\u265C";
        }
    }

    public Posicion Posicion
    {
        get => _posicion;
        set => _posicion = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool PrimerMovimiento
    {
        get => _primerMovimiento;
        set => _primerMovimiento = value;
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