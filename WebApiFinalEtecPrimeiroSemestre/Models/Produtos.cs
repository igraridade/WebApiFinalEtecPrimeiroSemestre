namespace WebApiFinalEtecPrimeiroSemestre.Models
{
    public class Produtos : Base
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }


        //Tipos de dados

        string nome = "etec"; //Tipo de referencia
        char letra = 'A';


        int valor = 10; //Números inteiros
        long valor1 = 10L;//Números inteiros 
        byte valorB = 127;//Números inteiros

        double valorD = 10.0;//Números reais
        float valorF = 10.0F;//Números reais 

        

    }
}




