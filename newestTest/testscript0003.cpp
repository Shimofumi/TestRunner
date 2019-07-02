// ConsoleApplication1.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>
#include <cstdio>
#include <string>



int main()
{
	using namespace std;
	using std::cout;
	using std::endl;
	using std::cin;
	cout << "身長は何メートルくらいかの？" << endl;
	double height;
	cin >> height;
	cout << "体重は何kgくらいかの？ >";
	double mass;
	cin >> mass;
	double bmi = mass / (height * height);
	cout << "BMI= " << bmi << "\n"s;
	cout << "このBMIはえーとどれくらいの意味だったかのう..." << "\n"s;
	auto status = [](double bmi)
	{
		if (bmi < 18.5)// these magic numbers are based on the BMI judgement
			return "痩せすぎじゃ。たんと食え。\n"s;
		else if (bmi < 25.0)
			return "普通じゃの。精進に努めよ。\n"s;
		else if (bmi < 30.0)
			return "ちょいと肥えとるの。 運動に努めよ。\n"s;
		else
			return "やーいデブ！やーいデブ！ 医者に相談せよ。 \n"s;
	};
	cout << status(bmi) << endl;
	cout << "おわりじゃ" << endl;
}

// プログラムの実行: Ctrl + F5 または [デバッグ] > [デバッグなしで開始] メニュー
// プログラムのデバッグ: F5 または [デバッグ] > [デバッグの開始] メニュー

// 作業を開始するためのヒント: 
//    1. ソリューション エクスプローラー ウィンドウを使用してファイルを追加/管理します 
//   2. チーム エクスプローラー ウィンドウを使用してソース管理に接続します
//   3. 出力ウィンドウを使用して、ビルド出力とその他のメッセージを表示します
//   4. エラー一覧ウィンドウを使用してエラーを表示します
//   5. [プロジェクト] > [新しい項目の追加] と移動して新しいコード ファイルを作成するか、[プロジェクト] > [既存の項目の追加] と移動して既存のコード ファイルをプロジェクトに追加します
//   6. 後ほどこのプロジェクトを再び開く場合、[ファイル] > [開く] > [プロジェクト] と移動して .sln ファイルを選択します
