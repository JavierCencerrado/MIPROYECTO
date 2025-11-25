public class Matematicas
/*Obtiene el máximo común divisor de dos números de forma recursiva, siendo a >b*/

{

public static int MaximoComunDivisor(int a, int b)
{
    if (b == 0) return a;
    else return MaximoComunDivisor(b,a%b);
}
}