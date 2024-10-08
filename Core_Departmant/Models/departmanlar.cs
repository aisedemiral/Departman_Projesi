using System.ComponentModel.DataAnnotations;

namespace Core_Departmant.Models;

public class departmanlar
{
    public object departmanad;

    [Key]
    public int id { get; set; }
    public string departmanAd { get; set; }

    public List<Personel> Personels { get; set; }
    
} 
