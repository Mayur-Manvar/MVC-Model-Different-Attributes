using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace MVCDifferentAttributes.Models
{
    [MetadataType(typeof(EmployeeMetadata))]
    [DisplayName("Full Name")]
    public partial class Employee
    {

    }

    public class EmployeeMetadata
    {
        //[DisplayAttribute(Name = "Full Name")]
        //[Display(Name ="Full Name")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        //To get only the date part in a datetime data type
        //[DisplayFormat(DataFormatString = "{0:d}")]
        //[DisplayFormatAttribute(DataFormatString="{0:d}")]

        //To get time in 24 hour notation
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]

        //To get time in 12 hour notation with AM PM
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}")]
        public DateTime? HireDate { get; set; }

        // If gender is NULL, "Gender not specified" text will be displayed.
        [DisplayFormat(NullDisplayText = "Gender not specified")]
        public string Gender { get; set; }

        //If you don't want to display a column use ScaffoldColumn attribute.
        //This only works when you use @Html.DisplayForModel() helper
        [DataType(DataType.Currency)]
        [ScaffoldColumn(true)]
        public int? Salary { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DataType(DataType.Url)]
        [UIHint("OpenInNewWindow")]
        //So, UIHint attribute is used to specify the name of the template to use to display the data field.
        public string PersonalWebSite { get; set; }
    }
}