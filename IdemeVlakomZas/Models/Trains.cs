using System.ComponentModel.DataAnnotations;

namespace IdemeVlakomZas.Models
{
    public class Trains
    {
        [Key]
        public int vlak_id { get; set; }
        public string Vlak { get; set; }

        public int Vzdialenost_k_cielu { get; set; }

        public int Meskanie { get; set; }

    }
}
