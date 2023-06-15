using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminAPI.Models.UserRoles
{
    public class User_
    {
        [Key]
        public int UserId {get; set;}
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
          

        // Foreign key   
        [Display(Name = "Role")]  
        public virtual int RoleId { get; set; }  
        
        [ForeignKey("RoleId")]  
        public virtual Role Roles { get; set; }


    }
}