using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Pessoa
//{
public class Pessoa
{
    public string Nome;
    public string Sobrenome;
    public int Idade;
    public string Telefone;
    public string Celular;
    public string Email;
    public Pessoa() // método construtor
    {

    }
    public string DefinirNome()
    {
        Console.WriteLine("Informe o nome desejado:");
        return Console.ReadLine();
    }
    public string DefinirSobrenome()
    {
        Console.WriteLine("Informe o Sobrenome:");
        return Console.ReadLine();
    }
    public int DefinirIdade()
    {
        Console.WriteLine("Informe a sua idade:");
        return int.Parse(Console.ReadLine());
    }
    public void DefinirTelefone(string telefone)
    {
        this.Telefone = telefone;
    }
    public void DefinirCelular(string celular)
    {
        this.Celular = celular;
    }
    public void DefinirEmail(string email)
    {
        this.Email = email;
    }
    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}", this.Nome);
        Console.Write($" {Sobrenome}", this.Sobrenome);
        Console.WriteLine($"Idade: {this.Idade}");
        Console.WriteLine($"Telefone: {this.Telefone}");
        Console.WriteLine($"Celular: {this.Celular}");
        Console.WriteLine($"Email: {this.Email}");
        Console.WriteLine();
    }
}
