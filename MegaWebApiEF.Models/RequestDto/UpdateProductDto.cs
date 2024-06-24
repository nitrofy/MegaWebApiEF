using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaWebApiEF.Models.RequestDto
{
    public class UpdateProductDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Tags { get; set; }
    }
}
