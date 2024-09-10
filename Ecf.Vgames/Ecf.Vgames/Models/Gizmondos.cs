using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Ecf.Vgames.Models
{
    public class Gizmondos
    {
        public int Id { get; set; }

        [ForeignKey("Publisher")]
        [Required]
        [Column("publisherId")]
        public int PublisherId { get; set; }

        [JsonIgnore]
        public Publisher? Publisher { get; set; }

        [Required]
        [Column("game")]
        public string Game { get; set; }
        [Required]
        [Column("year")]
        public int Year {  get; set; }
        [Required]
        [Column("dev")]
        public string Dev {  get; set; }

        
    }
}
