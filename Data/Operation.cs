using System.ComponentModel.DataAnnotations;

namespace CrudAssignment.Data
{
    public class Operation
    {
        [Key]
        public int OperationID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }
        public string ImageData { get; set; }
        public string Device { get; set; }
    }
}
