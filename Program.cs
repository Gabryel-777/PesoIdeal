
double Altura,  PesoIdeal;

string Gênero;

Console.Clear();

Console.WriteLine("---Descubra seu peso ideal de acordo com sua altura---");

Console.Write("Olá pessoa desconhecida, digite sua altura em metros, e descubra seu peso ideal:  ");
  
Altura = Convert.ToDouble(Console.ReadLine ());

Console .Write("Certo agora preciso saber seu sexo, caso você seja Homem digite (M), Caso seja mulher digite (F): ");

 
Gênero = (Console.ReadLine())!.ToUpper();


if (Gênero == "M")
{
    
Console.WriteLine("Certo então você é um homem iremos calcular seu peso ideal agora, peço que aguarde enquanto calculamos.");

PesoIdeal = Convert.ToDouble(1);

PesoIdeal =  (Altura * 72.7) - 58.0; 

Console.WriteLine($"\nE seu peso ideal é {PesoIdeal:N1}kg");
}
else if (Gênero == "F")
{
   
Console.WriteLine("Certo então você é uma mulher iremos calcular seu peso ideal agora, peço que aguarde enquanto calculamos.");

PesoIdeal = Convert.ToDouble(0);

PesoIdeal =  (Altura * 62.1) - 44.7; 

Console.WriteLine($"\nE seu peso ideal é {PesoIdeal:N1}kg");

}