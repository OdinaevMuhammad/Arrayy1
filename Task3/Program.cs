var list = new List<string>() {"mum", "amsterdam", "bloom"};

var linq = (from e in list
            where e.StartsWith("a") && e.EndsWith("m")
            select e).ToList();
            
            System.Console.WriteLine(string.Join(",",linq));
