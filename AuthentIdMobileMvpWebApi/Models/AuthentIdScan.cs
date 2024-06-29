using System.ComponentModel.DataAnnotations;

namespace AuthentIdMobileMvpWebApi.Models
{
    public class AuthentIdScan
    {
        [Key]
        public int Id { get; set; }
        public DateTime ScanDate { get; set; }
        public decimal ScanLatitude { get; set; }
        public decimal ScanLongitude { get; set; }
        public int UserId { get; set; }
        public int AgentId { get; set; }

    }
}
