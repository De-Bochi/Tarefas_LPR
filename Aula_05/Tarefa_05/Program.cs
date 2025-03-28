using System.Globalization;

Console.WriteLine("Quantas horas de treinamente por dia você fará?");
float x = Convert.ToSingle(Console.ReadLine());
float horas=0;
int dias=0, semanas=0,meses=0;
for(int i=1;horas<1000;i++){
    if(i==8) i=1;
    if(i==6||i==7){
         
    } else{
     dias++;
     horas+=x;
    }
    if(dias%22==0){
    meses++;
    dias=0;
   i=0;
} 

}semanas=dias/7;
dias=dias-(semanas*7);
Console.WriteLine("Começando na segunda você levará um total de "+dias+" dias, "+semanas+" semanas, "+meses+" meses trabalhando "+x+" horas por dia.");