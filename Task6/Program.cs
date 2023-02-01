var list = new List<string>() {"learn", "current", "deal"};


var linq =list.Select(x => x.Replace("ea","*"));
            
            System.Console.WriteLine(string.Join(",",linq));
