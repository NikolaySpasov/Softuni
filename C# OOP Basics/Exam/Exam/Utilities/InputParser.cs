using System;
using System.Collections.Generic;

public class InputParser
{
    public List<string> parseInput(string inputLine)
    {
        return new List<String>(inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
    }
}