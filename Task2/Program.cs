var list = new List<string>() {"computer", "usb"};

var linq = (from e in list
            where e.Length > 5
            select e.ToUpper()).ToList();
            
            System.Console.WriteLine(string.Join(",",linq));
