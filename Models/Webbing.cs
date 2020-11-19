namespace weighmyslack.Models
{
  public class Webbing
  {
    public int Id { get; set; }
    public string ManufacturerId { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string ComponentType { get; set; }
    public string Img { get; set; }
    public string Material { get; set; }
    public decimal Width { get; set; }
    public decimal Weight { get; set; }
    public decimal WLL { get; set; }
    public decimal MBS { get; set; }
    public decimal Thickness { get; set; }

    public decimal Elongation { get; set; }

    public int Price { get; set; }

  }

  public class WebbingRigComponentViewModel : Webbing
  {
    public int RigComponentId { get; set; }
  }
}

