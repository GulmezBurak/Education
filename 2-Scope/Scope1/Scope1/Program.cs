﻿// See https://aka.ms/new-console-template for more information
Basla();

void Basla()
{
    int x = 100;
    Console.WriteLine("x in ilk değeri" + x);
    IkiyeKatla(x);
    Console.WriteLine("x metotdan sonraki değeri" + x);
}

void IkiyeKatla(int x)
{
    x = x * 2;
    Console.WriteLine("x in metod içi değeri" + x);
}