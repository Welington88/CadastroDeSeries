using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeSeries.Models
{
    public abstract class Base
    {
        [Key]
        public int Codigo { get; protected set; }
    }
}
