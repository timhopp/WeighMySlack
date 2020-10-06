namespace weighmyslack.Models
{
  public class LineSlides
  {
    public int Id { get; set; }
    public string ManufacturerId { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }

    public string Material { get; set; }
    public int Weight { get; set; }
    public int WLL { get; set; }
    public int MBS { get; set; }
    public string WebbingWidth { get; set; }
    public string SliderType { get; set; }
    public int InnerWidth { get; set; }
    public int Price { get; set; }
  }
}