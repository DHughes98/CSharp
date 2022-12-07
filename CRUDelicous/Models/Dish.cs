#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicous.Models;
public class Dish
{
    [Key]
    public int DishID {get;set;}
    [Required]
    public string Name {get;set;}
    [Required]
    public string Chef {get;set;}
    [Required]
    [Range(0,6)]
    public string Tastines {get;set;}
    [Required]
    [Range(1,Int32.MaxValue)]
    public int Calories {get;set;}
    [Required]
    public string Desciption {get;set;}
    public DateTime  CreatedAt{get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;}= DateTime.Now;
    
}