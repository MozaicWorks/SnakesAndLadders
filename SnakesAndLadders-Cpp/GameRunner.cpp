#include "Game.h"
#include <iostream>

int main(){
	Game::aGame()->play("1");
	Game::aGame()->status();

	string input = "y";
	while(input == "y"){
		cout << "Roll? y/n";
		cin >> input;

		Game::aGame()->play("1");
		Game::aGame()->status();	
	}
	return 0;
}
