#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurvey_Validations.Models;
    public class User
{
    [Required]
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
    [Display(Name = "Your Name")]
    public string Name {get;set;}

[Required]
[Display(Name = "Dojo Location")]
    public string Location {get;set;}

    [Required]
    [Display(Name = "Favorite Language")]
    public string FavLanguage {get;set;}

[MinLength(20, ErrorMessage = "Comment must be at least 20 characters")]
    public string Comment {get;set;}
}