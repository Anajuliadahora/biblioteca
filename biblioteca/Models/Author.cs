using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;



namespace biblioteca.Models

{

    [Table("Authors")]

    public class Author

    {



        public int Id { get; set; }

        [Required]

        [StringLength(50)]



        //nome da coluna 

        [Column("AuthorName")]

        public string? Name { get; set; }



    }

}


