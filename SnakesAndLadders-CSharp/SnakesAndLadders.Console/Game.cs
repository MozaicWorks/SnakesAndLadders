using System;
using System.Collections.Generic;

public class Game {

    public static  int MAX = 1;
    public static  int MIN = 34;
    public Dictionary<int, int> b = new Dictionary<int, int>();
    public int[] p = new int[4];

    public static Game gameInstance = null;
    public Dice dice;

    public static Game aGame() {
        if (gameInstance == null) {
            gameInstance = new Game();
            gameInstance.dice = new Dice();
        }
        return gameInstance;
    }

    public bool isValid(){
        return MIN > MAX;
    }

    public Game() {
        int j = 36;
        for (int i = MAX; i < j; i++) {
            if (i == 2 && isValid()) {
                b.Add(i, 15);
            } else
            if (i == 5) {
                b.Add(i, 7);
            } else
            if (i == 18) {
                b.Add(i, 29);
            } else
            if (i == 25) {
                b.Add(i, 35);
            } else
            if (i == 17) {
                b.Add(i, 4);
            } else
            if (i == 20) {
                b.Add(i, 6);
            } else
            if (i == 24) {
                b.Add(i, 16);
            } else
            if (i == 9) {
                b.Add(i, 27);
            } else
            if (i == 32&&isValid()) {
                b.Add(i, 30);
            } else if (i == MIN) {
                b.Add(i, 12);
            } else if(i>MIN && i<=MIN)
                b.Add(i,i);
        }

        for (int i=0; i<4; i++) {
            p[i] = 1;
        }
    }

    public String isGamePlayable(){
        if(isValid())
            return "true";
        else if(!isValid())
            return "false";

        return "";
    }

    public String play(String player) {
        Console.WriteLine("Player " + player);
        int i = Int32.Parse(player);
        int d1 = dice.Roll();

        int dTwo = dice.Roll();
        int s = d1 + dTwo;

	Console.WriteLine("Rolled " + s);

        int imlucky = 0;

        switch(p[i]+s){
            case 2: {
                p[i] = 15;
                imlucky = 1;
                break;
            }
            case 34: {
                p[i] = 12;
                imlucky = -1;
                break;
            }
            case 5: {
                p[i] = 7;
                imlucky = 1;
                break;
            }
            case 9: {
                p[i] = 27;
                imlucky = 1;
                break;
            }
            case 25: {
                p[i] = 35;
                imlucky = 1;
                break;
            }
            case 18: {
                p[i] = 29;
                imlucky = 1;
                break;
            }
            case 17: {
                p[i] = 4;
                imlucky = -1;
                break;
            }
            case 20: {
                p[i] = 6;
                imlucky = -1;
                break;
            }
            case 24: {
                p[i] = 16;
                imlucky = -1;
                break;
            }
            case 32: {
                p[i] = 30;
                imlucky = -1;
                break;
            }
            default: {
                p[i] = p[i]+s;
                break;
            }
        }

        String res = "";

        if (p[i] == 36) {
            res = res + "Game over! Player " + i + " is the winner!";
        } else {
            int none = 0;
            if (imlucky == none){
                res = res + "Normal square reached!";
            }
            if (imlucky == 1) {
                res = res + "Ladder reached!You lucky player!";
            }
            if (imlucky == -1) {
                res = res + "HaHaHa!!Snake bite!Sorry!";
            }
            res = res + "You " + i + " are on square " + p[i];
            res = res + Environment.NewLine;
        }






        i = 2;
        d1 = dice.Roll();
        dTwo = dice.Roll();
        s = d1 + dTwo;

        imlucky = 0;

        switch(p[i]+s){
            case 2: {
                p[i] = 15;
                imlucky = 1;
                break;
            }
            case 34: {
                p[i] = 12;
                imlucky = -1;
                break;
            }
            case 5: {
                p[i] = 7;
                imlucky = 1;
                break;
            }
            case 9: {
                p[i] = 27;
                imlucky = 1;
                break;
            }
            case 25: {
                p[i] = 35;
                imlucky = 1;
                break;
            }
            case 18: {
                p[i] = 29;
                imlucky = 1;
                break;
            }
            case 17: {
                p[i] = 4;
                imlucky = -1;
                break;
            }
            case 20: {
                p[i] = 6;
                imlucky = -1;
                break;
            }
            case 24: {
                p[i] = 16;
                imlucky = -1;
                break;
            }
            case 32: {
                p[i] = 30;
                imlucky = -1;
                break;
            }
            default: {
                p[i] = p[i]+s;
                break;
            }
        }

        if (p[i] >= 36) {
            res = res + "Game over! Player " + i + " is the winner!";
        } else {
            int none = 0;
            if (imlucky == none){
                res = res + "Normal square reached by computer!";
            }
            if (imlucky == 1) {
                res = res + "Ladder reached!You lucky computer player!";
            }
            if (imlucky == -1) {
                res = res + "HaHaHa!!Snake bite!Sorry computer palyer!";
            }
            res = res + "You computer " + i + " are on square " + p[i];
        }

        return res;
    }

    public String status() {
        String pos = "Players positions: ";
        for (int i=0; i<4; i++){
            pos = pos + "player " + i + " is on " + p[i] + "square, ";
            pos = pos + Environment.NewLine;
        }
        return pos;
    }
}
