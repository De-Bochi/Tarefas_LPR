Console.WriteLine("Escolha uma classe de personagem\n_________________\nGuerreira\nMago\nArqueira\n_________________");
String classe = Console.ReadLine();
if (classe == "Arqueira"||classe =="arqueira") {
Console.WriteLine("Suas habilidades são: Flecha Precisa, Disparo Triplo");
} else if(classe == "Mago"||classe == "mago"){
    Console.WriteLine("Suas habilidades são: Bola de Fogo, Escudo de Gelo");
} else if (classe == "Guerreira"|| classe == "guerreira"){
    Console.WriteLine("Suas habilidades são: Ataque Pesado, Defesa Total");
} else {
    Console.WriteLine("você escolheu uma classe inexistente.");
}