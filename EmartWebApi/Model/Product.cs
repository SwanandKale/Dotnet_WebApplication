namespace EmartWebApi.Model;
using System.ComponentModel.DataAnnotations;
public class Product
{
    public int Id{get;set;}

    [Required]
    public string? Name{get;set;}

    [Required]
    public double Price{get;set;}

    public Product(int id,string name,double price)
    {
        this.Id=id;
        this.Name=name;
        this.Price=price;
    }
} 