namespace backend.Modelo.Piezas;

public class Rey : IPieza
{
    private Posicion _posicion;
    private Color _color;
    private bool _primerMovimiento;

    public Rey(Posicion posicion, Color color, bool primerMovimiento = true)
    {
        _posicion = posicion;
        _color = color;
        _primerMovimiento = primerMovimiento;
    }

    public void Mover(Posicion posicion)
    {
        if (_primerMovimiento)
        {
            _primerMovimiento = false;
        }
        _posicion = posicion;
    }

    public List<Posicion?> Movimientos(IPieza[,] tablero)
    {
        List<Posicion?>? mov = new List<Posicion?>();

        /*mov.Add(Posicion.CrearPosicionValida(_posicion.X + 1, _posicion.Y));
        mov.Add(Posicion.CrearPosicionValida(_posicion.X + 1, _posicion.Y + 1));
        mov.Add(Posicion.CrearPosicionValida(_posicion.X + 1, _posicion.Y - 1));
        mov.Add(Posicion.CrearPosicionValida(_posicion.X - 1, _posicion.Y - 1));
        mov.Add(Posicion.CrearPosicionValida(_posicion.X - 1, _posicion.Y + 1));
        mov.Add(Posicion.CrearPosicionValida(_posicion.X - 1, _posicion.Y));
        mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y - 1));
        mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y + 1));*/

        mov.RemoveAll(item => item == null);
        return mov;
    }

    public Color ColorPieza()
    {
        return _color;
    }

    public string TipoPieza()
    {
        return "Rey";
    }
    
    public string TipoPiezaUniCode()
    {
        
        if ( _color== Color.Blanco)
        {
            return "\u2654";
        }
        else
        {
            return "\u265A";
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

    public bool PrimerMovimiento
    {
        get => _primerMovimiento;
        set => _primerMovimiento = value;
    }
}