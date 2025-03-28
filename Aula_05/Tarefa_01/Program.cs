Console.WriteLine("Quantos números você irá digitar?");
int x= Convert.ToInt32(Console.ReadLine());
int c=0,np=0;
float pares=0;
if(x<1){
    Console.WriteLine("fim do código");
} else {
    Console.WriteLine("Digite-os separando por espaço");
    int [] n = Array.ConvertAll<string ,int>(Console.ReadLine().Split(' '),int.Parse);
  while(c<x){
   if(n[c]%2==0) {
   pares+=n[c];
   np++;
   }
   c++;
  }
  pares=pares/np;
  Console.WriteLine("A média aritmética dos números pares é "+pares);
  }
