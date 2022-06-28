using bytebank_ADM.funcionarios;
using System;

      
            Console.WriteLine("Boas Vindas ao ByteBank Admnistração");

Funcionario pedro = new Funcionario(1);

pedro.Nome = "Pedro";
pedro.Cpf = "123456789";
pedro.Salario = 2000;

Console.WriteLine("Nome: " + pedro.Salario);
Console.WriteLine( "CPF: "+pedro.Cpf);
Console.WriteLine("Salário: "+ pedro.Salario);
Console.WriteLine("Bonificação:"+pedro.getBonificacao());
        
    

