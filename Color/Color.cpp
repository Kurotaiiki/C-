//Black 	\x1B[30m	\x1B[40m
//Red	    \x1B[31m	\x1B[41m
//Green	    \x1B[32m	\x1B[42m
//Yellow	\x1B[33m	\x1B[43m
//Blue	    \x1B[34m	\x1B[44m
//Magenta	\x1B[35m	\x1B[45m
//Cyan	    \x1B[36m	\x1B[46m
//White	    \x1B[37m	\x1B[47m
// 
//Cualquier color(con V en[0 - 255])	\x1B[38; 5; Vm	\x1B[48; 5; Vm
//Cualquier RGB color(Con valores en[0 - 255])	\x1B[38; 2; R; G; Bm	\x1B[48; 2; R; G; Bm

#include <iostream>
using namespace std;

int main()
{
    string r = "120";
    string g = "200";
    string b = "120";

    string color = "\x1b[38;2;" + r + ";" + g + ";" + b + "m";


    cout<<color<<" hello world\x1b[0m";
    system("pause");
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
