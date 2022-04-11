using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroDeSeries.Models
{
    [Table("Series")]
    public class Series : Base
    {
        public Series()
        {
        }

        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public String Genero { get; set; }

        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public String Titulo { get; set; }

        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public int Ano { get; set; }


        public override string ToString()
        {
            return this.Titulo;
        }

    }
}
