using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFirstCallOfEntites
{
    [Table("Paragraphe")]
    class Paragraph
    {
        [Key]
        public int Id { get; set; }

        [Column("Titre")]
        public string Title { get; set; }
    }
}
