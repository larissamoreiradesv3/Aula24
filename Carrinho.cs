using System;
using System.Collections.Generic;

namespace Aula24
{
    public class Carrinho
    {
        //Propriedade criada para guardar o valor total dos produtos adicionados no carrinho
        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto>();
        
        //Metodo criado para adicionar os produtos no carrinho, observe que se passa o objeto como argumento
        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        } 
        //Metodo para remover produtos do carrinho
        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }
        //Metodo para visualizar os produtor que estão no carrinho
        public void Ler(){
            foreach (Produto item in carrinho){
                Console.WriteLine($"Nome: {item.Nome} - Preço: {item.Preco}");
            }
            
        }
        //Metodo para alterar produtos que estão dentro do carrinho
        public void Alterar(int _codigo, Produto _produtoAlterado){
            //Find é a ferramenta de busca, essse metodo serve para direcionar
            carrinho.Find(x => x.Codigo == _codigo).Nome = _produtoAlterado.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _produtoAlterado.Preco;
        }
        //Metodo para mostrar o valor total dos produtos
        public void MostrarTotal(){
            foreach (Produto item in carrinho){
                ValorTotal += item.Preco;
        }
        Console.WriteLine($"Valor total dos itens: R${ValorTotal}");
        Console.ResetColor();                 
        }

    }
}