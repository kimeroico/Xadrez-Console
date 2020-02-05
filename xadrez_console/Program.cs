﻿using System;
using Tabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros tab = new Tabuleiros(8, 8);

            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 2));
            tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(3, 2));

            Tela.ImprimirTabuleiro(tab);
        }
    }
}
