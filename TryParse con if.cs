string inserire = Console.ReadLine(); // Legge il valore digitato dall'utente come stringa


// Tentativo di conversione dell'input dell'utente da stringa a intero
if (int.TryParse(inserire, out int eta)) // Serve per memorizzare l'età convertita da stringa a intero, dichiriamo la variabile int dentro l'if
{
    // Controlla se l'età è maggiore o uguale a 18
    if (eta >= 18)
    {
        Console.WriteLine("sei maggiorenne"); // Stampa "sei maggiorenne" se la condizione è vera
    }
    else
    {
        Console.WriteLine("minorenne"); // Stampa "minorenne" se la condizione è falsa
    }
}
else // Se il valore inserito non è un intero valido
{
    Console.WriteLine("errore"); // Stampa "errore"
