namespace weighmyslack.Models
{
  public class Weblock
  {
    public int Id { get; set; }
    public int ManufacturerId { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string Material { get; set; }
    public int Weight { get; set; }
    public int WLL { get; set; }
    public int MBS { get; set; }
    public string AnchorConnection { get; set; }
    public string WebbingConnection { get; set; }
    public string WebbingWidth { get; set; }
    public int DiverterDiameter { get; set; }
    public int Efficiency { get; set; }
    public int Price { get; set; }

  }
}