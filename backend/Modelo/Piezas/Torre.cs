namespace backend.Modelo.Piezas;

public class Torre : IPieza
{
    private Posicion _posicion;
    private Color _color;
    private bool _primerMovimiento;

    public Torre(Posicion posicion, Color color, bool primerMovimiento = true)
    {
        _color = color;
        _posicion = posicion;
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
        List<Posicion?> mov = new List<Posicion?>();

        // Se ejecutan 4 for loops para verificar movimientos posibles en las 4 direcciones.
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(_posicion.X - i, _posicion.Y))
            {
                if (tablero[_posicion.X - i, _posicion.Y] == null!)
                {
                    mov.Add(new Posicion(_posicion.X - i, _posicion.Y));
                }
                else if (tablero[_posicion.X - i, _posicion.Y].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X - i, _posicion.Y));
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(_posicion.X + i, _posicion.Y))
            {
                if (tablero[_posicion.X + i, _posicion.Y] == null!)
                {
                    mov.Add(new Posicion(_posicion.X + i, _posicion.Y));
                }
                else if (tablero[_posicion.X + i, _posicion.Y].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X + i, _posicion.Y));
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(_posicion.X, _posicion.Y + i))
            {
                if (tablero[_posicion.X, _posicion.Y + i] == null!)
                {
                    mov.Add(new Posicion(_posicion.X, _posicion.Y + i));
                }
                else if (tablero[_posicion.X, _posicion.Y + i].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X, _posicion.Y + i));
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(_posicion.X, _posicion.Y - i))
            {
                if (tablero[_posicion.X, _posicion.Y - i] == null!)
                {
                    mov.Add(new Posicion(_posicion.X, _posicion.Y - i));
                }
                else if (tablero[_posicion.X, _posicion.Y - i].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X, _posicion.Y - i));
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        return mov;
    }

    public Color ColorPieza()
    {
        return _color;
    }
    
    public string TipoPieza()
    {
        return "Torre";
    }

    public string TipoPiezaUniCode()
    {
        if (_color == Color.Blanco)
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
}