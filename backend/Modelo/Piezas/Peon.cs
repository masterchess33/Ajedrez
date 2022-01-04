namespace backend.Modelo.Piezas;

public class Peon: IPieza
{
    private Posicion _posicion;
    private Color _color;
    private bool _primerMovimiento;
    private bool _direccion;
    private bool _objetivo;

    public Peon(Posicion posicion, Color color, bool direccion, bool primerMovimiento = true)
    {
        _posicion = posicion;
        _color = color;
        _direccion = direccion;
        _primerMovimiento = primerMovimiento;
        _objetivo = false;
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
        
        /*if (_primerMovimiento)
        {
            if (!_direccion)
            {
                mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y - 2));
                mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y - 1));
            }
            else
            {
                mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y + 2));
                mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y + 1));
            }
        }else 
        {
            if (!_direccion)
                mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y - 1));
            else
                mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y + 1));
        }*/
        
        mov.RemoveAll(item => item == null);
        return mov;
    }

    public bool EsObjetivo()
    {
        return _objetivo;
    }

    public String TipoPiezaUniCode()
    {
        if ( _color== Color.Blanco)
        {
            return "\u2659";
        }
        else
        {
            return "\u265F";
        }
    }

    public Color CualColor()
    {
        return _color;
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

    public bool Direccion
    {
        get => _direccion;
        set => _direccion = value;
    }

    public bool Objetivo
    {
        get => _objetivo;
        set => _objetivo = value;
    }
}