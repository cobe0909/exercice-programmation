namespace exercice
{
    
}
abstract class Nas

{
   public static int fois1(int x)
    {
        int y = x * 1;
        return y;
    }

    public static int fois2(int x)
    {
        int y = x * 2;
        if (y > 9)
        {
            string b = y.ToString();
            string c = (b.Substring(0, 1));
            string d = (b.Substring(1, 1));
            int e = int.Parse(c);
            int f = int.Parse(d);
            int g = e + f;
            return g;
        }
        else
        {
            int b;
            b = y;
            return b;

        }
    }
}




