

#include <iostream>
#include<thread>

int main()
{
	//----------BABEL--------
	int yokobabel;
	int tatebabel;
	std::cout << "BABEL横に何個並べる？　推奨20　＞";
	std::cin >> yokobabel;
	std::cout << "何段立てる？　＞";
	std::cin >> tatebabel;
	int howlongwaitmillisec; //BABELがせりあがってくる速度をミリ秒で,あまり長いといっぱいになる前に飽きる
	std::cout << "次の行にいくまでの時間をミリ秒で 推奨250~500 ＞";
	std::cin >> howlongwaitmillisec;
	std::cout << "\033[31m";		//エスケープシーケンスによる文字色制御
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
		std::this_thread::sleep_for(std::chrono::milliseconds(howlongwaitmillisec));
		std::cout << '\n';
		for (int k = 1; k <= yokobabel; k++) { std::cout << " BABEL"; }
		std::this_thread::sleep_for(std::chrono::milliseconds(howlongwaitmillisec));
		std::cout << '\n';
	}
}