namespace weighmyslack.Models
{
  public class WebbingGrip
  {

    public int Id { get; set; }
    public int ManufacturerId { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }

    public string Img { get; set; }

    public string ComponentType { get; set; }
    public string Material { get; set; }
    public int Weight { get; set; }
    public decimal WLL { get; set; }
    public decimal MBS { get; set; }
    public string CommonSlipThreshold { get; set; }
    public string ConnectionType { get; set; }
    public string CompatibleWebbingWidth { get; set; }
    public decimal Price { get; set; }
  }

  public class WebbingGripRigComponentViewModel : WebbingGrip
  {
    public int RigComponentId { get; set; }
  }
}