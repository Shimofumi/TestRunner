// ConsoleApplication1.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>
#include <cstdio>
#include <string>

int nResults[] = {
	641, 703, 405, 598, 402, 752, 330,   0, 445, 662,
	254, 710, 467, 530, 548, 485, 244, 396, 601, 510,
	532, 687, 623, 420, 647, 587, 490, 647, 575, 688,
	764, 633, 712, 312, 655, 425, 722, 631, 680, 602
};
int main() 
{
	using std::cout;
	using std::endl;
	int nSum = 0;
	for (int i = 0; i < 40; i++) {
		nSum += nResults[i];
	}
	cout << "平均は" << nSum/40.0 << "点じゃ" << endl;
	int a, b, sign, result;
	for (int i = 0; i < 1; i++) 
	{
		cout << "ひとつめの値を入れるのじゃ ＞";
		std::cin >> a;
		cout << "ふたつめの値も入れるのじゃ ＞";
		std::cin >> b;
		if (b == 0) 
		{
			cout << "0除算じゃ！たわけ！" << endl;
			continue;
		}
		cout << a << "/" << b << "=" << a / b << "..." << a % b << endl;
	}
	for (int i = 0; i < 1; i++) {
		cout << "どれをするのじゃ？（1：加算，2：減算，3：乗算，4：除算）＞";
		std::cin >> sign;
		cout << "第一項 >";
		std::cin >> a;
		cout << "第二項 >";
		std::cin >> b;
		switch (sign)
		{
		case 1:
			result = a + b; break;
		case 2:
			result = a - b; break;
		case 3:
			result = a * b; break;
		case 4:
			if (b == 0) { cout << "0除算じゃ！たわけ！" << endl; continue; }
			result = a / b; break;
		default:
			cout << "真面目にせんかい！" << endl;
			continue;
			break;
		}
		cout << "正答は " << result << " じゃ。" << endl;
	}
	cout << "「0」にふられた番号は" << (int)(unsigned char)'0' << "じゃ。" << endl;
	cout << "「妲己」にふられた番号は" << '妲' << " " << '己' << "じゃ。" << endl;
	char szHello[] = "もう昼じゃ、おはよう";
	cout << "「" << szHello << "」を文字コードに変えると、" << endl;
	for (int i = 0; i < std::strlen(szHello); i++) { cout << (int)(unsigned char)szHello[i] << ","; }
	cout << (int)(unsigned char)szHello[20] << endl << "じゃ。" << endl;
	printf("a : %p\nb : %p\nmain : %p\n", &a, &b, main);
	int* p;
	int* q, * r;
	p = &a;
	cout << "p = " << (unsigned int)p << endl;
	cout << "&a = "<< (unsigned int)&a << endl;
	int c;
	c = getchar();
	while (c != EOF)
	{
		putchar(c);
		c = getchar();
	}
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
