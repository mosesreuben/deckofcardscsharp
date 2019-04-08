using System;

namespace deckofcards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck stack = new Deck();
            Player Bob = new Player("Bob");
            Console.WriteLine(stack.cards.Count);
        
            Bob.draw(stack);
            Console.WriteLine(Bob.hand.Count);
            Bob.draw(stack);
            Bob.draw(stack);
            Bob.draw(stack);
            Bob.draw(stack);
            Bob.draw(stack);
            Bob.draw(stack);
            Bob.draw(stack);
            Bob.draw(stack);
            Bob.draw(stack);
            Bob.draw(stack);
            Bob.draw(stack);
            Bob.draw(stack);            
        }
    }
}
