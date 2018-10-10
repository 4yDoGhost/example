#include <iomanip>;
#include <iostream>;
#include <string>;
#include <ctime>;
#include <stdio.h>
#include <ctype.h>

using namespace std;

void main()
{
	setlocale(LC_ALL, "ru");
	srand(time(NULL));

	int dlina = 0;
	cout << "Введите длину пароля: ";
	cin >> dlina;

	int kolvo_cifr = 0;
	cout << "Введите количество цифр: ";
	cin >> kolvo_cifr;

	int kolvo_bookv_mal = 0;
	cout << "Введите количество маленьких букв: ";
	cin >> kolvo_bookv_mal;

	int kolvo_bookv_big = 0;
	cout << "Введите количество больших букв: ";
	cin >> kolvo_bookv_big;

	int kolvo_sybol = dlina - kolvo_cifr - kolvo_bookv_mal - kolvo_bookv_big;

	if (kolvo_sybol >= 0)
	{
		string cifrs = "1234567890";
		string result1 = "";
		for (int i = 0; i < kolvo_cifr; i++)
		{
			result1 += cifrs[rand() % cifrs.length()];
		}
		cout << "\nВаши цифры: " << result1;

		string bookva_mal = "qwertyuiopasdfghjklzxcvbnm";
		string result2 = "";
		for (int i = 0; i < kolvo_bookv_mal; i++)
		{
			result2 += bookva_mal[rand() % bookva_mal.length()];
		}
		cout << "\nВаши буквы: " << result2;

		string bookva_bol = "QWERTYUIOPASDFGHJKLZXCVBNM";
		string result3 = "";
		for (int i = 0; i < kolvo_bookv_big; i++)
		{
			result3 += bookva_bol[rand() % bookva_bol.length()];
		}
		cout << "\nВаши буквы: " << result3;


		string symbol = "!\"№;%:?*()_+@#$^&-=\\|/<>.\'";
		string result4 = "";
		for (int i = 0; i < kolvo_sybol; i++)
		{
			result4 += symbol[rand() % symbol.length()];
		}
		cout << "\nВаши символы: " << result4;

		string password = result1 + result2 + result3 + result4;

		cout << "\n\n" << endl;

		int n = password.length();
		while (n + 1 > 1)
		{
			n--;
			int k = rand() % (n + 1);

			int bufer;
			bufer = password[k];
			password[k] = password[n];
			password[n] = bufer;

			cout << password[n];
		}

		cout << endl << endl;
	}
	else
		cout << "Кол - во введенных символов не совпадают с итоговой длиной пароля" << endl;

	system("pause");
}