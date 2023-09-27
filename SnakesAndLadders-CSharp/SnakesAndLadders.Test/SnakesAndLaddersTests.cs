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
    public void TestPlayDice1()
    {
        Game.aGame().dice = new DiceStub(1);
        var player = "1";

        AssertNormalSquareMessage(3, 3, Game.aGame().play(player));
        AssertLadderMessage(7, 7, Game.aGame().play(player));
        AssertLadderMessage(27, 27, Game.aGame().play(player));
        AssertNormalSquareMessage(29, 29, Game.aGame().play(player));
        AssertNormalSquareMessage(31, 31, Game.aGame().play(player));
        AssertNormalSquareMessage(33, 33, Game.aGame().play(player));
        AssertNormalSquareMessage(35, 35, Game.aGame().play(player));
        AssertGameOverMessage(37, 37, Game.aGame().play(player));
    }

    [TestMethod]
    public void TestPlayDice2()
    {
        Game.aGame().dice = new DiceStub(2);
        var player = "1";

        AssertLadderMessage(7, 7, Game.aGame().play(player));
        AssertNormalSquareMessage(11, 11, Game.aGame().play(player));
        AssertNormalSquareMessage(15, 15, Game.aGame().play(player));
        AssertNormalSquareMessage(19, 19, Game.aGame().play(player));
        AssertNormalSquareMessage(23, 23, Game.aGame().play(player));
        AssertNormalSquareMessage(27, 27, Game.aGame().play(player));
        AssertNormalSquareMessage(31, 31, Game.aGame().play(player));
        AssertNormalSquareMessage(35, 35, Game.aGame().play(player));
        AssertGameOverMessage(39, 39, Game.aGame().play(player));
   }


    [TestMethod]
    public void TestPlayDice3()
    {
        Game.aGame().dice = new DiceStub(3);
        var player = "1";

        AssertNormalSquareMessage(7, 7, Game.aGame().play(player));
        AssertNormalSquareMessage(13, 13, Game.aGame().play(player));
        AssertNormalSquareMessage(19, 19, Game.aGame().play(player));
        AssertLadderMessage(35, 35, Game.aGame().play(player));
        AssertGameOverMessage(41, 41, Game.aGame().play(player));
    }

    [TestMethod]
    public void TestPlayDice4()
    {
        Game.aGame().dice = new DiceStub(4);
        var player = "1";

        AssertLadderMessage(27, 27, Game.aGame().play(player));
        AssertNormalSquareMessage(35, 35, Game.aGame().play(player));
        AssertGameOverMessage(43, 43, Game.aGame().play(player));
   }

    [TestMethod]
    public void TestPlayDice5()
    {
        Game.aGame().dice = new DiceStub(5);
        var player = "1";

        AssertNormalSquareMessage(11, 11, Game.aGame().play(player));
        AssertNormalSquareMessage(21, 21, Game.aGame().play(player));
        AssertNormalSquareMessage(31, 31, Game.aGame().play(player));
        AssertGameOverMessage(41, 41, Game.aGame().play(player));
   }

    [TestMethod]
    public void TestPlayDice6()
    {
        Game.aGame().dice = new DiceStub(6);
        var player = "1";

        AssertNormalSquareMessage(13, 13, Game.aGame().play(player));
        AssertLadderMessage(35, 35, Game.aGame().play(player));
        AssertGameOverMessage(47, 47, Game.aGame().play(player));
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

    public void AssertNormalSquareMessage(int expectedPlayer1Position, int expectedComputer2Position, String actual)
    {
        var expected = $"Normal square reached!You 1 are on square {expectedPlayer1Position}{Environment.NewLine}Normal square reached by computer!You computer 2 are on square {expectedComputer2Position}";

        Assert.AreEqual(expected, actual);
    }

    public void AssertLadderMessage(int expectedPlayer1Position, int expectedComputer2Position, String actual)
    {
        var expected = $"Ladder reached!You lucky player!You 1 are on square {expectedPlayer1Position}{Environment.NewLine}Ladder reached!You lucky computer player!You computer 2 are on square {expectedComputer2Position}";

        Assert.AreEqual(expected, actual);
    }

    public void AssertGameOverMessage(int expectedPlayer1Position, int expectedComputer2Position, String actual)
    {
        var expected = $"Normal square reached!You 1 are on square {expectedPlayer1Position}{Environment.NewLine}Game over! Player 2 is the winner!";

        Assert.AreEqual(expected, actual);
    }


}