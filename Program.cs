using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            // 
            // Practice: Dictionary of Words
            // 

            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Not Awesome", "The feeling of students when they start react");
            wordsAndDefinitions.Add("Confused", "The feeling of students when they are learning Javascript");


            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                // Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }





            /* 
            // Practice: List of Dictionaries about Words //
            */


            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> newExcitedWord = new Dictionary<string, string>();

            newExcitedWord.Add("word", "blah");
            newExcitedWord.Add("definition", "blah blah blah");
            newExcitedWord.Add("part of speech", "noun");
            newExcitedWord.Add("example sentence", "I am blah");

            /*
                Iterate your list of dictionaries and output the data,
                 You can use the two foreach() loops below to help you start your iteration.
            */

            dictionaryOfWords.Add(newExcitedWord);




            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            }

        }
    }
}
