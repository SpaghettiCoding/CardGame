﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Player
    {
        string player;
        Card[] hand = new Card[3];
        GameManagr gameMGMT = GameManagr.getInstance();
        int cardCount = 0;
        int cardCap = 4;
        int index = 0; //TODO: Create selection algorithm

        private void drawCard()
        {
            int cntr = index;
            index = cardCap - 1;           

            if (cardCount == 4 || cardCount == 5)
            {
                hand[index] = null;
            }

            while (cardCount < 4)
            {
                int topOfDeck = gameMGMT.playDeck.topOfDeck;
                hand[cntr] = gameMGMT.playDeck.deck[topOfDeck];
                cntr += 1;
                Console.WriteLine(printName() + " drew " + hand[cntr].print());
                gameMGMT.playDeck.topOfDeck -= 1;
            }
        }

        public string printName()
        {
            return player;
        }

    }

    
}
