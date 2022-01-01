namespace JuegoAjedrez.modelo;

public class Tablero
{
    private IPieza[,] _mesa;
    public Tablero(bool jugador)
    {
        Color jugador1 = Color.Blanco;
        Color jugador2 = Color.Negro;
        bool direccionjugador1 = false;
        bool direccionjugador2 = true; 
        
        if (!jugador)
        {
            Console.WriteLine("hola");
            jugador1 = Color.Negro;
            jugador2 = Color.Blanco;
            direccionjugador1 = true;
            direccionjugador2 = false;
        }
        
        // Se inicializa el tablero
        _mesa = new IPieza[8,8];
        
        // Peones 
        for (int i = 0; i < 8; i++)
        {
            _mesa[i, 6] = new Peon(new Posicion(i,6), jugador1,direccionjugador1);
            _mesa[i, 1] = new Peon(new Posicion(i,1), jugador2, direccionjugador2);
        }
        
        // caballos
        _mesa[1, 7] = new Caballo(new Posicion(1, 7), jugador1);
        _mesa[1, 0] = new Caballo(new Posicion(1, 0), jugador2);
        _mesa[6, 7] = new Caballo(new Posicion(1, 7), jugador1);
        _mesa[6, 0] = new Caballo(new Posicion(1, 0), jugador2);
        
        // Alfiles
        _mesa[2, 7] = new Alfil(new Posicion(2, 7), jugador1);
        _mesa[5, 7] = new Alfil(new Posicion(5, 7), jugador1);
        _mesa[2, 0] = new Alfil(new Posicion(2, 0), jugador2);
        _mesa[5, 0] = new Alfil(new Posicion(5, 0), jugador2);
        
        // Torres
        _mesa[0, 7] = new Torre(new Posicion(0, 7),jugador1);
        _mesa[7, 7] = new Torre(new Posicion(7, 7),jugador1);
        _mesa[0, 0] = new Torre(new Posicion(0, 0),jugador2);
        _mesa[7, 0] = new Torre(new Posicion(7, 0),jugador2);
        
        // Rey y reina
        _mesa[3, 7] = new Reina(new Posicion(3, 7), jugador1);
        _mesa[3, 0] = new Reina(new Posicion(3, 0), jugador2);
        
        _mesa[4, 7] = new Rey(new Posicion(4, 7), jugador1);
        _mesa[4, 0] = new Rey(new Posicion(4, 0), jugador2);

    }
    
    public List<Posicion?>? MovimientosPosibles(IPieza pieza)
    {
        switch (pieza)
        {
            case Caballo caballo:
                return MovimientoCaballo((Caballo) pieza);
            case Torre torre:
                break;
        }

        return new List<Posicion?>();
    }

    private List<Posicion?> MovimientoCaballo(Caballo caballo)
    {
        List<Posicion?>? mov = new List<Posicion?>();
        if (Posicion.CrearPosicionValida(caballo.Posicion.X+2,caballo.Posicion.Y+1))
            mov.Add(_mesa[caballo.Posicion.X+2,caballo.Posicion.Y+1]==null || 
                    _mesa[caballo.Posicion.X+2,caballo.Posicion.Y+1].CualColor()!= caballo.CualColor() ? 
                new Posicion(caballo.Posicion.X+2,caballo.Posicion.Y+1) : null);
        
        if (Posicion.CrearPosicionValida(caballo.Posicion.X+2,caballo.Posicion.Y-1))
            mov.Add(_mesa[caballo.Posicion.X+2,caballo.Posicion.Y-1]==null || 
                    _mesa[caballo.Posicion.X+2,caballo.Posicion.Y-1].CualColor()!= caballo.CualColor() ? 
                new Posicion(caballo.Posicion.X+2,caballo.Posicion.Y-1) : null);
        
        if (Posicion.CrearPosicionValida(caballo.Posicion.X-2,caballo.Posicion.Y+1))
            mov.Add(_mesa[caballo.Posicion.X-2,caballo.Posicion.Y+1]==null || 
                    _mesa[caballo.Posicion.X-2,caballo.Posicion.Y+1].CualColor()!= caballo.CualColor() ? 
            new Posicion(caballo.Posicion.X-2,caballo.Posicion.Y+1) : null);
        
        if (Posicion.CrearPosicionValida(caballo.Posicion.X-2,caballo.Posicion.Y-1))
            mov.Add(_mesa[caballo.Posicion.X-2,caballo.Posicion.Y-1]==null || 
                    _mesa[caballo.Posicion.X-2,caballo.Posicion.Y-1].CualColor()!= caballo.CualColor() ? 
            new Posicion(caballo.Posicion.X-2,caballo.Posicion.Y-1) : null);
        
        if (Posicion.CrearPosicionValida(caballo.Posicion.X-1,caballo.Posicion.Y+2))
            mov.Add(_mesa[caballo.Posicion.X-1,caballo.Posicion.Y+2]==null || 
                    _mesa[caballo.Posicion.X-1,caballo.Posicion.Y+2].CualColor()!= caballo.CualColor() ? 
            new Posicion(caballo.Posicion.X-1,caballo.Posicion.Y+2) : null);
        
        if (Posicion.CrearPosicionValida(caballo.Posicion.X+1,caballo.Posicion.Y+2))
            mov.Add(_mesa[caballo.Posicion.X+1,caballo.Posicion.Y+2]==null || 
                    _mesa[caballo.Posicion.X+1,caballo.Posicion.Y+2].CualColor()!= caballo.CualColor() ? 
            new Posicion(caballo.Posicion.X+1,caballo.Posicion.Y+2) : null);
        
        if (Posicion.CrearPosicionValida(caballo.Posicion.X-1,caballo.Posicion.Y-2)) 
            mov.Add(_mesa[caballo.Posicion.X-1,caballo.Posicion.Y-2]==null || 
                _mesa[caballo.Posicion.X-1,caballo.Posicion.Y-2].CualColor()!= caballo.CualColor() ? 
            new Posicion(caballo.Posicion.X-1,caballo.Posicion.Y-2) : null);
        
        if (Posicion.CrearPosicionValida(caballo.Posicion.X+1,caballo.Posicion.Y-2))
            mov.Add(_mesa[caballo.Posicion.X+1,caballo.Posicion.Y-2]==null || 
                    _mesa[caballo.Posicion.X+1,caballo.Posicion.Y-2].CualColor()!= caballo.CualColor() ? 
            new Posicion(caballo.Posicion.X+1,caballo.Posicion.Y-2) : null);
        
        mov.RemoveAll(item => item == null);
        return mov;
    }

    private List<Posicion?> MovimientoTorre(Torre torre)
    {
        List<Posicion?>? mov = new List<Posicion?>();

        for (int i = torre.Posicion.X; i < 1; i++)
        {
            
        }
        
        mov.RemoveAll(item => item == null);
        return mov;
    }

    public IPieza[,] Mesa
    {
        get => _mesa;
        set => _mesa = value ?? throw new ArgumentNullException(nameof(value));
    }
}