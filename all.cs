using System; // все работает только с положительными числами

class Program
{
    static void output_mass(int[] mass)
    {
        for (int i = 0; i < mass.Length - 1; i++)
        {
            Console.WriteLine(mass[i]);
        }
    }
    static void input_mass(out int[] mass, int a , int b){
        mass= new int[b - a+1];
        int k = 0;
            for (int i = a; i <= b - 1; i++)
            {
                mass[k] = i;
                k++;
            }        
    }
    static int[] shuf_ts(int[] mass)
    {
        int t;
        for (int i =0; i < mass.Length/2; i++)
        {
            t = mass[i];
            mass[i] = mass[i+mass.Length/2 + mass.Length%2];
            mass[i + mass.Length / 2 + mass.Length % 2] = t;
        }
        return mass;
    }
    static int[] del_n(int[] mass, int k)
    {
        for (int i = k; i < mass.Length-1; i++)
        {
            mass[i] = mass[i + 1];
        }
        return mass;
    }
    static int[] move_k(int[] mass, int k)
    {
        k--;
        for (int i = mass.Length - 1; i > k; i--) mass[i] = mass[i - 1];
        return mass;
    }
    public static void Main()
    {

    }
}
