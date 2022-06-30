// Ejercicios_algoritmos.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
#include <string>
#include <stdio.h>
//#include <cstdio>
#include <wchar.h>
using namespace std;


void MajorMinor(int a)
{
	if (a>0)
	{
		cout << "El numero es mayor que 0";
	}
	else if (a < 0) 
	{
		cout << "El numero es menor que 0";
	}
	else
	{
		cout << "el numero es cero";
	}
	cout << endl;
}

void Pair(int a)
{
		if (a % 2 == 0) 
		{
			cout << "El numero es par";
		}
		else
		{
			cout << "El numero es impar";
		}
		cout << endl;

} 

void Print(bool pair) 
{
	if (!pair)
	{
		for (int i = 100; i >= -2; i--)
		{
			if (i % 10 == 0)
			{
				cout << endl;
			}
			cout << "|" << i;
		}
	}
	else
	{
		for (int i = 2; i <= 100; i+=2)
		{
			if (i % 10 == 0)
			{
				cout << endl;
			}
			cout << "//" << i;
		}
	}
	cout << endl;
}
void Average()
{
	bool active=true;
	float note=0;
	float temp;
	int average=0;
	do
	{
		cout << "Ingrese una nota .:";
		cin >> temp;

		if (temp==0)
		{
			active = false;
		}
		else
		{
			note += temp;
			average++;
		}
	} while (active);


	cout << "\nEl promedio de notas es de .:" << note / average<<endl;

}

void multiples()
{
	int of3=0;
	int of2=0;
	cout << "multiplos de dos\n" << endl;
	for (int i = 1; i <= 100; i++)
	{
		if (i % 10 == 0)
		{
			cout << endl;
		}
		if (i%2==0)
		{
			of2++;			
			cout << "|" << i;
		}
	}

	cout << "\nmultiplos de 3\n" << endl;
	for (int i = 1; i <= 100; i++)
	{
		if (i %10 == 0)
		{
			cout << endl;
		}
		if (i % 3 == 0)
		{
			of3++;
			cout <<"|" << i;
		}
	}
	cout << "\nHay " << of2 << " multiplos de 2" << endl;
	cout << "\nHay " << of3 << " multiplos de 3" << endl;

}

void MajorMinor()
{
	int a;
	int b;

	cout << "Ingrese el primer numero .:";
	cin >>a;
	cout << "Ingrese el segundo numero .:";
	cin >>b;

	if (a>b)
	{
		cout << "El " << a << " es el mayor";
	}
	else
	{
		cout << "El " << a << " es el menor";
	}
}

void Summation() 
{
	int sum=0;
	for (int i  = 20; i <= 50; i++)
	{
		sum += i;
	}
	cout << "\nLa sumatoria desde 20 hasta 50 es .:" << sum;
}

void Sum()
{
	double total=0;
	double temp;
	for (int i = 1; i < 16; i++)
	{
		cout << "ingrese el numero " << i << " .:";
		cin >> temp;
		total += temp;

	}
	cout << "La suma de los 15 numeros es " << total;
}

void Age() 
{
	int year;
	int months[]= {31,28,31,30,31,30,31,31,30,31,30,31};
	int month=0;
	int day;
	int years;

	cout << "Ingese el año de nacimiento .:";
	cin >> year;

	cout << "Ingese el numero del mes de nacimiento";
	
	cout << "\n1.Enero\t\t7.Julio\n2.Febrero\t8.Agosto\n3.Marzo\t\t9.Septiembre\n4.Abril\t\t10.Octubre\n5.Mayo\t\t11.Noviembre\n6.Junio\t\t12.Diciembre\n.:";
	cin >> month;

	while (month < 1 || month >12) {
		cout << "Recuerde sus opciones";
		cout << "\n1.Enero\t\t7.Julio\n2.Febrero\t8.Agosto\n3.Marzo\t\t9.Septiembre\n4.Abril\t\t10.Octubre\n5.Mayo\t\t11.Noviembre\n6.Junio\t\t12.Diciembre\n.:";

		cin >> month;
	} 

	printf("Ingrese su dia de naciemiento, reecuerde que maximo puede ser %d ", months[month-1]);


	

	if (month=2)
	{
		for (int i = 0; i < month - 1; i++)
		{

		}
	}
	else
	{
		for (int i = 0; i < month - 2; i++)
		{

		}
	}
	




}


int main()
{
	/*int a;
	cout << "Ingrese el numero a comparar .:";
	cin >> a;
    MajorMinor(a);*/

	/*Pair(a);
	Print(false);
	Print(true);
	Average();
	multiples();
	MajorMinor();
	Summation();
	Sum();*/
	Age();
    system("pause");
}


