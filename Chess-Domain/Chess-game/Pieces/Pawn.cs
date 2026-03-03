using Chess_Domain.Entities;
using Chess_Domain.Entities.Commun;
using Chess_Domain.Entities.Enums;

namespace Chess_Domain.Chess_game.Pieces;

public class Pawn : Piece
{
    public Pawn(Color color) : base(color) { }
    
    public override string ToString()
    {
        return "P";
    }
    
    public override bool Move(Position from, Position to)
    {
        int direction = (_color == Color.White) ? 1 : -1;

        // Movimento normal (1 casa)
        if (to.Row == from.Row + direction && to.Column == from.Column)
            return true;

        // Movimento inicial (2 casas)
        if ((_color == Color.White && from.Row == 1) ||
            (_color == Color.Black && from.Row == 6))
        {
            if (to.Row == from.Row + (2 * direction) && to.Column == from.Column)
                return true;
        }

        return false;
    }

    public override bool CanCapture(Position from, Position to)
    {
        int direction = (_color == Color.White) ? 1 : -1;

        if (to.Row == from.Row + direction &&
            (to.Column == from.Column + 1 || to.Column == from.Column - 1))
            return true;

        return false;
    }
}