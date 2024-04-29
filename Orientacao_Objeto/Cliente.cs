// cliente herdada de Pessoa
internal class Cliente : Pessoa
{
    public int conta;
    public Cliente()
    {

    }
    public void DefinirConta(int conta)
    {
        this.conta = conta;
    }
    public void ImprimirCliente()
    {
        ImprimirPessoa();
        Console.WriteLine($"Conta do cliente: {this.conta}");
    }
}

