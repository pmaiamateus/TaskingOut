namespace TaskingOutApp.Data.Models;

public class CheckTask
{
    public int Id { get; set; }
    public int Index { get; set; }
    public string Description { get; set; } = "";
    public bool IsChecked { get; set; } = false;
}
