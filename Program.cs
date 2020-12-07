using System;
using POO_Heranca.classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        { 
            PessoaFisica pf =new PessoaFisica();
            
            pf.nome = "Tadeu"; 
            Console.WriteLine(pf.DarBoasVindas(pf.nome));
            pf.rg = "34944488817";
            Console.WriteLine("Digite o seu CPF");
            pf.cpf = Console.ReadLine();
            pf.cidade = "Sao Paulo";
            pf.uf = "SP";
            Console.WriteLine(pf.ValidarCPF(pf.cpf));
            
           PessoaJuridica pj = new PessoaJuridica();
           pj.nomeDaEmpresa = "Doceria Senhora Dona";
           pj.cidade = "Sao apulo";
           Console.WriteLine("Digite o CNPJ");
           pj.cnpj = Console.ReadLine();
           pj.estado = "Sao paulo";
           pj.uf ="SP";
           Console.WriteLine(pj.ValidandoCNPJ(pj.cnpj));
                
                     
            
        }
    }
}
