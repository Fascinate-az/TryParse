Console.WriteLine("inserire un numero");

bool isValid = int.TryParse (Console.ReadLine(),out int input) ;

Console.WriteLine(isValid  ?"è un numero":"non è un numero");

Console.ReadKey();


/////

Console.WriteLine("inserire un numero");

bool verifica = int.TryParse(Console.ReadLine(),out int valore);

Console.WriteLine(verifica ?(valore >=5?"è un numero maggiore o uguale a 5":"è minore di 5"):"non è un numero");

Console.ReadLine();
