using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Student_Management_System.Models
{
    [MetadataType(typeof(BatchMetadata))]
    public partial class Batch
    {
        public class BatchMetadata
        {
            [DisplayName("Batch Name")]
            public string batch1 { get; set; }

            [DisplayName("Batch Year")]
            public string yr { get; set; }

        }
    }
}