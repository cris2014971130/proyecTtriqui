public class Cell {
    
    public int row;
    public int column;
    public bool isEmpty;
    public Piece piece;

    public Cell(int row, int column){
        this.row = row;
        this.column = column;
        this.isEmpty = true;
    }
    
    public void setPiece(Piece piece){
        this.piece = piece;
    }

    public Piece getPiece(){
        return this.piece;
    }

    public void setIsEmpty(bool isEmpty){
        this.isEmpty = isEmpty;
    }
    
    public bool getIsEmpty(){
        return this.isEmpty;
    }
};