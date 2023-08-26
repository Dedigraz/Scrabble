using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Shared.Models;
public record Board
{
    public int[,] Squares { get; set; }
    
    public Board()
    {
        Squares = new int[15, 15];
        for (int i = 0; i < Squares.GetLength(0); i++)
        {
            for (int j = 0; j < Squares.GetLength(1); j++)
            {
                Squares[i, j] = 1;
            }
        }
    }
}

public record Rack
{
    public Pieces.Piece[] Pieces { get; set; }
    public Rack()
    {
        Pieces = new Pieces.Piece[100];
    }
}

// enum that defines the pecies in a standard english scrabble set

public struct Pieces
{
    public Piece Letter { get; set; }
    public enum Piece
    {
        A = 1,
        B = 3,
        C = 3,
        D = 2,
        E = 1,
        F = 4,
        G = 2,
        H = 4,
        I = 1,
        J = 8,
        K = 5,
        L = 1,
        M = 3,
        N = 1,
        O = 1,
        P = 3,
        Q = 10,
        R = 1,
        S = 1,
        T = 1,
        U = 1,
        V = 4,
        W = 4,
        X = 8,
        Y = 4,
        Z = 10,
        Blank = 0
    }
}

public record Game{
    public Queue<Move> Moves { get; set; }
    public Dictionary<Pieces.Piece, uint> Bag { get; set; }
    public Board Board { get; set; }

    public Game()
    {
        Moves = new Queue<Move>();
        Bag = new Dictionary<Pieces.Piece, uint>();
        Bag.Add(Pieces.Piece.A, 9);
        Bag.Add(Pieces.Piece.B, 2);
        Bag.Add(Pieces.Piece.C, 2);
        Bag.Add(Pieces.Piece.D, 4);
        Bag.Add(Pieces.Piece.E, 12);
        Bag.Add(Pieces.Piece.F, 2);
        Bag.Add(Pieces.Piece.G, 3);
        Bag.Add(Pieces.Piece.H, 2);
        Bag.Add(Pieces.Piece.I, 9);
        Bag.Add(Pieces.Piece.J, 1);
        Bag.Add(Pieces.Piece.K, 1);
        Bag.Add(Pieces.Piece.L, 4);
        Bag.Add(Pieces.Piece.M, 2);
        Bag.Add(Pieces.Piece.N, 6);
        Bag.Add(Pieces.Piece.O, 8);
        Bag.Add(Pieces.Piece.P, 2);
        Bag.Add(Pieces.Piece.Q, 1);
        Bag.Add(Pieces.Piece.R, 6);
        Bag.Add(Pieces.Piece.S, 4);
        Bag.Add(Pieces.Piece.T, 6);
        Bag.Add(Pieces.Piece.U, 4);
        Bag.Add(Pieces.Piece.V, 2);
        Bag.Add(Pieces.Piece.W, 2);
        Bag.Add(Pieces.Piece.X, 1);
        Bag.Add(Pieces.Piece.Y, 2);
        Bag.Add(Pieces.Piece.Z, 1);
        Bag.Add(Pieces.Piece.Blank, 2);
    }
}

public record Move
{
    public string Word { get; set; }
    public int Score { get; set; }
    public string StartingPosition { get;set; } // in the standard format of 'A1' or '8D
    public MoveDirection Direction { get; set; }

}

public enum MoveDirection
{
    Horizontal,
    Vertical
}