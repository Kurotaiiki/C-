// Facturacion2.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
#include <string>
#include <string.h>
#include <iomanip>
using namespace std;

#pragma region Catalogo

class Catalogue
{
public:
    Catalogue();
    void Fill(string _names[], int _ids[], string _distributors[], string _descriptions[], double _prices[]);
    void Prints(int, int);
    void PrintsLess(int,int);
    double Price(int);
    bool Find(int &_index);
    int a = 20;
    string names[20];
    int ids[20];
    string distributors[20];
    string descriptions[20];
    double prices[20];

private:


};

Catalogue::Catalogue()
{
    
}

bool Catalogue::Find(int &_index)
{
    for (int i = 0; i < 20; i++)
    {
        if (ids[i] == _index)
        {
            _index = i;
            return true;
        }
    }

    return false;
}

void Catalogue::Fill(string _names[], int _ids[], string _distributors[], string _descriptions[], double _prices[])
{
    for (int i = 0; i < 20; i++)
    {
        names[i] = _names[i];
        ids[i] = _ids[i];
        distributors[i] = _distributors[i];
        descriptions[i] = _descriptions[i];
        prices[i] = _prices[i];

    }
}

void Catalogue::Prints(int _index,int _units)
{
    if (_units != 0)
    {
        cout << left << setfill('.') << "|" << right << setw(5) << ids[_index] << left << "|" << setw(20) << names[_index] << "|" << setw(15) << distributors[_index] << "|" << setw(25) << descriptions[_index] << "|" << right << setw(8) << _units << "|" << right << fixed << setprecision(0) << setw(15) << prices[_index] << "|" << endl;
    }
    else
    {
        cout << "\x1B[31m" << left << setfill('.') << " | " << right << setw(5) << ids[_index] << left << " | " << setw(20) << names[_index] << " | " << setw(15) << distributors[_index] << " | " << setw(25) << descriptions[_index] << " | " << right << setw(8) << _units << " | " << right << fixed << setprecision(0) << setw(15) << prices[_index] << " | " << "\x1B[37m" << endl;
    }
}
void Catalogue::PrintsLess(int _index,int _units)
{
    if (_units != 0)
    {
        cout << left << setfill('.') << "|" << right << setw(5) << ids[_index] << left << "|" << setw(20) << names[_index] << "|" << setw(15) << distributors[_index] << "|" << setw(25) << descriptions[_index] << "|" << right << setw(8) << _units << "|" << right << fixed << setprecision(0) << setw(15) << prices[_index] << "|" << endl;
    }
}
double Catalogue::Price(int _index)
{
    return prices[_index];
}

#pragma endregion

#pragma region Cliente


class Client
{
public:
    Client(Catalogue);
    bool Buy(int, int);
    string GetDebit();
    double GetNumCredit();
    bool startBuy = false;
    void AddCart(int, int);
    int cart[20];
    int id;
    string address;

private:
    
    Catalogue catalogue;
    double credit = 0;

};

Client::Client(Catalogue _catalogue)
{
    catalogue = _catalogue;

    cout << "Cual es su id ->";
    cin >> id;

    cout << "Cual es su Direccion ->";
    cin.clear();
    cin.ignore();
    getline(cin, address);


    cout << "Cual es el cupo de su tarjeta ->";
    cin >> credit;

    for (int i = 0; i < 20; i++)
    {
        cart[i] = 0;
    }


}
bool Client::Buy(int _index, int _units)
{
    startBuy = true;
    catalogue.Find(_index);

    if (credit - (_units * catalogue.Price(_index)) < 0)
    {
        return false;
    }
    
    if (catalogue.ids[_index] >= 2000 && catalogue.ids[_index] <= 3000)
    {
        credit -= (_units * catalogue.Price(_index))*0.8;
        cout << "\nPRODUCTO DEL HOGAR CON 20% DE DESCUENTO\n";
        return true;
    }
    else
    {
        credit -= _units * catalogue.Price(_index);
        return true;
    }
    
}


double Client::GetNumCredit()
{
    double num ;
    num = credit;
    return num;
}


#pragma endregion


#pragma region Tienda

class Store
{
public:
    Store(string,string, Catalogue,int _u[]);
    int stock[20];
    void Show(bool);
    bool Sell(int _id, int _units, string& _message, Store& b, Store& c, Store& d, int& option, Client& client);
    int Id(int);
    string ShowName();
    void Facture(Client, Catalogue);


private:
    string city;
    string zone;
    Catalogue catalogue;
};

Store::Store(string _city,string _zone,Catalogue _catalogue,int _units[])
{
    city = _city;
    zone = _zone;
    catalogue = _catalogue;
    for (int i = 0; i < 20 ; i ++)
    {
        stock[i] = _units[i];
    }
}
string Store::ShowName()
{
    string txt = city + "-" + zone;
    return txt;
}

void Store::Show(bool less)
{
    cout << setw(96) << setfill('/') << '\n' << setfill(' ');
    cout << left << "|" << right << setw(35) << setfill('.') << "|" << setw(12) << right << setfill('.') << city << "|" << setw(12) << left << setfill('.') << zone << left << "|" << setw(33) << setfill('.') << right << "|";
    cout << "\n" << setw(96) << setfill('/') << '\n' << setfill(' ');
    cout << left << setfill('.') << "|" << right << setw(5) << "ID" << "|" << setw(20) << "Producto" << "|" << setw(15) << "Distribuidor" << "|" << setw(25) << "Descripcion" << "|" << setw(8) << "Unidades" << "|" << setw(15) << "Vlr Unit" << "|" << endl;
    cout << setw(96) << setfill('/') << '\n' << setfill(' ');
    for (int i=0;i<20;i++)
    {
        if (less)
        {
            catalogue.PrintsLess(i,stock[i]);

        }
        else
        {
            catalogue.Prints(i, stock[i]);
        }
    }
    cout << setw(75) << setfill('-') << '\n' << setfill(' ') << endl;
}

bool Store::Sell(int _id, int _units, string& _message, Store& b, Store& c, Store& d, int& option, Client& client)
{
    int _index = _id;
    _message = ""; 
    string stores = ""; 

    if (!catalogue.Find(_index))
    {
        _message = "ID no encontrado \n ingrese un ID valido ||";
        option = 1;
        return false;
    }

    if (stock[_index] == 0)
    {
        _message = "No se tiene inventario de este producto";

        if (b.stock[_index]> 0)
        {
            stores += b.ShowName() + " | ";
        }
        if (c.stock[_index] > 0)
        {

            stores += c.ShowName() + " | ";
        }
        if (d.stock[_index]> 0)
        {
            stores += d.ShowName() + " | ";
        }

        if (stores != "")
        {
            _message = "No nos queda stock en esta tienda\npuedes encontrar este producto en\nlas sigientes sucursales:\n\n|" + stores + "\n";
        }

        option = 1;
        return false;
    }



    if (stock[_index] - _units < 0)
    {
        _message = "El maximo de unidades que se pueden vender son ->" + to_string(stock[_index]) + "\nIngrese una cantidad valida ->";
        option = 2;
        return false;
    }

    else
    {
        if (client.Buy(_index, _units))
        {
            
            stock[_index] -= _units;
            client.cart[_index] += _units;
            option = 0;

            

        }
        else
        {
            cout << "\n||No te alcanza el cupo de la tarjeta||\n";
        }
        return true;

    }
}

void Store::Facture(Client _client, Catalogue _catalog)
{
    double total = 0;
    double discount = 0;
    string products = "";
    string message = "";
    system("cls");


    


    cout << "\x1B[36m" << setw(91) << setfill('|') << "|" << setfill(' ') << "\n";

    cout << left << "\x1B[36m|" << right << setw(30) << setfill('.') << "|\x1B[37m" << setw(18) << right << setfill('.') << "Facturacion" << setw(18) << right
         << "\x1B[36m|" << setw(35) << setfill('.') << right << "|\n";

    cout << setw(91) << setfill('|') << "|" << setfill(' ') << "\n";

    cout << left << "|\x1B[36m" << right << setw(30) << setfill('.') << "|\x1B[37m" << setw(13) << right << setfill('.') << city << "\x1B[36m|\x1B[37m" << setw(16) << left
         << setfill('.') << zone << left << "\x1B[36m|" << setw(35) << setfill('.') << right << "|\n";

    cout << setw(91) << setfill('|') << "|" << setfill(' ') << "\n";

    cout << left << setfill('.') << "|" << right << setw(8) << "\x1B[37m" << "ID" << "\x1B[36m" << "|" << setw(5) << "\x1B[37m" << "Unidades" << "\x1B[36m" << "|" << setw(20) << left << "\x1B[37m" << "Producto" << "\x1B[36m"
         << "|\x1B[37m" << setw(16) <<right << "Vlr unitario" << "\x1B[36m" << "|\x1B[37m" << setw(29) <<right << "\x1B[37m" << "Vlr total" << right << "\x1B[36m|" << endl;

    cout << setw(91) << setfill('|') << "|" << setfill(' ') << "\n";

    for (int i = 0; i < 20; i++)
    {
        if (_client.cart[i] > 0)
        {
            cout << left << setfill('.') << "|" << right << setw(5) << _catalog.ids[i] << "|" << setw(20) << _client.cart[i]
                << "|" << setw(20) << left << _catalog.names[i] << "|" << setw(25) << _catalog.prices[i] << "|" << setw(15)
                << _catalog.prices[i] * _client.cart[i] << "|" << endl;

            if (_catalog.ids[i] >= 2000 && _catalog.ids[i] <= 3000)
            {
                products += _catalog.names[i] + "|";
                discount += (_catalog.prices[i] * _client.cart[i]) * 0.2;
            }
            total += _catalog.prices[i] * _client.cart[i];

        }
    }

    cout << setw(91) << setfill('|') << "|" << setfill(' ') << "\n";
    cout << setw(91) << setfill('|') << "|" << setfill(' ') << "\n|";

    message = "20% de descuento en hogar :" + products;
    cout << right << setw(90) << setfill('|') << message << setfill('.') << setfill(' ') << "\n|";

    message = "Total sin desc :";
    cout << right << setw(75) << setfill('|') << message << setfill('.') << setw(14) << right << fixed << total << "|" << setfill(' ') << "\n|";

    message = "Total descuentos :";
    cout << right << setw(75) << setfill('|') << message << setfill('.') << setw(14) << right << fixed << discount << "|" << setfill(' ') << "\n|";

    message = "Total con descuentos:";
    cout << right << setw(75) << setfill('|') << message << setfill('.') << setw(14) << right << fixed << total - discount << "|" << setfill(' ') << "\n|";

    cout << setw(90) << setfill('|') << "|" << setfill(' ') << "\n";
    cout << setw(91) << setfill('|') << "|" << setfill(' ') << "\n|";

    cout << right << setw(49) << setfill('|') << "ID del cliente :" << setfill('.') << right << setw(40) << fixed << _client.id << setfill(' ') << "|\n||";
    cout << right << setw(48) << setfill('|') << "Direccion :" << setfill('.') << right << setw(40) << fixed << _client.address << setfill(' ') << "|\n";
    cout << setw(91) << setfill('|') << "|" << setfill(' ') << "\n";
    cout << setw(91) << setfill('|') << "|" << setfill(' ') << "\n";





}

#pragma endregion










void Init(Catalogue& catalogue);
void Buy(Store& current, Store& b, Store& c, Store& d, Client &_client);

int main()
{
    
    system("color 0F");
    Catalogue my_cat;
    Init(my_cat);
    int units[4][20] = { {3,5,76,34,21,3,65,43,123,54,87,213,4,31,3,0,12,45,23,3},
                        {2,43,43,65,23,0,76,12,9,3,0,123,5,89,32,24,1,7,23,65},
                        {12,6,8,5,3,98,0,3,6,8,2,5,8,45,76,2,5,7,2,34},
                        {23,55,23,6,23,6,3,8,4,86,23,5,86,2,54,2,34,65,2,23} };

    Store a("Bogota", "Norte", my_cat,units[0]);
    Store b("Bogota", "Sur", my_cat, units[1]);
    Store c("Cali", "Oriente", my_cat, units[2]);
    Store d("Cali", "Occidente", my_cat, units[3]);


    Client client(my_cat);

    int option;

    do
    {
        system("cls");
        cout << "En que Ciudad se encuentra .:\n1.Bogota\n2.Cali\n3.Salir\n->";
        cin >> option;

        switch (option)
        {
        case 1:
            option = 3;
            do
            {
                system("cls");
                if (client.startBuy)
                {
                    cout << "En que region se encuentra .:\n1.Norte\n2.Sur\n3.Salir\n->";
                }
                else
                {
                    cout << "En que region se encuentra .:\n1.Norte\n2.Sur\n3.Volver a ciudad\n->";
                }
                
                cin >> option;
                system("cls");

                switch (option)
                {
                case 1:

                    do
                    {
                        a.Show(false);
                        Buy(a, c, b, d, client);

                        cout << "\n1.Si desea seguir comprando\n2.Si desea salir\n->";
                        cin >> option;

                        switch (option)
                        {
                        case 1:
                            break;
                        case 2:
                            a.Facture(client, my_cat);
                            option = 3;
                            break;
                        default:
                            cout << "\nFUERA DEL RANGO PERMITIDO\n";
                            system("pause");
                            cin.clear();
                            break;
                        }

                    } while (option != 3);
                    break;
                case 2:
                    option = 3;

                    b.Show(false);
                    Buy(b, a, c, d, client);
                    break;
                case 3:
                    break;
                default:
                    cout << "\nFUERA DEL RANGO PERMITIDO\n";
                    system("pause");
                    cin.clear();

                    break;
                }

            } while (option != 3);
            if (!client.startBuy)
            {
                option = 0;
            }
            break;
        case 2:
            option = 3;
            do
            {
                system("cls");
                if (client.startBuy)
                {
                    cout << "En que region se encuentra .:\n1.Norte\n2.Sur\n3.Salir\n->";
                }
                else
                {
                    cout << "En que region se encuentra .:\n1.Norte\n2.Sur\n3.Volver a ciudad\n->";
                }
                cin >> option;
                system("cls");

                switch (option)
                {
                case 1:
                    option = 3;
                    c.Show(false);
                    Buy(c, a, b, d, client);
                    break;


                case 2:
                    option = 3;
                    d.Show(false);
                    Buy(d, b, c, a, client);
                    break;
                case 3:
                    break;
                default:
                    cout << "\nFUERA DEL RANGO PERMITIDO\n";
                    system("pause");
                    cin.clear();

                    break;
                }

            } while (option != 3);
            if (!client.startBuy)
            {
                option = 0;
            }
            break;
        case 3:
            break;
        default:
            cout << "\nFUERA DEL RANGO PERMITIDO\n";
            system("pause");

            break;
        }
        if (!client.startBuy)
        {

            system("pause");
            option = 0;
        }
    } while (option != 3);


    system("pause");


}

void Init(Catalogue &catalogue)
{

    string names[20] = { "Lavadora", "Trapero", "Nevera", "Horno", "Holla pitadora",
        "Bicicleta", "Caminadora", "Escitorio", "Botas de seguridad", "Mouse",
        "Portatil Acer", "Parlante", "SixPack Poker", "Secadora de cabello", "Play 5 ",
        "Nintendo Switch", "Bate de baseball", "Funda de portatil", "Caja de herramientas", "Freidora de aire" };

    int ids[20] = { 2401, 2402, 2403, 2404, 2405,
                 1505, 1506, 1507, 1508, 1509,
                 1510, 1511, 1512, 1513, 1514,
                 1515, 1516, 1517, 1518, 1519 };

    string distributors[20] = { "LG","DonBarredora", "Haceb","Kalley", "sony",
                          "Orbean","ElctroCity", "Confort","Westland", "Logitech",
                          "TecnoStore","Acer", "Babaria","Remington","sony",
                          "Nintendo","SportCenter","Compumundo", "Uberman","Imusa" };

    string descriptions[20] = { "30 Litros", "Con escurridor", "No frozen", "Electrico Multifuncional", "Con ahumador",
                            "Ruta con marco de carbono", "Plegable", "Madera estructura metal", "Punta de acero", "Inhalambrico",
                            "Ryzen5  RTX2060", "Inhalambrico 8.1", "Lata x 330 ", "Negro 125v/220v", "Roja",
                            "OLED 64GB blanco y negro", "Madera Caoba", "27\" Negra", "Plastica doble negra", "Fry Deluxe 4,2l Digital" };

    double prices[20] = { 2500000, 15000, 5000000, 4500000, 300000,
                        5200000, 1500000, 800000, 45000, 200000,
                        4000000, 350000, 15000, 100000, 3500000,
                        1200000, 170000, 1000000, 240000, 300000 };

    catalogue.Fill(names, ids, distributors, descriptions, prices);
    
}

void Buy(Store& current, Store& b, Store& c, Store& d,Client &_client)
{
    int units = 0;
    int id = 0;
    string message;
    int check;

    

    if (_client.GetNumCredit() > 0)
    {
        

        cout << "El cupo de su tarjeta es de ||" << fixed << _client.GetNumCredit() << "||\nIngrese el ID del producto que desea comprar ->";
        cin >> id;

        cout << "Ingrese la cantidad que desea ->";
        cin >> units;

        while (!current.Sell(id, units, message, b, c, d, check, _client))
        {
            system("cls");
            current.Show(true);
            if (check == 1)
            {
                cout << message + "\nIngrese el ID del producto que desea comprar ->";
                cin >> id;

                cout << "\nIngrese la cantidad que desea ->";
                cin >> units;
            }
            else if (check == 2)
            {
                cout << message;
                cin >> units;

                cout << "\nIngrese el ID del producto que desea comprar ->";
                cin >> id;
            }
        }
    }
    else
    {
        _client.startBuy = true;
        cout << "No dispones de mas credito";
    }
    
}

