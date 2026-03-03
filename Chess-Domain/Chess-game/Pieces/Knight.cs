using Chess_Domain.Entities;
using Chess_Domain.Entities.Commun;
using Chess_Domain.Entities.Enums;

namespace Chess_Domain.Chess_game.Pieces;

public class Knight : Piece
{
    public Knight(Color color) : base(color)
    {
    }
    
    
    public override string ToString()
    {
        return "K";
    }
    public override bool Move(Position from, Position to)
    {
        int rowDiff = Math.Abs(from.Row - to.Row);
        int colDiff = Math.Abs(from.Column - to.Column);

        return (rowDiff == 2 && colDiff == 1) ||
               (rowDiff == 1 && colDiff == 2);
    }

    public override bool CanCapture(Position from, Position to)
    {
        return Move(from, to);
    }
}