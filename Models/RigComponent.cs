namespace weighmyslack.Models
{
  public class RigComponent
  {
    public int Id { get; set; }
    public int ComponentId { get; set; }
    public int RigId { get; set; }

    public string ComponentType { get; set; }

    public string UserId { get; set; }
  }
}