var list = new List<int>() {67,92,153,15};

var doit = list.Where(x=> x>30 && x<100 );

System.Console.WriteLine(string.Join(',',doit));