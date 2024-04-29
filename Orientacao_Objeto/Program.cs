Cliente objCliente = new Cliente();
Funcionario objFuncionario = new Funcionario();

#region Cliente
Cliente CriaCliente()
{
    Cliente temp_cliente = new Cliente();
    Console.WriteLine("Informe o Nome do cliente:");
    temp_cliente.DefinirNome(Console.ReadLine());

    Console.WriteLine("Informe o Endereço do cliente:");
    temp_cliente.DefinirEndereco(Console.ReadLine());

    Console.WriteLine("Informe o Sexo do cliente:");
    temp_cliente.DefinirSexo(Console.ReadLine());

    Console.WriteLine("Informe o Telefone do cliente:");
    temp_cliente.DefinirTelefone(Console.ReadLine());

    Console.WriteLine("Informe o Salário do cliente:");
    temp_cliente.DefinirSalario(float.Parse(Console.ReadLine()));

    Console.WriteLine("Informe a data de nascimento do cliente:");
    temp_cliente.DefinirNascimento(DateOnly.Parse(Console.ReadLine()));

    Console.WriteLine("Informe a Conta do cliente:");
    temp_cliente.DefinirConta(int.Parse(Console.ReadLine()));
    return temp_cliente;
}
objCliente = CriaCliente();
objCliente.ImprimirCliente();
#endregion

Console.WriteLine("\n\n");

#region Funcionario
Funcionario CriaFuncionario()
{
    Funcionario temp_funcionario = new Funcionario();
    Console.WriteLine("Informe o Nome do funcionário:");
    temp_funcionario.DefinirNome(Console.ReadLine());

    Console.WriteLine("Informe o Endereço do funcionário:");
    temp_funcionario.DefinirEndereco(Console.ReadLine());

    Console.WriteLine("Informe o Sexo do funcionário:");
    temp_funcionario.DefinirSexo(Console.ReadLine());

    Console.WriteLine("Informe o Telefone do funcionário:");
    temp_funcionario.DefinirTelefone(Console.ReadLine());

    Console.WriteLine("Informe o Salário do funcionário:");
    temp_funcionario.DefinirSalario(float.Parse(Console.ReadLine()));

    Console.WriteLine("Informe a data de nascimento do funcionário:");
    temp_funcionario.DefinirNascimento(DateOnly.Parse(Console.ReadLine()));

    Console.WriteLine("Informe o Cargo do funcionário:");
    temp_funcionario.DefinirCargo(Console.ReadLine());

    Console.WriteLine("Informe o Código do funcionário:");
    temp_funcionario.DefinirCodigo(int.Parse(Console.ReadLine()));

    return temp_funcionario;
}
objFuncionario = CriaFuncionario();
objFuncionario.ImprimirFuncionario();
#endregion

