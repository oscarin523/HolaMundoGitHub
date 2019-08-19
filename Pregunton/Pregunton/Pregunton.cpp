#include <iostream>
#include <string>
using namespace std;

int main()
{
	int x, y, resultado; 
	cout << "Dame el primer valor:";
	cin >> x;
	cout << "Dame el segundo valor";
	cin >> y;
	resultado = x + y;
	cout << "El resultado de la suma es" << resultado;

	int q, p, resultado;
	cout << "Dame el primer valor:";
	cin >> q;
	cout << "Dame el segundo valor";
	cin >> p;
	resultado = q - p;
	cout << "El resultado de la resta es" << resultado;

	int v, n, resultado;
	cout << "Dame el primer valor:";
	cin >> v;
	cout << "Dame el segundo valor";
	cin >> n;
	resultado = v / n;
	cout << "El resultado de la division es" << resultado;

	int a, b, resultado;
	cout << "Dame el primer valor:";
	cin >> a;
	cout << "Dame el segundo valor";
	cin >> b;
	resultado = a * b;
	cout << "El resultado de la multiplicacion es" << resultado;
}
