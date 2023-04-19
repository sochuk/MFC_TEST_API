using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCF_TEST_API.Models
{
    [Table("MST_STORAGE_LOCATION", Schema = "dbo")]
    public class MstStorageLocation
    {

        [Key]
        [Column("LOCATION_ID")]
        public string LocationId { get; set; }
        
        [Column("LOCATION_NAME")]
        public string LocationName { get; set; }
    }
}


