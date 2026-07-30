// See https://aka.ms/new-console-template for more information
public class x
{
    private static string spaces(int a) 
    {
        string b = "";
        for (int i = 0; i < a; i++) b = b + " ";
        return b;
    }
    public static void box(int x,int y,int w,int h)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 0; i < y/8; i++) Console.WriteLine("");
        
        for (int i = 0; i < h/8; i++)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(spaces(x/8));
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(spaces(w/8));Console.WriteLine("");
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
}
class xclass {
    public static void Main() {
        
        Console.Clear();
        x.box(16,16,80,80);
    }
}