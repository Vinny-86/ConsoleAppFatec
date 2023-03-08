// See https://aka.ms/new-console-template for more information

using ConsoleAppFatec;

Produto P1 = new Produto("Sorvete", 1, 10);
Produto P2 = new Produto("Açaí", 2, 4.90M);
Produto P3 = new Produto("Notebook", 3, 500);
Produto P4 = new Produto("TV LG", 4, 250);
Produto P5 = new Produto("Carrinho", 5, 20);
Produto P6 = new Produto("Barbie", 6, 15);
Produto P7 = new Produto("Boné", 7, 256);

//Console.WriteLine(P1.Descricao + " valor: R$" + P1.Valor + "\n" + P2.Descricao + " valor: R$" + P2.Valor + "\n" + P3.Descricao + " valor: R$" + P3.Valor + "\n" + P4.Descricao + " valor: R$" + P4.Valor + "\n" + P5.Descricao + " valor: R$" + P5.Valor + "\n" + P6.Descricao + " valor: R$" + P6.Valor + "\n" + P7.Descricao + " valor: R$" + P7.Valor);

Console.WriteLine(P1.getDescricao());
Console.WriteLine(P1.getDescricao());
Console.WriteLine(P1.getDescricao());
Console.WriteLine(P1.getDescricao());
Console.WriteLine(P1.getDescricao());


//for (int i = 0; i < 250; i++)
//{
//    Produto produto = new Produto(i, 10 * i, "Produto" + i);
//    Console.WriteLine("Descricao" + produto.Descricao + "\t" + "Valor: RS" + produto.Valor);
//}