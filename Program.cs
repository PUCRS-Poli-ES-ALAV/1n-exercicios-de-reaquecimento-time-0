using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(multiplicaPorSoma(4, 2, 0));
        System.Console.WriteLine(somaRecursiva(4, 4));
        System.Console.WriteLine(somaDivsRecursivo(2));
        System.Console.WriteLine(inverteStringRecur("testando", 0, string.Empty));
        System.Console.WriteLine(gerSequencia(3));
    }

    static int multiplicaPorSoma(int a, int b, int c)
    {
        if (b == 0)
        {
            return c;
        }
        b--;
        c = c + a;
        return multiplicaPorSoma(a, b, c);
    }

    static int somaRecursiva(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        a++;
        b--;
        return somaRecursiva(a, b);
    }

    static double somaDivsRecursivo(int numDivisoes)
    {
        if (numDivisoes == 0)
        {
            return 0;
        }
        return 1.0 / numDivisoes + somaDivsRecursivo(numDivisoes - 1);
    }

    static string inverteStringRecur(string str, int cont, string result)
    {
        if (cont == str.Length)
        {
            return result;
        }

        result = result + str[str.Length - 1 - cont];
        cont++;
        string resultRecursivo = result;
        return inverteStringRecur(str, cont, resultRecursivo);
    }

    static int gerSequencia(int n)
    {
        if (n == 1 || n == 2)
        {
            return n;
        }
        return 2 * gerSequencia(n - 1) + 3 * gerSequencia(n - 2);
    }

    /*static int ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        if (m != 0 && n == 0)
        {
            return ackermann(m - 1, 1);
        }
        return ackermann(m-1, ackermann())
    }*/
}