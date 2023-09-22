namespace SnakesAndLadders.Test;

[TestClass]
public class SnakesAndLaddersTests
{
    [TestMethod]
    public void TestIsGamePlayable()
    {
        Assert.AreEqual(Game.aGame().isGamePlayable(), "true");
    }

    [TestMethod]
    public void TestIsValid()
    {
        Assert.IsTrue(Game.aGame().isValid());
    }

    [TestMethod]
    public void TestPlay()
    {
        var player = "1";
        var result = Game.aGame().play(player);
        var expected = "Normal square reached!You 1 are on square 7" + Environment.NewLine + "Normal square reached by computer!You computer 2 are on square 6";

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestPlay2()
    {
        var player = "1";
        Game.aGame().play(player);
        var result = Game.aGame().play(player);
        var expected = "Normal square reached!You 1 are on square 19" + Environment.NewLine + "Normal square reached by computer!You computer 2 are on square 16";

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestPlay3()
    {
        var player = "1";
        Game.aGame().play(player);
        Game.aGame().play(player);
        var result = Game.aGame().play(player);
        var expected = "Normal square reached!You 1 are on square 47" + Environment.NewLine + "Normal square reached by computer!You computer 2 are on square 31";

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestPlay4()
    {
        var player = "1";
        Game.aGame().play(player);
        Game.aGame().play(player);
        Game.aGame().play(player);
        var result = Game.aGame().play(player);
        var expected = "Normal square reached!You 1 are on square 71" + Environment.NewLine + "Game over! Player 2 is the winner!";

        Assert.AreEqual(expected, result);
    }
}