public class Dice{
    public virtual int Roll(){
        return new Random().Next(6);
    }
}