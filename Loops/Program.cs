 // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

{
	

	//array - dizi
	string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı" , "java", "c#" };

    for (int i = 0; i < kurslar.Length; i++)
    {
        Console.WriteLine(kurslar[i]);
    }
    Console.WriteLine("For bitti");

    foreach (string kurs in kurslar) 
    { 
        Console.WriteLine(kurs);
    }       

    Console.WriteLine("End of the page - footer");

    
}