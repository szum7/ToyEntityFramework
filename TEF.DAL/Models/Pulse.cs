namespace TEF.ConsoleApp.Models
{
    /// <summary>
    /// Dummy table for checking the DB connection.
    /// </summary>
    public class Pulse
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public override string ToString()
        {
            return $"{Id}-{Title}";
        }
    }
}
