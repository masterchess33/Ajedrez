namespace backend.Modelo.Piezas;

public class Reina : IPieza
{
    private Posicion _posicion;
    private Color _color;

    public Reina(Posicion posicion, Color color)
    {
        _posicion = posicion;
        _color = color;
    }

    public void Mover(Posicion posicion)
    {
        _posicion = posicion;
    }

    public List<Posicion?> Movimientos(IPieza[,] tablero)
    {
        List<Posicion?>? mov = new List<Posicion?>();
        
        // Se ejecutan 4 for loops para verificar movimientos posibles
        // en las 4 direcciones horizontales.
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
        
        // Luego se ejecutan 4 loops en las 4 direcciones diagonales.
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(_posicion.X + i, _posicion.Y + i))
            {
                if (tablero[_posicion.X + i, _posicion.Y + i] == null!)
                {
                    mov.Add(new Posicion(_posicion.X + i, _posicion.Y + i));
                }
                else if (tablero[_posicion.X + i, _posicion.Y + i].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X + i, _posicion.Y + i));
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
            if (Posicion.PosicionValida(_posicion.X + i, _posicion.Y - i))
            {
                if (tablero[_posicion.X + i, _posicion.Y - i] == null!)
                {
                    mov.Add(new Posicion(_posicion.X + i, _posicion.Y - i));
                }
                else if (tablero[_posicion.X + i, _posicion.Y - i].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X + i, _posicion.Y - i));
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
            if (Posicion.PosicionValida(_posicion.X - i, _posicion.Y + i))
            {
                if (tablero[_posicion.X - i, _posicion.Y + i] == null!)
                {
                    mov.Add(new Posicion(_posicion.X - i, _posicion.Y + i));
                }
                else if (tablero[_posicion.X - i, _posicion.Y + i].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X - i, _posicion.Y + i));
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
            if (Posicion.PosicionValida(_posicion.X - i, _posicion.Y - i))
            {
                if (tablero[_posicion.X - i, _posicion.Y - i] == null!)
                {
                    mov.Add(new Posicion(_posicion.X - i, _posicion.Y - i));
                }
                else if (tablero[_posicion.X - i, _posicion.Y - i].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X - i, _posicion.Y - i));
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

    public string TipoPieza()
    {
        return "Reina";
    }
    
    public string TipoPiezaUniCode()
    {
        if ( _color== Color.Blanco)
        {
            return "\u2655";
        }
        else
        {
            return "\u265B";
        }
    }

    public Color ColorPieza()
    {
        return _color;
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
}