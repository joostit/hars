namespace BrrrBayBay.HARs.dataModel
{

public class RaceResult
{
    // Methods
    public RaceResult(int id, int userId, int roundId, int gameID, int timeMs)
    {
        this.ID = id;
        this.UserId = userId;
        this.RoundId = roundId;
        this.TimeMs = timeMs;
        this.GameID = gameID;
    }

    // Properties
    public int GameID { get; set; }

    public int ID { get; set; }

    public int RoundId { get; set; }

    public int TimeMs { get; set; }

    public int UserId { get; set; }
}

}
