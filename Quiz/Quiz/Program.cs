

Console.WriteLine("Välkommen till Zackarias quiz om Sverige");


//-------------------------------------------------------------------------------------
int poäng = 0;
string val1 = Console.ReadLine();

Console.Clear();
Console.WriteLine("Fråga 1:  Hur många bor i Sverige 2022?");
Console.WriteLine();
Console.WriteLine("Alternativ: 1 = [10 512 819] 2 = [Minst 2] 3 = [999 999] ");
val1 = getInput(new string[]{ "3", "1", "2", });



if (val1 == "2")
{
    poäng++;
    Console.WriteLine("Rätt svar!");

}

else 
{
    Console.WriteLine("Fel svar");

}




//--------------------------------------------------------------------------------

string val2 = Console.ReadLine();
Console.Clear();
Console.WriteLine("Fråga 2: Vad heter Sveriges huvudstad?");
Console.WriteLine();
Console.WriteLine("Alternativ: 1 = [Tokyo] 2 = [Köpenhamm] 3 = [Stockholm]");
val2 = getInput(new string[]{ "3", "1", "2", });


if (val2 == "3")
{
    poäng++;
    Console.WriteLine("Rätt svar!");
    
}


else
{
    Console.WriteLine("Fel svar");
  
}



//---------------------------------------------------------------------------------------------

string val3 = Console.ReadLine();

Console.Clear();
Console.WriteLine("Fråga 3: Vilket språk pratar man i Sverige?");
Console.WriteLine();
Console.WriteLine("Alternativ: 1 = [Sverige] 2 = [Ryska] 3 = [Svenska]");
val3 = getInput(new string[]{ "3", "1", "2", });


if (val3 == "3" )
{

poäng++;
Console.WriteLine("Rätt svar!");

}


else
{
   Console.WriteLine("Fel svar");

}


//-----------------------------------------------------------------------------------
Console.Clear();

Console.WriteLine($"Du fick {poäng} poäng");
if (poäng == 0)
{

Console.WriteLine("Du bor i Sverige men du kan inte svara på dessa frågor? Du borde plugga på om landet du bor i ");
}


else if (poäng < 3)
{
    Console.WriteLine("Antingen gissade du eller så klickade du random, för det finns helt ärligt ingen chans att du inte kunde svara på det här frågorna med full poäng");
}

else
{
    Console.WriteLine("Det är ganska självklart att kunna svara rätt på alla dessa frågor, men grattis ändå, alla rätt");
}

Console.WriteLine();
Console.WriteLine("Tryck på en knapp för att avsluta");
Console.ReadKey();


//-----------------------------------------------------------------------------------



string getInput(string[] allowedWords){
    bool wordFound = false;
    string input = "";
    while(!wordFound){
        input = Console.ReadLine();
        if(allowedWords.Contains(input)){
            wordFound = true;
        }
        else{
            Console.WriteLine("Inte ett av alternativen, försök igen");
        }   
    }
    return input;
}