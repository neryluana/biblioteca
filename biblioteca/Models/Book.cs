using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Biblioteca.Models
{
    [Table("Books")]
    public class Book
    {
        // criando entidade
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        // colocando um nome na tabela
        [Column("Book_Name")]
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public Publisher? Publisher { get; set; }



        public ICollection<Author>? Authors { get; set; }





    }
}
