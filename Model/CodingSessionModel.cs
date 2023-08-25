namespace CodingTracker.Model;

internal class CodingSessionModel
{
    public int Id { get; set; }

    // All DateTime(s) will be converted to string when put into db
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public TimeSpan Duration => EndTime - StartTime;
}
