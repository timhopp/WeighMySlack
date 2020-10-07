namespace weighmyslack.Models
{
  public class LeashRing
  {
    public int Id { get; set; }
    public string ManufacturerId { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string Material { get; set; }
    public int Weight { get; set; }
    public int WLL { get; set; }
    public int MBS { get; set; }
    public int MaterialDiameter { get; set; }
    public int InnerDiameter { get; set; }
    public int OuterDiameter { get; set; }
    public int Price { get; set; }
  }

  public class RigLeashRingsViewModel : LeashRing
  {
    public int RigLeashRingsId { get; set; }
  }
}