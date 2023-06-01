// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    //type safety  - tip guvenligi 
    string kategoriEtiketi = "Kategori";
    int ogrenciSayisi = 3222;
    double faizOrani = 1.45;
    bool sistemeGirisYapmisMi = true;

    Console.WriteLine(kategoriEtiketi);
    if (sistemeGirisYapmisMi == true)
    {
        Console.WriteLine("User Settings button");
    }
    else
    {
        Console.WriteLine("Login button") ;
    }
    

    
}