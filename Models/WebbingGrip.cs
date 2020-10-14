namespace weighmyslack.Models
{
  public class WebbingGrip
  {

    public int Id { get; set; }
    public string ManufacturerId { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }

    public string ComponentType { get; set; }
    public string Material { get; set; }
    public int Weight { get; set; }
    public int WLL { get; set; }
    public int MBS { get; set; }
    public string CommonSlipThreshold { get; set; }
    public string ConnectionType { get; set; }
    public string CompatibleWebbingWidth { get; set; }
    public int Price { get; set; }
  }
}