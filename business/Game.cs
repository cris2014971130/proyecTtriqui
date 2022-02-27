public class Game {

    public Player player1;
    public Player player2;
    public Board board;
    public int turn;
    public bool isOver;
    public Player winner;

    public Game(){
        board = new Board();
        this.turn = 1;
        this.isOver = false;
        beginGame();
    }

    public void beginGame(){
        setPlayers();
        showBoard();
        int jugada=1;
        while(isOver==false){
            Console.WriteLine("Jugada "+ jugada);
            startPlay();
            showBoard();
            jugada++;
        }
        
        if(isOver){
            if(getTurn()==1){
                turn = 2;
            }else{
                turn = 1;
            }
        }
        Console.WriteLine("El ganador es el jugador "+ getTurn());
    }

    public void setPlayers(){
        Console.WriteLine("Escriba el nombre del jugador Uno");
        player1 = new Player(Console.ReadLine());
        Console.WriteLine("Escriba el nombre del jugador Dos");
        player2 = new Player(Console.ReadLine());
    }

    public void showBoard(){
        this.board.displayBoard();
    }

    public void startPlay(){
        if(this.getTurn()==1){
            requestPlay(player1.getName());
            setTurn(2);
        }else{
            requestPlay(player2.getName());
            setTurn(1);
        }
        
        isOver = validateIsFinish();
    }

    public void requestPlay(string player){
        Attribute.shape shape = selectShape(player);
        Attribute.size size = selectSize(player);
        Attribute.color color = selectColor(player);
        Attribute.equis equis = selectEquis(player);
        placePiece(new Piece(shape, size, color, equis));
    } 

    public Attribute.shape selectShape(string player){
        Attribute.shape shape;
        Console.WriteLine("Que figura elige "+ player +":\n1.Cuadrado\n2.Circulo\n3.Triangulo\n");
        int optionUser = Int32.Parse(Console.ReadLine());
        if(optionUser==1){
            shape = Attribute.shape.SQUARE;
        }else if(optionUser==2){
            shape = Attribute.shape.CIRCLE;
        }else{
            shape = Attribute.shape.TRIANGLE;
        }
        return shape;   
     }

    public Attribute.size selectSize(string player){
        Attribute.size size;
        Console.WriteLine("Que Tamaño elige "+ player +"\n1.Grande\n2.Mediano\n3.Pequeño\n");
        int optionUser = Int32.Parse(Console.ReadLine());
        if(optionUser==1){
            size = Attribute.size.BIG;
        }else if(optionUser==2){
            size = Attribute.size.MEDIUM;
        }else{
            size = Attribute.size.SMALL;
        }
        return size;
    }

    public Attribute.color selectColor(string player){
        Attribute.color color;
        Console.WriteLine("Que Color elige "+ player +"\n1.Negro\n2.Verde\n3.Rojo\n");
        int optionUser = Int32.Parse(Console.ReadLine());
        if(optionUser==1){
            color = Attribute.color.BLACK;
        }else if(optionUser==2){
            color = Attribute.color.GREEN;
        }else{
            color = Attribute.color.RED;
        }
        return color;
    }

    public Attribute.equis selectEquis(string player ){
        Attribute.equis equis;
        Console.WriteLine("Tiene Equis "+ player +"\n1.Si Tiene\n2.No Tiene\n");
        int optionUser = Int32.Parse(Console.ReadLine());
        if(optionUser==1){
            equis = Attribute.equis.HAVE;
        }else {
            equis = Attribute.equis.NO_HAVE;
        }
        return equis;
    }

    public void setTurn(int turn){
        this.turn = turn;
    }

    public int getTurn(){
        return this.turn;
    }

    public void setIsOver(bool isOver){
        this.isOver = isOver;
    }

    public bool getIsOver(){
        return this.isOver;
    }

    public void placePiece(Piece piece){
        int posX;
        int posY;
        Console.WriteLine("En Que posicion la colocara. Escriba el numero para X (de 0 a 3)\n");
        posX = Int32.Parse(Console.ReadLine());

        Console.WriteLine("En Que posicion la colocara. Escriba el numero para Y (de 0 a 3)\n");
        posY = Int32.Parse(Console.ReadLine());
        board.putPieceBoard(piece, posX, posY);
    }

    public bool validateIsFinish(){
        if(board.validateRow(0) || board.validateRow(1) || board.validateRow(2) || board.validateRow(3)){
            return true;
        }else if(this.board.validateColumn(0) || this.board.validateColumn(1) || this.board.validateColumn(2) || this.board.validateColumn(3)){
            return true;
        }
        return false;
    }
}