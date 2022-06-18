using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Student_Management_System.Models
{
    [MetadataType(typeof(CourseMetadata))]
    public partial class Course
    {
        public class CourseMetadata
        {
            [DisplayName("Course Name")]
            public string course1 { get; set; }

            [DisplayName("Course Duration")]
            public Nullable<int> duration { get; set; }
        }
    }
}