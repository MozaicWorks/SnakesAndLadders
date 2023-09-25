public class DiceStub : Dice{
    private int rollValue;

    public DiceStub(int rollValue){
        this.rollValue = rollValue;
    }

    public override int Roll(){
        return this.rollValue;
    }
}