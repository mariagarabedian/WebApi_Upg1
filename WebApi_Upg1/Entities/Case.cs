using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi_Upg1.Entities
{
    public partial class Case
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AdministratorId { get; set; }
        public DateTime CaseDate { get; set; }
        public DateTime? UpdateCaseDate { get; set; }
        public string CaseDescription { get; set; }
        public string CaseStatus { get; set; }

        public virtual Administrator Administrator { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
