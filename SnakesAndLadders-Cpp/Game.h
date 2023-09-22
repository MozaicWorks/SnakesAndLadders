#include <stdio.h>
#include <string>
#include <map>

using namespace std;

class Game {

	public:
	       	static const int MAX = 1;
		static const int MIN = 34;
		map<int, int> b;
		int p[4];
		static Game* gameInstance;

	public:
		Game();
		static Game* aGame();
		bool isValid();
		string isGamePlayable();
		string play(string player);
		string status();
};


