#include <iostream>
#include <windows.h>
#include <math.h>
#include <stdio.h>
#include <string>

using namespace std;

int opcion=0;
float a=0;
float b=0;
float c=0;
int num;
char continuar='s';
string ejercicios[]={"Operaciones Basicas","Areas","Cuadratica","Descomponer un numero","Fibonacci","Numero primo","Factorial","Operaciones","Mayor y Menor","Impares"};

/*Impresion del nombre del ejercicio escogido*/
void Iniciar(){
	
	system("cls");
	cout<<"Ejercicio "<<opcion<<" "<<ejercicios[opcion-1]<<endl;
	Beep(1568,100);
	Beep(1600,50);	
	
}




/*Operaciones*/

float Suma(float n1,float n2){
	return n1+n2;
}
float Resta(float n1,float n2){
	return n1-n2;
}
float Multiplicacion(float n1,float n2){
	return n1*n2;
}
float Division(float n1,float n2){
	return n1/n2;
}



/*operaciones basicas*/
void Calcular(){

	Iniciar();
    int operacion=0;
    bool validar=false;
    string titulos[]={"Suma","Resta","Multiplicacion","Division"};
    cout<<"\nIngrese la opcion de la operacion que desea realizar \n1:Suma 2:Resta 3:Multiplicacion 4:Division\n-->>";
    cin>>operacion;
    system("cls");
    while(validar==false)
    {
	
    switch (operacion)
    {
    case 1:
        /* Suma */
        cout<<"\n Ingrese los numeros a "<<titulos[operacion-1]<<"r";
        cout<<"\nNumero a:";
        cin>>a;
        cout<<"Numero b:";
        cin>>b;
        
        cout<<a<<"+"<<b<<"="<<Suma(a,b);
        validar=true;
        break;
    case 2:
        /* Resta */
        cout<<titulos[operacion-1];
        cout<<"\n Ingrese los numeros a "<<titulos[operacion-1]<<"r";
        cout<<"\nNumero a:";
        cin>>a;
        cout<<"Numero b:";
        cin>>b;
        
        cout<<a<<"-"<<b<<"="<<Resta(a,b);
        validar=true;
        break;
    case 3:
        /* Multiplicacion */
        cout<<titulos[operacion-1];
        cout<<"\n Ingrese los numeros a multiplicar";
        cout<<"\nNumero a:";
        cin>>a;
        cout<<"Numero b:";
        cin>>b;
        
        cout<<a<<"x"<<b<<"="<<Multiplicacion(a,b);
        validar=true;
        break;
    case 4:
        /* Division */
        cout<<titulos[operacion-1];
        cout<<"\n Ingrese los numeros a dividir";
        cout<<"\nNumero a:";
        cin>>a;
        cout<<"Numero b:";
        cin>>b;
        
        while (b==0){
            cout<<"recuerde que no es posible dividir entre cero\nIngrese nuevamente el numero b\n-->";
            cin>>b;
            
        }
        
        cout<<a<<"/"<<b<<"="<<Division(a,b);
        validar=true;
        break;           
    
    default:
        
        system("cls");
        Beep(160,20);
        Beep(150,20);
        cout<<"ingrese una opcion valida recuerde la lista de opciones \n1:suma 2:resta 3:multiplicacion 4:division\n-->>";
        cin>>operacion;
        
        break;
    }
		
    
	}
    
    
}

/*Calculadora de areas*/
void Areas(){

	Iniciar();
    int operacion=0;
    bool validar=false;
    string titulos[]={"Cuadrado","Circulo","Triangulo","Rectangulo"};
    cout<<"\nIngrese la opcion segun el area que desee hallar \n1:Cuadrado 2:Circulo 3:Triangulo 4:Rectangulo\n-->>";
    cin>>operacion;
    while(validar==false)
    {
	
    switch (operacion)
    {
    case 1:
        /* Cuadrado */
        cout<<"\n Area del "<<titulos[operacion-1];
        Beep(1568,200);
        cout<<"\nIngrese la Base\n-->>";
        cin>>a;
        
        cout<< "\nUn cuadrado de base "<< a<<" tiene de area de "<<Multiplicacion(a,a);
        validar=true;
        break;
    case 2:
        /* Circulo */
    	cout<<"\n Area del "<<titulos[operacion-1];
        Beep(1568,200);
        cout<<"\nIngrese el Radio\n-->>";
        cin>>a;
        
        cout<<"\nEl area de un circulo con un radio "<<a<<" es de "<<Multiplicacion(a,3.14);
        validar=true;
        break;
    case 3:
        /* Triangulo*/
        cout<<"\n Area del "<<titulos[operacion-1];
        Beep(1568,200);
        cout<<"\nIngrese la Base\n-->>";
        cin>>a;
        cout<<"\nIngrese la Altura\n-->>";
        cin>>b;
        
        cout<<"\nSiendo la base "<<a<<" y la altura "<<b<<" el area del triangulo es de "<<Division((Multiplicacion(a,b)),2);
        validar=true;
        break;
    case 4:
        /* Rectangulo*/
        cout<<"\n Area del "<<titulos[operacion-1];
        Beep(1568,200);
        cout<<"\nIngrese la Base\n-->>";
        cin>>a;
        cout<<"\nIngrese la Altura\n-->>";
        cin>>b;
        
        cout<<"\nEl area del rectangulo de base "<<a<<" y altura "<<b<<" es de "<<Multiplicacion(a,b);
        validar=true;
        break;           
    
    default:
        
        system("cls");
        Beep(160,20);
        Beep(150,20);
        cout<<"Ingrese una opcion valida recuerde la lista de opciones \n1:suma 2:resta 3:multiplicacion 4:division\n-->>";
        cin>>operacion;
        
        break;
    }
		
    
	}
    
    
}

/*Cuadratica*/
void Cuadratica(){
	
	bool validar=false;
	float raiz=0;
	float x1=0;
	float x2=0;
	
	Iniciar();
	cout<<"Ingresa los valores teniendo en cuenta ax^2+bx+c\n\n";	
	cout<<"Ingrese a\n-->>";
	cin>>a;
	cout<<"Ingrese b\n-->>";
	cin>>b;
	cout<<"Ingrese c\n-->>";
	cin>>c;
	
	while(a==0){
		
		system("cls");
		Beep(160,200);
        Beep(150,200);
        cout<<"a="<<a<<"  b="<<b<<"  c="<<c;
		cout<<"\n\na no puede ser igual a 0\n\n Ingrese un nuevo valor de a\n\n-->>";
		cin>>a;
		
	}
	
	if((b*b-(4*a*c))<0){
		Beep(1568,200);
		cout<<"\n\nNo es posible sacar raiz cuadrada de un numero negativo, por lo tanto la cuadratica no tiene solucion ";
	}else{
		
		raiz= sqrtf(b*b-4*a*c);
		
		x1=(-b+raiz)/(2*a);
		x2=(-b-raiz)/(2*a);
		
		cout<<"\n\nSiendo  "<<"a="<<a<<"  b="<<b<<"  c="<<c<<" entonces "<<"x1="<<x1<<" x2="<<x2;
		
		
	}
	
	
	
	
	
}

/*Descompocision de un numero*/
void Descomponer(){
	
	Iniciar();
	
	num=0;
	int contador=0;
	int sumatoria=0;
	
	cout<<"Ingrese el numero que desea descomponer\n-->>"; 
	cin>>num;
	contador=0; 
	sumatoria=num; 
	
	while(sumatoria>0){
		sumatoria/=10;
		contador++;
	}
	
	sumatoria=0;
 	int digitos[contador];
 	
	for(int i=0,j=num;i<=contador-1;i++){
		digitos[i]=j%10;
		sumatoria+=j%10;
		j/=10;

	}
	
	cout<<"\n\nEl numero >>"<<num<<"<< tiene "<<contador<<" digitos que sumados dan "<<sumatoria;	
}

/*fibonacci*/
void Fibonacci(){
	
	Iniciar();
	cout<<"\nIngrese la cantidad de digitos de la secuencia que desea imprimir\n-->>";
	cin>>num;
	int actual,anterior,duplicado;
	actual=0;
	anterior=0;
	duplicado=0;
	for(int i=1;i<=num;i++){
	
		actual=anterior+duplicado;
		cout<<actual<<"--";
		anterior=duplicado;
		duplicado=actual;
		if(actual==0){
		duplicado=1;
		}
		
	}
}

/*numeros primos*/
void Primos(){
	
	Iniciar();
	int contador=0;
	cout<<"\nIngrese el numero a evaluar\n-->>";
	cin>>num;
	
	for(int i=num;i > 0;i--){
		if(num%i==0){
			contador+=1;
		}
	}
	
	if(contador>2){
		cout<<"\nEl numero "<<num<<" no es un numero primo";
	}else{
		cout<<"\nEl numero "<<num<<" es un numero primo";
	}
	
}

/*Factorial*/
void Factorial(){
	
	Iniciar();
	cout<<"\nIngrese el numero a evaluar \n-->>";
	cin>>a;
	b=1;
	
	for(int i=a;i>0;i--){
		b=b*i;
	}
	
	cout<<"\nEl factorial de "<<a<<" es "<<b;
	
	
	
}

/*operaciones entre dos numeros*/
void Operaciones(){
	
	Iniciar();
	cout<<"Ingrese los dos numeros a operar \na-->";
	cin>>a;
	cout<<"\nb-->";
	cin>>b;
	system("cls");
	cout<<"Sus numeros son "<<a<<" y "<<b<<" sus operaciones son:"<<endl;
	cout<<a<<"+"<<b<<"="<<Suma(a,b)<<endl;
	cout<<a<<"-"<<b<<"="<<Resta(a,b)<<endl;
	cout<<a<<"x"<<b<<"="<<Multiplicacion(a,b)<<endl;
	
	if(b==0){
		cout<<"\n\n!!La division entre 0 no es posible por lo tanto >>>> ";
		cout<<a<<"/"<<b<<"="<<"NULL<<<<< !!";
	}else{
		cout<<a<<"/"<<b<<"="<<Division(a,b)<<endl;
	}
	
	
}

/*Mayor y menor*/
void MayorMenor(){
	
	Iniciar();
	cout<<"\nCuantos numeros desea evaluar?\n-->>";
	cin>>num;
	a=0; /*mayor*/
	b=1000000000; /*menor*/
	c=0; /*actual*/
	
	for(int i=0;i<num;i++){
		
		cout<<"Ingrese el numero "<<i+1<<" \n-->";
		cin>>c;
		
		if(c>a){
			a=c;
		}
		if(c<b){
			b=c;
		}
		

		
	}
			cout<<"\nEl Numero mayor es "<<a<<"\nEl Numero menor es "<<b;
	
	
}

/*generar impares*/
void Impares(){
	Iniciar();
	cout<<"\nCuantos impares desea ver?\n-->>";
	cin>>num;
	a=1;
	cout<<"\nImpares :";
	for(int i=1;i<=num;i++){
		cout<<a<<"\t";
		a+=2;
	}
	
	
	
	
}


void DoraemonSong(){
	
Beep(220,300);
cout<<"-";
Beep(294,300);
cout<<"-";
Beep(294,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(440,800);
cout<<"-";

  /* */

Beep(440,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(440,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(392,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(330,800);
cout<<"-";

  /* */

Beep(247,300);
cout<<"-";
Beep(330,300);
cout<<"-";
Beep(330,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(555,300);
cout<<"-";
Beep(555,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(440,300);
cout<<"-";
Beep(392,800);
cout<<"-";
Beep(392,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(247,800);
cout<<"-";
Beep(278,300);
cout<<"-";
Beep(294,300);
cout<<"-";
Beep(330,2600);
cout<<"-";

  /* */

Beep(220,300);
cout<<"-";
Beep(294,300);
cout<<"-";
Beep(294,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(440,800);
cout<<"-";

  /* */

Beep(440,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(440,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(392,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(330,800);
cout<<"-";

  /* */

Beep(247,300);
cout<<"-";
Beep(330,300);
cout<<"-";
Beep(330,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(555,300);
cout<<"-";
Beep(555,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(440,300);
cout<<"-";
Beep(392,800);
cout<<"-";
Beep(392,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(278,600);
cout<<"-";
Beep(330,600);
cout<<"-";
Beep(294,2600);
cout<<"-";

  /* */
  
Beep(494,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(440,300);
cout<<"-";
Beep(392,200);
cout<<"-";
Beep(440,200);
cout<<"-";
Beep(494,200);
cout<<"-";
Beep(440,800);
cout<<"-";
Beep(330,300);
cout<<"-";
Beep(370,300);
cout<<"-";
Beep(416,300);
cout<<"-";
Beep(330,300);
cout<<"-";
Beep(440,2000);
cout<<"-";

  /* */

Beep(494,800);
cout<<"-";
Beep(440,800);
cout<<"-";
Beep(392,1600);
cout<<"-";

  /* */
  
Beep(555,300);
cout<<"-";
Beep(555,300);
cout<<"-";
Beep(555,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(440,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(440,300);
cout<<"-";
Beep(392,1400);
cout<<"-";

  /* */

Beep(440,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(370,1100);
cout<<"-";
Beep(330,300);
cout<<"-";
Beep(294,1800);
cout<<"-";

  /* */

Beep(494,800);
cout<<"-";
Beep(440,800);
cout<<"-";
Beep(392,1600);
cout<<"-";

  /* */

Beep(555,300);
cout<<"-";
Beep(555,300);
cout<<"-";
Beep(555,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(440,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(440,300);
cout<<"-";
Beep(392,1400);
cout<<"-";

  /* */

Beep(440,300);
cout<<"-";
Beep(494,300);
cout<<"-";
Beep(370,1100);
cout<<"-";
Beep(330,300);
cout<<"-";
Beep(294,1800);
cout<<"-";
}


int main()
{
    do
    {
        
    system("cls");
	cout<<"\n\tIngrese la opcion que desee \n1:Operaciones Basicas\t\t6:Numero primo\n2:Areas\t\t\t\t7:Factorial\n3:Cuadratica\t\t\t8:Operaciones\n4:Descomponer un numero\t\t9:Mayor y menor\n5:Fibonacci\t\t\t10:Impares\n\n-->>";
    cin>>opcion;
	
	while(opcion>10 || opcion<1){
	
		system("cls");
		
		cout<<"!!!! RECUERDE INGRESAR ALGUNA DE LAS OPCIONES DISPONIBLES !!!!\n\n\n\n";
		cout<<"\n\tIngrese la opcion que desee \n1:Operaciones Basicas\t\t6:Numero primo\n2:Areas\t\t\t\t7:Factorial\n3:Cuadratica\t\t\t8:Operaciones\n4:Descomponer un numero\t\t9:Mayor y menor\n5:Fibonacci\t\t\t10:Impares\n\n-->>";
    	cin>>opcion;
		
	}
	
	
    switch (opcion)
    {
    case 1: 
        /* Operaciones Basicas*/
        Calcular();
        break;
    
    case 2:
        /* Areas*/
        Areas();
        break;
    case 3:
        /* Cuadratica */
        Cuadratica();
        break;
    case 4:
    	/*Descomponer un numero*/
    	Descomponer();
    
        break;
    case 5:
        /* Fibonacci */
        Fibonacci();
        break;                        
    case 6:
        /* Primos*/
        Primos();
        break;
    
    case 7:
        /* Factorial */
        Factorial();
        break;
    case 8:
        /* Operaciones */
        Operaciones();
        break;
    case 9:
        /* Mayor y menor*/
        MayorMenor();
        break;
    case 10:
        /* Impares*/
        Impares();
        break;    
        

    default:
        break;
    }
    
    
    
    
    cout<<"\n\n\n\n\nDesea seguir ejecutando el programa??\n\n\n\nPara continuar ingrese S/s\t\tPara salir ingrese N/n\n-->>";
    
    cin>>continuar;
    
    
      
    
    }while(continuar== 'S' || continuar== 's');
    system("cls");
    cout<<"\n\n\nPrograma Realizado por: Andres Felipe Vargas para la asignatura de Introduccion a la ingenieria de software ";
    DoraemonSong();
    return 0;
}


