using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkKisaltma.Models
{
    public class TBLLink
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [MaxLength(300)]
        public string UzunLink { get; set; }
        [MaxLength(10)]
        public string KisaLink { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;
        public int NumberOfClicks { get; set; } = 0;
    }
}
