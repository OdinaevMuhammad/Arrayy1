var list = new List<int>() {7, 2, 30};


var linq =list.Where(x=> x*x > 20).Select(x=> x*x);
            
            System.Console.WriteLine(string.Join(",",linq));
