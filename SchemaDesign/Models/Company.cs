using System.ComponentModel.DataAnnotations;

namespace SchemaDesign.Models
{
    public class Company
    {
        [Key] public int CompanyId { get; set; }
        public required string Name { get; set; }
    }
}
