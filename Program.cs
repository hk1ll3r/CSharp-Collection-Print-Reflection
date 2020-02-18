using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using NoSuchStudio.Common;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 1 && args[0] == "-v") {
            ReflectionToStringExts.verbose = true;
        }
        // list
        Console.WriteLine("flat list");
        var strList = new List<string>() {"one", "two", "three"};
        Console.WriteLine("ToString: " + strList.ToString());
        Console.WriteLine("ToStringExt: " + strList.ToStringExt());
        Console.WriteLine("");

        // list of list
        Console.WriteLine("List of lists");
        var listOfLists = new List<List<string>>() { new List<string>() {"one", "two"}, new List<string>() {"three", "four"}};
        Console.WriteLine("ToString: " + listOfLists.ToString());
        Console.WriteLine("ToStringExt: " + listOfLists.ToStringExt());
        Console.WriteLine("");

        // list of list of list
        Console.WriteLine("List of Lists of Lists");
        var listOfListsOfLists = new List<List<List<string>>>() {
            new List<List<string>>() { new List<string>() {"one", "two"}, new List<string>() {"three", "four"}},
                new List<List<string>>() { new List<string>() {"five", "six"}, new List<string>() {"seven", "eight"}}};
        Console.WriteLine("ToString: " + listOfListsOfLists);
        Console.WriteLine("ToStringExt: " + listOfListsOfLists.ToStringExt());
        Console.WriteLine("");

        // dictionary
        Console.WriteLine("Dictionary");
        var flatDic = new Dictionary<int, string>() {
            [1] = "one",
            [2] = "two"
        };
        Console.WriteLine("ToString: " + flatDic);
        Console.WriteLine("ToStringExt: " + flatDic.ToStringExt());
        Console.WriteLine("");

        // dictionary of dictionary
        Console.WriteLine("Dictionary of Dictionaries");
        var dic2 = new Dictionary<int, Dictionary<string, string>>() {
            [1] = new Dictionary<string, string>() {
                ["one"] = "first",
                ["two"] = "second"
            },
            [2] = new Dictionary<string, string>() {
                ["three"] = "third",
                ["four"] = "forth"
            }
        };
        Console.WriteLine("ToString: " + dic2);
        Console.WriteLine("ToStringExt: " + dic2.ToStringExt());
        Console.WriteLine("");

        // dictionary of list
        Console.WriteLine("Dictionary of Lists");
        var dicOfList = new Dictionary<int, List<string>>() {
            [1] = new List<string>() {"one", "two"},
            [2] = new List<string>() {"three", "four"},
        };
        Console.WriteLine("ToString: " + dicOfList);
        Console.WriteLine("ToStringExt: " + dicOfList.ToStringExt());
        Console.WriteLine("");

        // list of dictionary
        Console.WriteLine("List of Dictionaries");
        var listOfDic = new List<Dictionary<int, string>>() {
            new Dictionary<int, string>() {
                [1] = "one",
                [2] = "two"
            },
            new Dictionary<int, string>() {
                [3] = "three",
                [4] = "four"
            }
        };
        Console.WriteLine("ToString: " + listOfDic);
        Console.WriteLine("ToStringExt: " + listOfDic.ToStringExt());
        Console.WriteLine("");

        // HashSet
        Console.WriteLine("HashSet");
        var hashSet = new HashSet<string>() {"one", "two", "three"};
        Console.WriteLine("ToString: " + hashSet.ToString());
        Console.WriteLine("ToStringExt: " + hashSet.ToStringExt());
        Console.WriteLine("");
    }
}
