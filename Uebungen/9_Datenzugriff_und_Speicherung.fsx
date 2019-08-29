//Dieser Codeblock dient zum laden der noetigen Abhaengigkeiten und Bibliotheken:
#load @"..\.env\.paket\load\net47\FSharp.Plotly.fsx"
#load @"..\.env\.paket\load\net47\FSharpAux.fsx"
#load @"..\.env\.paket\load\net47\FSharpAux.IO.fsx"
#load @"..\.env\.paket\load\net47\FSharp.Plotly.fsx"
#load @"..\.env\.paket\load\net47\FSharp.Data.TypeProviders.fsx"
#r @"..\.env\packages\FSharp.Data\lib\net45\FSharp.Data.dll"
#r @"..\.env\packages\SQLProvider\lib\net451\FSharp.Data.SqlProvider.dll"
#I @"..\.env\packages\System.Data.SQLite.Core\lib\net451"
#r @"..\.env\packages\System.Data.SQLite.Core\lib\net451\System.Data.SQLite.dll"

//Er muss idR. nicht geaendert werden. 
//Einmaliges laden der Zeilen per markieren -> Alt+Enter laedt per loadscript alle Abhaengigkeiten in die Konsole.
//Dies muss einmal pro Konsolen-Session getan werden.

open FSharp.Plotly
open FSharpAux
open FSharpAux.IO
open FSharpAux.IO.SchemaReader.Attribute

// 1:    Das Titanic.csv file in WPFB_Uebungen\Daten\ enth�lt die Folgenden Spalten:
//
//       PassengerId: int
//       Survived: bool
//       Pclass: int
//       Name: string
//       Sex: string
//       Age: int
//       SibSp: int
//       Parch: int
//       Ticket:string
//       Fare: float
//       Cabin: string
//       Embarked: string
//
//       Erstellen sie analog zur Vorlesung ein Datenmodell in Form eines Record Types f�r den Datensatz und lesen sie ihn ein.
//       W�hlen sie eine beliebige Eigenschaft des Datensatzes und visualisieren sie ihn.
//-----------------------------------------------------------------------------------------------------------------------------




// 2:    in \..\Daten\ liegt eine Beispieldatenbank. Ihr Schema und zus�tzliche Informationen sind hier erh�ltlich: 
//       https://www.sqlitetutorial.net/sqlite-sample-database/
//
// 2.1   Welche Daten enth�lt die Datenbank? Welche Relationen sind in der Datenbank? Was sind die jeweils abgebildeten Attribute?
//-------------------------------------------------------------------------------------------------------------------------------




// 2.2   Die folgenden Zeilen Code initialisieren einen SQL TypeProvider f�r die BeispielDatenbank.
//       Erstellen sie eine query, mit der sie alle Attribute einer Relation ihrer Wahl abfragen. Binden sie das Ergebnis an einen 
//       Namen.
//       Visualisieren sie dann das Ergebnis auf eine Art ihrer Wahl.
//-------------------------------------------------------------------------------------------------------------------------------

//Verbindungsstring f�r die Datenbank
[<Literal>]
let connectionString =
    "Data Source=" + 
    __SOURCE_DIRECTORY__ + @"\..\Daten\chinook.db"


open FSharp.Data
open FSharp.Data.Sql

//Initialisierter TypeProvider
type DataBase = SqlDataProvider<Common.DatabaseProviderTypes.SQLITE, connectionString>

//Das Datenmodell
let context = DataBase.GetDataContext()





// 3.1   Unter https://en.wikipedia.org/api/rest_v1/page/summary/ k�nnen sie per GET Request die Zusammenfassung von 
//       als JSON string Wikipediartikel anfragen.
//       
//       Erstellen sie zun�chst einen JsonProvider auf basis des "JSON" Artikels ("https://en.wikipedia.org/api/rest_v1/page/summary/JSON")
//       
//       Fragen sie dann die Zusammenfassung eines beliebigen Artikels ihrer Wahl ab und binden sie das Ergebnis an einen Namen.
//       Binden die Werte der 'Title' und 'Description' Felder jeweils an einen Namen
//-------------------------------------------------------------------------------------------------------------------------------



// 4.1   Erstellen sie eine Funktion mit der signatur int -> int -> int und den dazu equivalenten asynchronen Codeblock
//---------------------------------------------------------------------------------------------------------------------
// Async combo
open System.Threading





//async return
// 4.2   Mit #time k�nnen sie die Dauer, die die FSI zum ausf�hren von Codebl�cken ben�tigt, anzeigen lassen. 
//       Wenden sie die standard Funktion aus 4.1 auf alle eElemente einer Liste an. Diese sollte ausreichend gro� sein, 
//       damit eine messbare Zeit f�r die Ausf�hrung ben�tigt wird.
//       
//       Erstellen sie anschlie�end einen equivalenten Async<int[]> Block, den sie Parallel evaluieren. Dauert dies 
//       genausolange wie die vorhergehende Berechnung? Begr�nden sie etwaige Unterschiede
//---------------------------------------------------------------------------------------------------------------------
#time
