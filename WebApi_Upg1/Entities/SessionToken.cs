using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebApi_Upg1.Entities
{
    public partial class SessionToken
    {
        
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdminId { get; set; }


        // ändra till string och la till spec för Db, funkade inte annars
        [Required]
        [Column(TypeName = "varbinary(max)")]
        public string AccessToken { get; set; }
    }
}
