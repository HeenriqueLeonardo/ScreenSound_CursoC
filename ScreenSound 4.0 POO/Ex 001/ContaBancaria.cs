using System.Xml;

class ContaBancaria
{
    public int NumeroId;
    public string NomeTitular;
    public float Saldo;
    public int Senha;

   public void ConsultarExtrato()
    {
        Console.Write("Digite sua Senha:");
        int acesso = int.Parse(Console.ReadLine());
        if (Senha == acesso)
        {
            Console.WriteLine($"Titular: {NomeTitular}\nSaldo: {Saldo:f}");
        }
        else
        {
            Console.WriteLine("Senha Incorreta!");
        }
    }
}

