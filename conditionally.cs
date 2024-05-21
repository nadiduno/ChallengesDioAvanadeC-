//Descrição

//Uma nova feature para um sistema bancário foi analisada pela equipe de desenvolvimento e será uma das tarefas a serem trabalhadas durante a sprint, como desenvolvedor da empresa você recebeu os requisitos para a nova implementação que consiste em uma solução algorítmica que permita aos clientes realizarem saques em caixas eletrônicos. No entanto, existem algumas regras a serem seguidas para garantir que um saque possa ser realizado com sucesso.

//Regras do saque:

//- Cada cliente digitará o valor do seu saldoTotal de sua conta bancária e o valorSaque.
//- Um saque só pode ser realizado se o saldoDisponível na conta for igual ou superior ao valor solicitado.
//- Se o saldo for suficiente, o valor solicitado deve ser subtraído do saldo disponível, indicando que o saque foi realizado.

using System;

class Program
{
    static void Main(string[] args)
    {

        int saldoTotal = int.Parse(Console.ReadLine());
        

        int valorSaque = int.Parse(Console.ReadLine());
        
        //TODO: Criar as condições necessárias para impressão da saída, vide tabela de exemplos.

        if (valorSaque < saldoTotal)
        {
            int saldoDisponivel = saldoTotal - valorSaque;
            Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldoDisponivel}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
            
        }
    }
}
