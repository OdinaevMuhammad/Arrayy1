var list = new List<int>() {78, -9, 0, 23, 54, 21, 7, 86};


list.Sort();
list.Reverse();
var linq = list.Take(5);
            
            System.Console.WriteLine(string.Join(",",linq));
