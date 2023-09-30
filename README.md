# Check Telefono
## Come svolgere al meglio il progetto :


### Scarichiamo la cartella Check Telefono e poi apriamo immediatamente visual studio con la cartella scaricata

### Notiamo subito che questo programma definisce una classe statica chiamata "Telefono" con un unico metodo pubblico chiamato "Check".
####
      public static string Check(string[] inputStr)
      
### Il metodo "Check" accetta un array di stringhe chiamato "inputStr" che restituisce una stringa.
####
        foreach(string input in inputStr)
        
#### Il metodo "Check" esegue una serie di controlli sulle stringhe di input per verificarne la correttezza come numero di telefono.
#### Questi sono i controlli :

###### Se la stringa di input inizia con "0039" e ha una lunghezza di 14 caratteri, viene restituita come risultato.
####
          if(input.StartsWith("0039") )
        {
            if(input.Length==14)
                return input;
        }
###### Altrimenti, se la stringa di input inizia con "+39" e ha una lunghezza di 13 caratteri, viene restituita come risultato.
######
         else if(input.StarstWith("+39") )
        {
            if(input.Length==13)
                return input;
        }
###### Altrimenti, se la stringa di input inizia con "3" e può essere convertita in un numero intero di 64 bit senza errori (tramite il metodo TryParse di Int64) perchè se mettavamo Int32 non ci stavano i numeri nella stringa, ha una lunghezza di 10 caratteri quindi con Int64 viene restituita come risultato.
######
        else if(input.StartsWith("3") )
        {
            Int64 valore = 0;
            bool eUnNumero = Int64.TryParse(input, out valore);
            if(eUnNumero)
                if(input.Length == 10)
                    return input;
        }
        
###### Se nessuno dei controlli passa, il metodo restituisce una stringa vuota.
###### 
        return "";
## Grazie per aver ascoltato la spiegazione scritta dall'alunno Ghinelli Johan V. , Alunno di Conti M. e Ugolini G.
