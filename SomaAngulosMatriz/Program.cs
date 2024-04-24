/*
    Crie um programa que execute as seguintes funcionalidades em uma matrix quadrada:
    A) Soma de cada linha da matriz
    B) Soma de cada coluna da matriz
    C) Soma de cada diagonal da matriz
 */

Console.WriteLine("=====Manipulando Matrizes=====");

int qntlinhas = 3;
int qntColunas = 3;
int[,] matriz = new int[qntlinhas, qntColunas];
Random random = new Random();
int soma = 0;


// Criacao das matrizes 1 e 2
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        matriz[l, c] = random.Next(1, 4);

    }
}


Console.WriteLine("Matriz:");
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        Console.Write($"{matriz[l, c]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("=============================");


// Soma das matrizes
Console.WriteLine("Soma de cada linha:");
for (int l = 0; l < qntlinhas; l++)
{
    soma = 0;
    for (int c = 0; c < qntColunas; c++)
    {
        soma += matriz[l, c];
    }
    Console.WriteLine($"Linha[{l}] = {soma}");
}
Console.WriteLine("=============================");


// Soma das colunas
Console.WriteLine("Soma de cada coluna:");
for (int l = 0; l < qntlinhas; l++)
{
    soma = 0;
    for (int c = 0; c < qntColunas; c++)
    {
        soma += matriz[c, l];
    }
    Console.WriteLine($"Coluna[{l}] = {soma}");
}
Console.WriteLine("=============================");


// Soma das colunas
Console.WriteLine("Soma na direita pra esquerda:");
soma = 0;
for (int l = 0; l < qntlinhas; l++)
{
    soma += matriz[l, l];
}
Console.WriteLine($"Resultado = {soma}");
Console.WriteLine("=============================");


// Soma das colunas
Console.WriteLine("Soma na esquerda pra direita:");
soma = 0;

for (int linha = 0, coluna = qntColunas - 1; linha < qntlinhas; linha++, coluna--)
{
    soma += matriz[linha, coluna];
}
Console.WriteLine($"Resultado = {soma}");
Console.WriteLine("=============================");


Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();