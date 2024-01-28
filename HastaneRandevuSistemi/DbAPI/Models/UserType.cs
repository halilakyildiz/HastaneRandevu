using System;
using System.Collections.Generic;

namespace DbAPI.Models
{
    public partial class UserType
    {
        public int UserTypeId { get; set; }
        public string? TypeName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
