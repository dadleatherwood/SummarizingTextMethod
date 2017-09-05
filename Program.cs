using System;
using System.Collections.Generic;
namespace SummarizingTextMethod
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really long sentence.";
            var summary = StringUtility.SummarizeText(sentence);
            Console.WriteLine(summary);
        }
    }
}
