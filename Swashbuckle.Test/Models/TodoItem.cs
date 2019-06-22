using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Swashbuckle.Test.Models
{
    public class TodoItem
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
