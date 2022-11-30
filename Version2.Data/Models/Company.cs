using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Version2.Data.Models
{
    public class GetCompany
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
    public class Company : Entity, IEntity
    {
        public string Name { get; set; }
        
    }
    public class CompanyDto : Entity, IEntity
    {
        [Required]
        public string Name { get; set; }

    }
    public class CreateorEditCompanyDto : Entity, IEntity
    {
        public string Name { get; set; }

    }
}
