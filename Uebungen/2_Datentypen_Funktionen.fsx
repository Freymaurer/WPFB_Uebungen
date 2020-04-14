
//      Excercise 2


//************************************************************************************
//*                                                                                  *
//* Datentypen und Funktionen                                                        * 
//*                                                                                  *
//************************************************************************************


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////      TASKS for Excercise 2       ///////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//++++++++++++++++++++++++++++
//          Tuples           +
//++++++++++++++++++++++++++++

// Task 1.1:  -----------------------------------------------------------------------------------------
// Deklariere einen Tuple aus dem float 2. und dem string "Februar" und bindet den Tuple an den Namen 'tuple1'.



// Task 1.2:  -----------------------------------------------------------------------------------------
// Deklariere einen Tuple aus 2., "Februar" und "Fruehling" und bindet ihn an den Namen 'tuple2'.



// Task 1.3:  -----------------------------------------------------------------------------------------
// Greife auf die zweite Variable des Tuples aus 1.1 zu.



// Task 1.4:  -----------------------------------------------------------------------------------------
// Greife auf die zweite Variable des Tuples aus 1.2 zu.



// Task 1.4:  -----------------------------------------------------------------------------------------
// Bindet 'tuple1' aus Task 1.1 an: (output1,output2).
// Warum kann das sinnvoll sein?
// Stichwort: Tuple Deconstruction



//++++++++++++++++++++++++++++
//      Record Types         +
//++++++++++++++++++++++++++++

// Task 2.1
// Definiere einen Record Type mit dem Namen 'Person1'. Person1 soll die Felder 'Name'(string) und 'Alter'(int) haben.
// Bei Record Types wird kein camel case, sondern pascal case verwendet (wie camel case nur ist der erste Buchstabe auch groß).



// Task 2.2
// Definiere einen weiteren Record Type mit dem Namen 'Person2'. Person2 soll die gleichen Felder wie Person1
// haben, bekommt aber noch das zusaetzliche Feld 'Hobby'. Da man alles zu seinem Hobby machen kann, soll
// 'Hobby' vom Typ generic type sein.



// Task 2.3
// Deklariere eine Funktion 'createPerson1' die zwei Inputparameter erhaelt und als Rueckgabewert eine Person1 gibt.
// Dann erstelle mit Hilfe dieser Funktion eine 'Person1' und binde sie an den Namen 'myPerson1'.



// Task 2.4
// Deklariere eine Funktion 'createPerson2' die drei Inputparameter erhaelt und als Rueckgabewert eine Person2 gibt.
// Dann binde ein Ergebnis dieser Funktion an den Namen 'myPerson2'. Benutze als Input fuer die Felder,
// die auch bei Person1 existieren, die Werte von meinePerson1.



//++++++++++++++++++++++++++++
//  Functional composition   +
//++++++++++++++++++++++++++++

// Task 3.1
// Die Funktion 'calculate' soll zwei Floats x und y miteinander verrechnen. Dafuer soll zuerst x - y berechnet werden und die
// daraus entstehende Differenz soll verdoppelt werden.
// Aber irgendentwas stimmt mit dem Ergebnis nicht. Ueberlege warum und korrigiere die Aufgabe ohne die Operatoren zu aendern.

let calculate x y =
    x
    |> (-) y
    // ignoriert die Verfärbung der zweiten Klammer des '(*)' Operators. Das ist ein anzeige Fehler von VS Code. (Verwechslung mit multi-line Kommentar '(*..*)') 
    |> (*) 2.

// Lösung



// Task 3.2
// Schreibe die folgende Funktion so um, dass sie den 'Compose' statt dem 'Pipe' Operator verwendet.

let chainOfCalculations x =
    x
    |> int
    |> (*) 2

// Lösung



// Task 3.3
// Deklariere eine Funktion mit 3 Inputparametern. Zwei davon sollen generischen Funktionen sein und einer ein generischer Wert.
// Die Funktion soll die gleiche Funktionalitaet wie der Compose Operator (>>) besitzen.
// Beispiel: compose fun1 fun2 wert = (fun1 >> fun2) wert



// Task 3.4
// Oh nein, die folgende Funktion ist ja total unleserlich! Schreib sie neu mit Pipe Operatoren!
// Tipp: ihr könnt das Ergebnis eurer leserlichen Funktion mit dem der unleserlichen Vergleichen, um grob zu überprüfen ob ihr alles richtig gemacht habt.

let unleserlicheFunktion x = (System.Double.Parse ((string(((*) 2. ((fun value -> value * 2.) x))**2.)) + "14"))

// Lösung



//++++++++++++++++++++++++++++
//   Higher Order Functions  +
//++++++++++++++++++++++++++++

// Task 4.1
// Deklariere eine anonyme Funktion die zwei Parameter bekommt und sie addiert. Binde sie an den Namen 'add'.
// Wende 'add' auf zwei Integer an.

// Wenn ihr in Visual Studio Code arbeitet, ignoriert im Folgenden erstmal Warnhinweise. So lange der Compiler keinen Error wiedergibt (rot unterstrichen) könnt ihr sie ganz normal testen.



