using static System.Console;

class Lista
{
    public void mediaLista()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        double media = numeros.Average();
        WriteLine("La media es: " + media);
    }
}