

public class Data
{
    // シングルトン
    public static readonly Data instance = new Data();

    // score
    int score = 0;
    // num
    int times = 0;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    public int Times
    {
        get { return times; }
        set { times = value; }
    }
}
