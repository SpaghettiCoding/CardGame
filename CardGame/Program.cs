﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class GameMain
    {
        private static GameManagr gameMGMT = new GameManagr();

        static void Main()
        {

            gameMGMT.startGame();
            
            
            
            /*Deck playDeck = new Deck();
            playDeck.createDeck();
            
            for(int i = 0; i < playDeck.deck.Length; i++)
            {
                playDeck.deck[i].PrintCard();
            }

            Console.ReadKey();
            Console.Clear();
            playDeck.Shuffle();

            for (int i = 0; i < playDeck.deck.Length; i++)
            {
                playDeck.deck[i].PrintCard();
            }

            Console.ReadKey();*/
        }
    }
}

