using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeoLanches.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [StringLength(100,ErrorMessage = "Tamanho máximo permitido 100 caracteres.")]
    [Required(ErrorMessage = "O Nome é obrigatório.")]
    [Display(Name = "Nome")]
    public string CategoriaNome { get; set; }

    [StringLength(100, ErrorMessage = "Tamanho máximo permitido 200 caracteres.")]
    [Required(ErrorMessage = "A Descrição é obrigatória.")]
    [Display(Name = "Descição")]
    public string Descricao { get; set; }
    public List<Lanche> Lanches { get; set;}
}
