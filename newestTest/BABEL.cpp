

#include <iostream>

int main()
{
	//----------BABEL--------
	int tatebabel;
	int yokobabel;
	std::cout << "BABEL横に何個並べる？　推奨20　＞";
	std::cin >> yokobabel;
	std::cout << "何段立てる？　＞";
	std::cin >> tatebabel;
	std::cout << "\033[31m";
	for (int i = 1; i <= tatebabel; i++)
	{
		for (int j = 1; j <= yokobabel; j++)
		{
			std::cout  << "BABEL ";
			// std::setw() で最低文字幅決めるのもよさげ 
			//	例えばsetw(3)で九九出力すると
			//	  1  2  3  4  5  6  7  8  9
			//	  2  4  6  8 10 12 14 16 18
			//	  3  6  9 12 15 18 21 24 27
			//	...という風になる

		}
		std::cout << '\n';
		for (int k = 1; k <= yokobabel; k++) { std::cout << " BABEL"; }
		std::cout << '\n';
	}
}