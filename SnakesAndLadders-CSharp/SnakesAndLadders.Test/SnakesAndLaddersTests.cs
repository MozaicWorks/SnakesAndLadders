namespace SnakesAndLadders.Test;

[TestClass]
public class SnakesAndLaddersTests
{
    [TestInitialize]
    public void Init()
    {
        Game.gameInstance = null;
    }

    [TestMethod]
    public void TestIsGamePlayable()
    {
        Assert.AreEqual("true", Game.aGame().isGamePlayable());
    }

    [TestMethod]
    public void TestIsValid()
    {
        Assert.IsTrue(Game.aGame().isValid());
    }

    [TestMethod]
    public void TestPlay()
    {
        Game.aGame().dice = new DiceStub(3);
        var player = "1";

        AssertPositionMessage(7, 7, Game.aGame().play(player));
        AssertPositionMessage(13, 13, Game.aGame().play(player));
   }


    [TestMethod]
    public void TestStatus()
    {
        Game.aGame().dice = new DiceStub(3);
        var player = "1";

        Game.aGame().play(player);

        var status = "Players positions: player 0 is on 1square, " + Environment.NewLine +
 "player 1 is on 7square, " + Environment.NewLine +
 "player 2 is on 7square, " + Environment.NewLine +
 "player 3 is on 1square, " + Environment.NewLine;

        Assert.AreEqual(status, Game.aGame().status());
    }

    public void AssertPositionMessage(int expectedPlayer1Position, int expectedComputer2Position, String actual)
    {
        var expected = $"Normal square reached!You 1 are on square {expectedPlayer1Position}{Environment.NewLine}Normal square reached by computer!You computer 2 are on square {expectedComputer2Position}";

        Assert.AreEqual(expected, actual);
    }
}