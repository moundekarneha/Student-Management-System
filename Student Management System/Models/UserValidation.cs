using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Student_Management_System.Models
{
    [MetadataType(typeof(UsertMetadata))]
    public partial class Usert
    {
        public class UsertMetadata
        {
            [DisplayName("First Name")]
            public string fname { get; set; }

            [DisplayName("Last Name")]
            public string lname { get; set; }

            [DisplayName("User Name")]
            public string uname { get; set; }

            [DisplayName("Password")]
            public string pass { get; set; }
        }
    }
}