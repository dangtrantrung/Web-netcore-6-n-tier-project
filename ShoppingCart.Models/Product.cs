using System.Component.DataAnotation;
using System.Component;

namespace ShoppingCart.Models;

public class Product
{
 [Key]
 public int Id{get;set;}
 [Required]
 public string Name {get;set;}
 [Required]
 public string Description {get;set;}
 [Required]
 public double Price {get;set;}
 [ValidateNever]
 public string ImgUrl {get;set;}
 [ValidateNever]
 public Category Category {get;set;}

}
