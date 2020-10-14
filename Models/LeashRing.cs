namespace weighmyslack.Models
{
  public class LeashRing
  {
    public int Id { get; set; }
    public int ManufacturerId { get; set; }
    public string Name { get; set; }
    public string Img { get; set; }
    public string Manufacturer { get; set; }
    public string ComponentType { get; set; }
    public string Material { get; set; }
    public decimal Weight { get; set; }
    public decimal WLL { get; set; }
    public decimal MBS { get; set; }
    public decimal MaterialDiameter { get; set; }
    public decimal InnerDiameter { get; set; }
    public decimal OuterDiameter { get; set; }
    public decimal Price { get; set; }
  }

  public class RigComponentViewModel : LeashRing
  {
    public int RigComponentId { get; set; }
  }
}