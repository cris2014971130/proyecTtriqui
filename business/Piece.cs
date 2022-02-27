public class Piece {
    
    public Attribute.shape shape;
    public Attribute.size size;
    public Attribute.color color;
    public Attribute.equis equis;
    public Piece piece;

    public Piece(Attribute.shape shape, Attribute.size size, Attribute.color color, Attribute.equis equis){
        this.shape = shape;
        this.size = size;
        this.color = color;
        this.equis = equis;
    }

    public void setPiece(Piece piece){
        this.piece = piece;
    }
    public Piece getPiece(){
        return this.piece;
    }

    public string toString(){
        return this.shape.ToString() +this.size.ToString() + this.color.ToString() +this.equis.ToString();
    }
}