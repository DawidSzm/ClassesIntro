namespace ClassesIntro;

public class Cell
{
    private char symbol;
    public Cell(char symbol)
    {
        this.symbol = symbol;
    }

    public void Display()
    {
        Console.Write(symbol);
    }
}