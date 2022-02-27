public class Board
{

    public bool isFull;
    public Cell[,] board;
    public const int BOARD_DIMENSIONS = 4;

    public Board(){
        this.isFull = false;
        initBoard();
    }

    public void initBoard(){
        board = new Cell[BOARD_DIMENSIONS, BOARD_DIMENSIONS];
        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            for (int j = 0; j < BOARD_DIMENSIONS; j++){
                board[i,j] = new Cell(i,j);
            }
        }
    }

    public void displayBoard(){
        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            Console.Write("[");
            for (int j = 0; j < BOARD_DIMENSIONS; j++){
                if(board[i, j].getPiece()!= null){
                    Console.Write(board[i, j].getPiece().toString());
                }else{
                    Console.Write(" ----------- ");
                }
            }
            Console.WriteLine("]");
        }
    }

    public void setIsFull(bool isFull){
        this.isFull = isFull;
    }

    public bool getIsFull(){
        return this.isFull;
    }

    public void putPieceBoard(Piece piece, int posX, int posY){
        this.board[posX,posY].setPiece(piece);
        this.board[posX,posY].setIsEmpty(false);
    }

    public bool validateRow(int posRow){
        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            if(board[posRow,i].getPiece() == null){
                return false;
            }
        }
        Attribute.shape shape = board[posRow,0].getPiece().shape;
        Attribute.size size = board[posRow,0].getPiece().size;
        Attribute.color color = board[posRow,0].getPiece().color;
        Attribute.equis equis = board[posRow,0].getPiece().equis;

        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            if (shape == board[posRow,i].getPiece().shape){
                return true;
            }
        }

        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            if (size == board[posRow,i].getPiece().size){
                return true;
            }
        }

        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            if (color == board[posRow,i].getPiece().color){
                return true;
            }
        }

        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            if (equis == board[posRow,i].getPiece().equis){
                return true;
            }
        }
        return false;
    }

    public bool validateColumn(int posColumn){
        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            if(board[i,posColumn].getPiece() == null){
                return false;
            }
        }
        Attribute.shape shape = board[0,posColumn].getPiece().shape;
        Attribute.size size = board[0,posColumn].getPiece().size;
        Attribute.color color = board[0,posColumn].getPiece().color;
        Attribute.equis equis = board[0,posColumn].getPiece().equis;

        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            if (shape == board[i,posColumn].getPiece().shape){
                return true;
            }
        }

        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            if (size == board[i,posColumn].getPiece().size){
                return true;
            }
        }

        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            if (color == board[i,posColumn].getPiece().color){
                return true;
            }
        }

        for (int i = 0; i < BOARD_DIMENSIONS; i++){
            if (equis == board[i,posColumn].getPiece().equis){
                return true;
            }
        }
        return false;
    }
};


