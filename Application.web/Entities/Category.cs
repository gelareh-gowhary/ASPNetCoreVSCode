using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Application.web.Entities
{
    [Table("MyCategory",Schema ="Catalog")]
    public class Category(int id , string name ,string description)
    {
        // public Category(int id , string name ,string description)
        // {
        //     Id=id;
        //     Name=name;
        //     Description=description;
        // }
        public int Id{get;set;}=id;
        [Required(ErrorMessage ="please insert a value ")]
        public string Name { get; set; }=name;
        public string Description { get; set; }=description;
        public List<string> Tag { get; set; }=new();
        
        
        
        
        
        
    }
}