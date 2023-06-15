using System.ComponentModel.DataAnnotations;
namespace AdminAPI.Models.UserRoles
{
    public class Role
    {
        [Key]
     public int RoleId { get; set; }
    public string RolName { get; set;}

    

 }
}