// "Console" -> on moodul C# mida me adresserime, Console aitav teha tegevusi käsureal  // .-> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit  
// "WriteLine"-> Funktsioon mida me parasjagu kasutame. // ()-> sulupaar ms omab funktsiooni tööks vajalikku infot   
// "Sisesta ostusumma" -> parameeter mis antakse funktsioonile WriteLine töölemiseks kaasa. //Lause lõppeb lauselõpumärgiga ;
Console.WriteLine("Sisesta ostusumma");


//  double ->Salvestab murdarvud. Piisav 15 kümnendkoha salvestamiseks. // "ostusumma" -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava  
// = -> üksik võrandusmärk omistab muutuja sisse vastava väärtuse mis asub //"double.Parse" -> on funktsioon, mis teisendab tekstiväärtuse arvuks. 
// . -> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit  // "ReadLine" -> funktsioon, mis ootab kasutajalt sisestust ja tagastab selle tekstina.
// ()  -> sulupaar ms omab funktsiooni tööks vajalikku infot //Lause lõppeb lauselõpumärgiga ";".
double ostusumma = double.Parse(Console.ReadLine());


//teeme tingimuslause if, ning selle tingimuse määrame ära sulgudega, mille vahel on  //võrdsuskontroll.  // "ostusumma"    -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava
// >  -> "on suurem kui". märgist vasakul pool olev objekt peaks  olema suurem, kui paremal pool olev objekt.  // 100 -> kontrollväärtus
// () -> sulupaar ms omab funktsiooni tööks vajalikku infot  
if (ostusumma > 100)
{
    Console.WriteLine("Saad 20% allahindlust");                                        // "Console"    -> on moodul C# mida me adresserime, Console aitav teha tegevusi käsureal // . -> näitab,
                                                                                       // et meil on vaja adresseerida mingisugust funktsiooni või meetodit     
                                                                                       // "WriteLine"  -> Funktsioon mida me parasjagu kasutame.// ()
                                                                                       // -> sulupaar ms omab funktsiooni tööks vajalikku infot      
                                                                                       // "Saad 20% allahindlust" -> parameeter mis antakse funktsioonile WriteLine töölemiseks kaasa.      
                                                                                       // Lause lõppeb lauselõpumärgiga ";". 
}
else if (ostusumma < 101 && ostusumma > 50) ;                                              //kaitstud sõnad "else" ja "if" (else if) kutsuvad elsile sekundaarse tingimuslause, mille tingimus 
                                                                                           //on saamamoodi sulgude vahel, ning millele pepab eelnema alat kas "if" või teine "else if".  // "ostusumma"    -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava  
                                                                                           // <  -> "on väiksem kui". Märgist vasakul pool olev objekt  peaks olema väiksem, kui paremal pool olev objekt.  
                                                                                           // 101   -> on võrdluspiir,mida kasutatakse tingimislause sees.  
                                                                                           // && -> "and" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) juhul kui  
                                                                                           //mõlemal pool "&&" märki olevad tingimused on täidetud. kui üks neist ei ole, siis annab negatiivse castuse (false).  
                                                                                           // "ostusumma"   -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava  
                                                                                           // >  -> "on suurem kui". märgist vasakul pool olev objekt peaks  olema suurem, kui paremal pool olev objekt.
                                                                                           // 50 -> on väärtus,mis omistatakse muutujale. //()-> sulupaar ms omab funktsiooni tööks vajalikku infot  
{
    Console.WriteLine("Saad 10% allahindlust. c: yay");                                      // "Console"    -> on moodul C# mida me adresserime, Console aitav teha tegevusi käsureal      
                                                                                             // . -> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit      
                                                                                             // "WriteLine"  -> Funktsioon mida me parasjagu kasutame.      
                                                                                             // () -> sulupaar ms omab funktsiooni tööks vajalikku infot       
                                                                                             // "Saad 10% allahindlust. c: yay" -> parameeter mis antakse funktsioonile WriteLine töölemiseks kaasa.      
                                                                                             // Lause lõppeb lauselõpumärgiga ";".  
}
else if (ostusumma < 51 && ostusumma > 20)                                                   //kaitstud sõnad "else" ja "if" (else if) kutsuvad elsile sekundaarse tingimuslause, mille tingimus  
                                                                                             //on saamamoodi sulgude vahel, ning millele pepab eelnema alat kas "if" või teine "else if".  
                                                                                             // "ostusumma"    -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava  
                                                                                             // <  -> "on väiksem kui". Märgist vasakul pool olev objekt  peaks olema väiksem, kui paremal pool olev objekt.  
                                                                                             // 51-> on alumine võrdluspiir teise tingimuse jaoks.  
                                                                                             // && -> "and" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true)
                                                                                             // juhul kui  // mõlemal pool "&&" märki olevad tingimused on täidetud. kui üks neist ei ole, siis annab negatiivse
                                                                                             // castuse (false).  // "ostusumma"    -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava  
                                                                                             // >  -> "on suurem kui". märgist vasakul pool olev objekt peaks  olema suurem, kui paremal pool olev objekt.  
                                                                                             // 20 -> on väärtus, mis omistatakse muutujale või mida kasutatakse arvutustes.  // () -> sulupaar ms omab funktsiooni tööks vajalikku info
{
    Console.WriteLine("5% allahindlust.");                                                   // "Console" -> on moodul C# mida me adresserime, Console aitav teha tegevusi käsureal      
                                                                                             // .-> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit      
                                                                                             // "WriteLine" -> Funktsioon mida me parasjagu kasutame.      
                                                                                             // ()    -> sulupaar ms omab funktsiooni tööks vajalikku infot       
                                                                                             // "5% allahindlust." -> parameeter mis antakse funktsioonile WriteLine töölemiseks kaasa.      
                                                                                             // Lause lõppeb lauselõpumärgiga ";".
}
else if (ostusumma < 21 && ostusumma > 0) ;                                                  //kaitstud sõnad "else" ja "if" (else if) kutsuvad elsile sekundaarse tingimuslause, mille tingimus  
                                                                                             //on saamamoodi sulgude vahel, ning millele pepab eelnema alat kas "if" või teine "else if".  
                                                                                             // "ostusumma" -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava  
                                                                                             // <  -> "on väiksem kui". Märgist vasakul pool olev objekt  peaks olema väiksem, kui paremal pool olev objekt.  
                                                                                             // 21  -> on alumine võrdluspiir teise tingimuse jaoks.  
                                                                                             // && -> "and" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true)
                                                                                             // juhul kui  // mõlemal pool "&&" märki olevad tingimused on täidetud.
                                                                                             // kui üks neist ei ole, siis annab negatiivse castuse (false).  
                                                                                             // "ostusumma -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava  
                                                                                             // >  -> "on suurem kui". märgist vasakul pool olev objekt peaks  olema suurem, kui paremal pool olev objekt.  
                                                                                             // 0   -> n väärtus, mis omistatakse muutujale või mida kasutatakse arvutustes.  
                                                                                             // ()  -> sulupaar ms omab funktsiooni tööks vajalikku infot  {


{
    Console.WriteLine("allahindlust ei saa");                                                // "Console" -> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit      
                                                                                            // "WriteLine"  -> Funktsioon mida me parasjagu kasutame.      
                                                                                            // ()  -> sulupaar ms omab funktsiooni tööks vajalikku infot      
                                                                                            // "allahindlust ei saa" -> parameeter mis antakse funktsioonile WriteLine töölemiseks kaasa.      
                                                                                            // Lause lõppeb lauselõpumärgiga ";".  }
}



//peale kõiki järel tingimusi on meil tingimuslause osa "else" mida täidatakse kõikide
//muude tingimuslause osade mittetäitumisel. siin eraldi tingimust välja ie kirjutada 
//ning sellest tulenevalt ei ole ka sulge . järgnrb ainult koodiplokk
else
{
    Console.WriteLine("sisestatud on vigane arv");                                           // "Console" -> on moodul C# mida me adresserime, Console aitav teha tegevusi käsureal      
                                                                                             // .   -> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit      
                                                                                             // "WriteLine" -> Funktsioon mida me parasjagu kasutame.      
                                                                                             // ()   -> sulupaar ms omab funktsiooni tööks vajalikku infot       
                                                                                             // "sisestatud on vigane arv" -> parameeter mis antakse funktsioonile WriteLine töölemiseks kaasa.      
                                                                                             // Lause lõppeb lauselõpumärgiga ";".  }
}












