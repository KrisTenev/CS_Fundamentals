// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

Dictionary<string, string> properties = new Dictionary<string, string>()
{
    { "key1", "value1" },
    { "key2", "value2" },
    { "key3", "value3" },
};

public enum DATATYPE
{ 
    Null = 0,
    One = 1,
    Two = 2,
    Three = 3,
}

Console.WriteLine(DATATYPE.One);

