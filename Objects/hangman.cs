using System;
using System.Collection.Generic;

namespace Hangman.Objects
{
  public class HangmanGame
  {

    List<string> words = new List<string> {"career", "battle", "bridge", "regard", "margin", "desert", "global", "change", "extort", "manner", "string", "remain", "extent", "second", "killer"};

    List<string> allLetters = new List<string> {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

    List<string> guessedLetters = new List<string> {};

    List<string> correctGuesses = new List<string> {};

    List<string> displayList = new List<string> {"_","_","_","_","_","_"};


    public static Random random = new Random();

    int randomWordIndex = random.Next(words.Count);

    string wordToGuess = words[randomWordIndex];
    Char[] wordLetters = wordToGuess.ToCharArray();

    



    public void GuessLetter(string letter)
    {
      if (wordToGuess.Contains(letter))
      {
        foreach (string character in wordToGuess)
        {
          if (character == letter)
          {

          }
        }
      }
    }

  }
}
