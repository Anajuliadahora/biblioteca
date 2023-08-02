using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;



namespace biblioteca.Models

{

    //nome da tabela 

    [Table("Publishers")]

    public class Publisher

    {

        public int Id { get; set; }

        [Required]

        [StringLength(50)]



        //nome da coluna 

        [Column("PublisherName")]

        public string? Name { get; set; }

        [MaxLength(80), MinLength(4)]

        public string? Site { get; set; }



    }

}


