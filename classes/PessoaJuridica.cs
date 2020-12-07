namespace POO_Heranca.classes
{
    public class PessoaJuridica : Pessoa

    {
        public string nomeDaEmpresa;
        public string cnpj;
        public string inscricaoEstadual;
        public string cidade;
        public string estado;
        public string uf ; 
        public float faturamentoBruto;
     
        public bool ValidandoCNPJ(string documentos )
        {
            if(documentos != ""){
                return true;
            }
                return false;
        }
    }
}