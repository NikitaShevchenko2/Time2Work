# Time2Work

# Time2Work
Eindwerk C# Developer


DOEL
Bij wijze van oefening is het de bedoeling een programma uit te werken waar werknemers hun beschikbaarheden in kunnen doorgeven. De bruikbaarheid hiervan ligt binnen sectoren waar vaak beroep wordt gedaan op jobstudenten en/of flexi's: retail, horeca. 
    Werknemer geeft momenten door waarop ze kunnen werken => Store manager/persoon die werschema's opmaakt heeft hier toegang toe => Plant in volgens beschikbaarheid => Werknemer krijgt uurrooster doorgestuurd.

FUNCTIONALITEITEN
1) - Werknemer kan in een agenda dagen/momenten aanduiden waarop ze kunnen werken;
2) - Persoon van de planning kan in de agenda raadplegen wie wanneer beschikbaar is;
3) - Jobstudenten kunnen maandelijks hun student@work-attest uploaden. Jobstudenten krijgen hier ook reminder van;
4) - Uurrooster wordt geupload en kan hier geconsulteerd worden
      => Werknemers (vast en variabel) krijgen hier melding van: nieuw uurrooster beschikbaar;
5) - Vast personeel: kan vrije dagen en vakanties aanvragen
      => Planning krijgt hier een melding van;
6) - Planning kan zien wanneer iemand voor het laatst heeft gewerkt en hoeveel uren ze hebben gepresteerd binnen een bepaalde periode
      => Gesprek over eventuele voorzetting van betrekking;
7) - Vast personeel kan aantal recup-uren raadplegen.

OPBOUW
3-tier: Data - Applicatie - Presentatie
5 layers: Database - DataAccess - Service -  MVC(Presentatie) - UnitTest

GEBRUIKTE PROGRAMMA'S
- VisualStudio 2022
  => Asp.NET CORE 8.0
  => EntityFrameWork
- Azure DevOps: https://dev.azure.com/nikibashevchenko/_git/EindWerkTime2Work
- VersionControl: GitHub: 

WORKFLOW
Ik heb gekozen om het project in te delen in verschillende fases waarbij er telkens functionaliteiten worden toegevoegd. De eerste fase betreft de MVP.
=> FASE 1
  Functionaliteiten 1 en 2 worden in de backend uitgewerkt en zouden volledig naar behoren moeten functioneren.
=> FASE 2
  Toevoegen van een verdere front-end uitbouw om aantrekkelijkheid aan het project toe te voegen.


FASE 1

- Opzetten structuur (Database, DAL, Service, Presentatie, UnitTests)
- Modellen uitwerken
- EntityFramework
- Repo's
- Services
- Unit tests
- Controllers maken (API)
- Api testen
- Unit tests verfijnen
