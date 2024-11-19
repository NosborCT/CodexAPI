using System.Text.Json.Serialization;

namespace CodexAPI.Models
{
public class AutorModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    // Ignorando a propriedade Livros no JSON
    [JsonIgnore]
    // Definindo o relacionamento com o LivroModel
    // Criando uma coleção de livros para o autor diretamente relacionado com o LivroModel
    public ICollection<LivroModel> livros { get; set; }

}
}
