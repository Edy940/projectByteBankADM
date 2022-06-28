using bytebank_ADM.funcionarios;
using System;

      
            Console.WriteLine("Boas Vindas ao ByteBank Admnistração");

Funcionario pedro = new Funcionario();

pedro.Nome = "Pedro";
pedro.Cpf = "123456789";
pedro.Salario = 2000;

Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine( "CPF: "+pedro.Cpf);
Console.WriteLine("Salário: "+ pedro.Salario);


Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "125555562";
paula.Salario = 5000;

Console.WriteLine("Bonificação:" + pedro.getBonificacao());
Console.WriteLine("Bonificação:" + paula.getBonificacao());





