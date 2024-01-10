using System.ComponentModel.DataAnnotations.Schema;

namespace Apicompassdois.Model
{

    [Table("compass")]
    public class Compass
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("compass_name")]
        public string? Name { get; set; } 

        [Column("compass_url")]
        public string? Compass_URL { get; set; } 

        [Column("compass_destiny")]
        public string? Destiny { get; set; }  

        [Column("compass_price")]
        public decimal Price { get; set; }



    }
}
