using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorLib.Model
{
    public class Categories
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage = "Category  name is required")]
        public string Name { get; set; }
    }
}
