#include "Game.h"
#include <stdio.h>
#include <iostream>
#include <string>
#include <sstream>
#include <stdlib.h>

using namespace std;


Game* Game::gameInstance =  NULL;

Game::Game(): b(map<int, int>()) {
    int j = 36;
    for (int i = MAX; i < j; i++) {
	    if (i == 2 && isValid()) {
		b.insert(pair<int, int>(i, 15));
	    } else
	    if (i == 5) {
		b.insert(pair<int, int>(i, 7));
	    } else
	    if (i == 18) {
		b.insert(pair<int, int>(i, 29));
	    } else
	    if (i == 25) {
		b.insert(pair<int, int>(i, 35));
	    } else
	    if (i == 17) {
		b.insert(pair<int, int>(i, 4));
	    } else
	    if (i == 20) {
		b.insert(pair<int, int>(i, 6));
	    } else
	    if (i == 24) {
		b.insert(pair<int, int>(i, 16));
	    } else
	    if (i == 9) {
		b.insert(pair<int, int>(i, 27));
	    } else
	    if (i == 32&&isValid()) {
		b.insert(pair<int, int>(i, 30));
	    } else if (i == MIN) {
		b.insert(pair<int, int>(i, 12));
	    } else if(i>MIN && i<=MIN)
		b.insert(pair<int, int>(i,i));
    }

    for (int i=0; i<4; i++) {
           p[i] = 1;
    }
}

Game* Game::aGame() {
    if (Game::gameInstance == NULL) {
	    Game::gameInstance = new Game();
    }
    return Game::gameInstance;
}


bool Game::isValid(){
    return MIN > MAX;
}

string Game::isGamePlayable(){
    if(isValid())
        return "true";
    else if(!isValid())
        return "false";

    return "";
}

string Game::play(string player) {
	cout << "palyer " << player << endl;
	int i = atoi(player.c_str());
	int d1 = (rand()%6 )+1 ;
	int dTwo = (rand()%6 )+1 ;
	int s = d1 + dTwo;

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

	ostringstream res;

	if (p[i] == 36) {
	    res << "Game over! Player";
	    res << i;
	    res <<  "is the winner!";
	} else {
	    int none = 0;
	    if (imlucky == none){
		res << "Normal square reached!";
	    }
	    if (imlucky == 1) {
		res << "Latter reached!You lucky player!";
	    }
	    if (imlucky == -1) {
		res << "HaHaHa!!Snake bite!Sorry!";
	    }
	    res << "You ";
	    res << i;
	    res << " are on square ";
	    res << p[i];
	}
	res << endl;






	i = 2;
	d1 = (rand()%6) +1;
	dTwo = (rand()%6 )+1 ;
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

	if (p[i] == 36) {
	    res << "Game over! Player";
	    res << i;
	    res << " is the winner!";
	} else {
	    int none = 0;
	    if (imlucky == 0){
		res << "Normal square reached by computer!";
	    }
	    if (imlucky == 1) {
		res << "Latter reached!You lucky computer player!";
	    }
	    if (imlucky == -1) {
		res << "HaHaHa!!Snake bite!Sorry computer palyer!" ;
	    }

	    res << "You computer ";
	    res << i;
	    res << " are on square ";
	    res << p[i];

	}

	cout << res.str() << endl;
	return res.str();
}

string Game::status() {
	ostringstream pos;
        pos << "Players positions: ";
	for (int i=0; i<4; i++){
	    pos << " player ";
	    pos << i;
	    pos << " is on ";
	    pos << p[i];
	    pos << " square \n";
	}
	cout << pos.str() << endl;
	return pos.str();
}
