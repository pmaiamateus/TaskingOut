namespace TaskingOutApp.Data.Models;

#nullable enable
public class Checklist
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public List<CheckTask> Checks { get; set; } = new();
    public int Total { get => Checks.Count(c => c.IsHidden == false); }
    public int Checkeds { get => Checks.Count(c => c.IsChecked == true && c.IsHidden == false); }
    public int Hiddens { get => Checks.Count(c => c.IsHidden == true); }
    public double Progress { get => (Checkeds*100/Total); }
    public void RearrangeCheckIndexes()
    {
        foreach (var check in Checks)
        {
            check.Index = Checks.IndexOf(check);
        }
    }
}
