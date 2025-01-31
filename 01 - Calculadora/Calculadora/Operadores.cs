public class Operadores
{

    double n1,n2;

    public void SolicitarNumero()
    {
        Console.Write("Digite um numero: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        n2 = Convert.ToDouble(Console.ReadLine());
    }
    public double Adicao()
    {
        SolicitarNumero();
        return n1 + n2;
    }

    public double Subtracao()
    {
        SolicitarNumero();
        return n1 - n2;
    }

    public double Divisao()
    {
        SolicitarNumero();
        if (n2 == 0)
            {
                Console.WriteLine("Erro, Divisao por zero.");
                return double.NaN;
            }
        else
        {
            return n1 / n2;
        }
            
    }
    public double Multiplicacao()
    {
        SolicitarNumero();
            return n1 * n2;
    }
}
