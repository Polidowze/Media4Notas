int notas;
int notafinal;
Console.WriteLine("--------------------Media4Notas--------------------");

Console.WriteLine("Digite as notas:");
notas = Convert.ToInt32(Console.ReadLine());

Console.Write("digite sua nota");
notas = Convert.ToInt32(Console.ReadLine());

Console.Write("digite sua nota");
notas = Convert.ToInt32(Console.ReadLine());

Console.Write("digite sua nota");
notas = Convert.ToInt32(Console.ReadLine());

if(notas > 5){

    Console.WriteLine("aprovado");
}

else(notas = 5){

    Console.WriteLine("Recuperação");
}

if (notas < 5){
    Console.WriteLine("Rrcuperação");
}

 int media = nota + (nota + (notafinal / 4)) ;