var list = new List<string>() {"plane", "ferry", "car", "bike"};


var linq =list.OrderBy(x=> x).Last(x=> x.Contains("e"));
    System.Console.WriteLine(string.Join(",",linq));
