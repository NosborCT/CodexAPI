namespace CodexAPI.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string titulo{ get; set; }

        // criando a relacao com a tabela autor 
        public AutorModel Autor { get; set; }
   

    }
}