public class Matematicas
<<<<<<< HEAD
//hola
=======
/*Obtiene el máximo común divisor de dos números de forma recursiva, siendo a >b*/

>>>>>>> c2461697846fcd066abbd19dd85be0eec37a067b
{

public static int MaximoComunDivisor(int a, int b)
{
    if (b == 0) return a;
    else return MaximoComunDivisor(b,a%b);
}
}