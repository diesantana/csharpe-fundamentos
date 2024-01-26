

using OrientacaoAObjetosProperties;

Produto produto = new Produto("TV", 900.0, 10);

Console.WriteLine(produto.Nome); // TV

produto.Nome = "T"; // O VALOR NÃO É ACEITO 

Console.WriteLine(produto.Nome); // TV

produto.Nome = "TV 4K";

Console.WriteLine(produto.Nome);