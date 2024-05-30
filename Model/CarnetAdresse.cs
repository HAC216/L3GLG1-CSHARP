using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGestionAdress.Model
{
    [Table("Contact")]
    public class CarnetAdresse
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150), Required]
        public string PrenomNom { get; set; }

        [MaxLength(150), Required]
        public string Organisation { get; set; }

        [MaxLength(20), Required]
        public string Numero { get; set; }

        [MaxLength(150), Required]
        public string Email { get; set; }

        [MaxLength(250), Required]
        public string Adresse { get; set; }

        [MaxLength(150), Required]
        public string SiteWeb { get; set; }




    }
}
