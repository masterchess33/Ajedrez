﻿namespace backend.Modelo.Piezas;

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

    public List<Posicion?>? Movimientos(IPieza[,] tablero)
    {
        List<Posicion?>? mov = new List<Posicion?>();
        if (Posicion.PosicionValida(_posicion.X+2,_posicion.Y+1))
            mov.Add(tablero[Posicion.X+2,Posicion.Y+1]== null || tablero[Posicion.X+2,Posicion.Y+1].CualColor()!= CualColor() ? 
                new Posicion(Posicion.X+2,Posicion.Y+1) : null);
        
        if (Posicion.PosicionValida(Posicion.X+2,Posicion.Y-1))
            mov.Add(tablero[Posicion.X+2,Posicion.Y-1]==null || 
                    tablero[Posicion.X+2,Posicion.Y-1].CualColor()!= CualColor() ? 
                new Posicion(Posicion.X+2,Posicion.Y-1) : null);
        
        if (Posicion.PosicionValida(Posicion.X-2,Posicion.Y+1))
            mov.Add(tablero[Posicion.X-2,Posicion.Y+1]==null || 
                    tablero[Posicion.X-2,Posicion.Y+1].CualColor()!= CualColor() ? 
            new Posicion(Posicion.X-2,Posicion.Y+1) : null);
        
        if (Posicion.PosicionValida(Posicion.X-2,Posicion.Y-1))
            mov.Add(tablero[Posicion.X-2,Posicion.Y-1]==null || 
                    tablero[Posicion.X-2,Posicion.Y-1].CualColor()!= CualColor() ? 
            new Posicion(Posicion.X-2,Posicion.Y-1) : null);
        
        if (Posicion.PosicionValida(Posicion.X-1,Posicion.Y+2))
            mov.Add(tablero[Posicion.X-1,Posicion.Y+2]==null || 
                    tablero[Posicion.X-1,Posicion.Y+2].CualColor()!= CualColor() ? 
            new Posicion(Posicion.X-1,Posicion.Y+2) : null);
        
        if (Posicion.PosicionValida(Posicion.X+1,Posicion.Y+2))
            mov.Add(tablero[Posicion.X+1,Posicion.Y+2]==null || 
                    tablero[Posicion.X+1,Posicion.Y+2].CualColor()!= CualColor() ? 
            new Posicion(Posicion.X+1,Posicion.Y+2) : null);
        
        if (Posicion.PosicionValida(Posicion.X-1,Posicion.Y-2)) 
            mov.Add(tablero[Posicion.X-1,Posicion.Y-2]==null || 
                tablero[Posicion.X-1,Posicion.Y-2].CualColor()!= CualColor() ? 
            new Posicion(Posicion.X-1,Posicion.Y-2) : null);
        
        if (Posicion.PosicionValida(Posicion.X+1,Posicion.Y-2))
            mov.Add(tablero[Posicion.X+1,Posicion.Y-2]==null || 
                    tablero[Posicion.X+1,Posicion.Y-2].CualColor()!= CualColor() ? 
            new Posicion(Posicion.X+1,Posicion.Y-2) : null);
        
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