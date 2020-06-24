using System;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
        //Inicio de um novo carrinho mas não se esqueça que não é esse método que ira adicionar os produtos no carrinho.
        Carrinho cart = new Carrinho();
        Produto p1 = new Produto(1, "Camiseta Adidas", 50.00f );
        Produto p2 = new Produto(2, "Camiseta Overcome", 70.00f );
        Produto p3 = new Produto(3, "Tênis Adidas", 250.00f );
        Produto p4 = new Produto(4, "Meia Adidas", 30.00f );
        Produto p5 = new Produto(5, "Moletom Overcome", 350.00f );
        
        //Agora sim os produtos serão adicionados
        cart.AdicionarProduto(p1);
        cart.AdicionarProduto(p2);
        cart.AdicionarProduto(p3);
        cart.AdicionarProduto(p4);
        cart.AdicionarProduto(p5);

        //Agora iremos remover um item do carrinho
        cart.RemoverProduto(p4);

        //Agora iremos adicionar um novo produto substituindo
        Produto p6 = new Produto(2, "Calça Adidas", 250.50f);
        cart.Alterar(1, p6);
        
        //Agora metodo para mostrar
        cart.Ler();
        //Agora card para mostrar o valor total
        cart.MostrarTotal();
        
        }
    }
}
