using System.ComponentModel.DataAnnotations;

namespace ImpectionAPI.Models
{
    public class Inspection
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Stauts { get; set; } = string.Empty;


        [StringLength(200)]
        public string Comment { get; set; } = string.Empty;

        public int InspectionId { get; set; }

        public InspectionType? InspectionType { get; set; }
    }
}
