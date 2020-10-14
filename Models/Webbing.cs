namespace weighmyslack.Models
{
  public class Webbing
  {
    public int Id { get; set; }
    public string ManufacturerId { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string ComponentType { get; set; }
    public string Type { get; set; }
    public string Img { get; set; }
    public string Material { get; set; }
    public int Width { get; set; }
    public int Weight { get; set; }
    public int WLL { get; set; }
    public int MBS { get; set; }
    public int Thickness { get; set; }

    public string Elongation { get; set; }

    public int Price { get; set; }

  }

  //NOTE Do I want a relationship like this? If others can add gear yes...if only me then no? 

  // public class VaultKeepViewModel : Keep
  // {
  //     public int VaultKeepId { get; set; }
  // }
}

