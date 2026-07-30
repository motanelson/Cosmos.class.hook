// See https://aka.ms/new-console-template for more information
public class x
{
    public static void box(int x,int y,int w,int h)
    {
        Console.WriteLine("x:{0}\ny:{1}\nw:{2}\nh:{3}\n",x,y,w,h);
    }
}
class xclass {
    public static void Main() {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        x.box(0,0,10,10);
    }
}