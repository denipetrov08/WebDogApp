using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDogApp.Infrastructure.Data.Domain
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int DogId { get; set; }

        [ForeignKey(nameof(DogId))]
        public virtual Dog Dog { get; set; } = null!;

        [Required]
        public int BreedId { get; set; }

        [ForeignKey(nameof(BreedId))]
        public virtual Breed Breed { get; set; } = null!;
    }
}
