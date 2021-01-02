using CourseLibrary.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescription(ErrorMessage = "Title must be different from Description")]
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "Title is required!")]
        [MaxLength(100, ErrorMessage = "Max lenght is 100!")]
        public string Title { get; set; }

        [MaxLength(1500, ErrorMessage = "Max lenght is 1500!")]
        public virtual string Description { get; set; }
    }
}
