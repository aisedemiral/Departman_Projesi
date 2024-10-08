using System.ComponentModel.DataAnnotations;

namespace Core_Departmant.Models;

public class Personel
{
    [Key]
    public int id { get; set; }
    public string personelAd { get; set; }
    public string personelSoyad { get; set; }
    public string sehir { get; set; }
    public departmanlar depart { get; set; }  

}