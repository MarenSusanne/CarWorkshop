﻿namespace CodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
            
        }
    }
}
/*
 Du skal lage et bilverksted. En bil kommer inn på verkstedet med en ukjent feil. 
En mekaniker blir nødt til å sjekke forskjellige bildeler for å se hvor feilen ligger, 
slik at han kan fikse det. Vis på skjermen hva som skjer skritt for skritt i prosessen
   
   ex: Car arriving at shop
         Mechanic checking engine 
         No faults in engine
         Mechanic checking breaks
         Faulty breaks
         Mechanic fixing breaks
         Car is now fixed and can be picked up by owner
 */