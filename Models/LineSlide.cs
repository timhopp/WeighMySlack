namespace weighmyslack.Models
{
  public class LineSlide
  {
    public int Id { get; set; }
    public int ManufacturerId { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }

    public string Img { get; set; }
    public string ComponentType { get; set; }

    public string Material { get; set; }
    public decimal Weight { get; set; }
    public decimal WLL { get; set; }
    public decimal MBS { get; set; }
    public decimal WebbingWidth { get; set; }
    public string SliderType { get; set; }
    public decimal InnerWidth { get; set; }
    public decimal Price { get; set; }
  }

  public class LineSlideRigComponentViewModel : LineSlide
  {
    public int RigComponentId { get; set; }
  }

}