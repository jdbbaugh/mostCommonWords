﻿using System;
using System.Collections.Generic;

namespace mostCommonWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookWords = "I went to Ellston Beach not only for the pleasures of sun and ocean, but to rest a weary mind. Since I knew no person in the little town, which thrives on summer vacationists and presents only blank windows during most of the year, there seemed no likelihood that I might be disturbed. This pleased me, for I did not wish to see anything but the expanse of pounding surf and the beach lying before my temporary home.";

            string[] wordsSplitUp = bookWords.Split(" ");

            List<string> wordsList = new List<string>();
            wordsList.AddRange(wordsSplitUp);

            List<Dictionary<string, int>> wordsDictionary =new List<Dictionary<string, int>>();


            foreach(string word in wordsList)
            {
                // Console.WriteLine(word);
                wordsDictionary.Add(new Dictionary<string, int>(){ {word, 0} });
            }

            foreach(Dictionary<string, int> wordProcessed in wordsDictionary)
            {
                foreach(KeyValuePair<string,int> kvp in wordProcessed)
                {
                    Console.WriteLine($"Key: {kvp.Key}  Value:{kvp.Value}");
                }
            }

        }
    }
}
