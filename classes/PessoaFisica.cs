namespace POO_Heranca.classes
{
    public class PessoaFisica : Pessoa
    {
        public string cidade;
        public string uf;
        public string enderco;
        public string cpf;
        public string rg;
        public bool ValidarCPF(string documento){


            if(documento!= ""){
                return true ;
            }

                return false ;


        }
        
        
     
    }
}