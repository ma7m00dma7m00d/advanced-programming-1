namespace Lecture01.Test;

public class UnitTest1
{
    private const string PlayingMusic = "Playing music.\n";
    private const string PlayingVideo = "Playing video.\n";

    [Fact]
    public void Test1()
    {
        StringWriter sw = new StringWriter();
        Console.SetOut(sw);

        MIDIPlayer player1 = new MIDIPlayer();
        MIDIPlayer player2 = new VideoPlayer();
        player1.Play();
        Assert.Equal(PlayingMusic, sw.ToString());
        player2.Play();
        Assert.Equal(PlayingMusic + PlayingVideo, sw.ToString());
    }
}
