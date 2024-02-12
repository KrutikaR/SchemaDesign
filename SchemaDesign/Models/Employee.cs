using System.ComponentModel.DataAnnotations;

namespace SchemaDesign.Models
{
    public class Employee
    {
        [Key]      
        public int EmpID { get; set; }
        public required string Name { get; set; }
        public required string Department { get; set; }
        public bool IsWorking { get; set; }
        public DateTime? DateOfBirth { get; set; }
        
        ///<summery>
        ///This is summery
            ///</summery>
        public required string Description { get; set; }

    }
}
