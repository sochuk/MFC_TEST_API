using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCF_TEST_API.Models
{
    [Table("TR_BPKB", Schema = "dbo")]
    public class TrBpkb
    {

        [Key]
        [Column("AGREEMENT_NUMBER")]
        public string AgreementNumber { get; set; }
        [Column("BPKB_NO")]
        public string BpkbNo { get; set; }
        [Column("BANCH_ID")]
        public string BranchId { get; set; }
        [Column("BPKB_DATE")]
        public DateTime BpkbDate { get; set; }
        [Column("FAKTUR_NO")]
        public string FakturNo { get; set; }
        [Column("FAKTUR_Date")]
        public DateTime FakturDate { get; set; }
        [Column("LOCATION_ID")]
        public MstStorageLocation LocationId { get; set; }
        [Column("BPKB_DATE_IN")]
        public DateTime BpkbDateIn { get; set; }
    }
}

