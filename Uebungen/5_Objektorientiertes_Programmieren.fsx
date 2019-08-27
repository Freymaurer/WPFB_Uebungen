//++++++++++++++++++++++++++++
//      Uebung 5             +
//++++++++++++++++++++++++++++

//++++++++++++++++++++++++++++
//  Function composition     +
//++++++++++++++++++++++++++++


//      Task 1
// Definiere einen Record Type mit dem Namen Geschwindigkeit und den Feldern EinheitStrecke und EinheitZeit vom Typ string, sowie dem Feld
// Wert vom Typ float. Im Anschluss definiere eine Funktion um den soeben definierten Record Type zu instanziieren (also ein Objekt zu erzeugen).



//      Task 2
// Definiere eine Funktion, welche den Wert eines Record Types aus dem Quotienten einer Strecke und Zeit berechnet und ein Objekt des Typs Geschwindigkeit
// mit diesem Wert erstellt. Die Felder EinheitStrecke und EinheitZeit können beliebig gewählt werden.



//      Task 3
// Defniere eine Klasse namens Motor mit den immutable member Eigenschaften Diesel vom Typ bool 
// und Verbrauch vom Typ float, die ihre Werte direkt vom primaeren Konstruktor erhalten.



//      Task 4
// Definiere ein Interface names Besitzer mit den Eigenschaften Name und Ort vom Typ string.



//      Task 5
// Definiere eine Klasse namens ProtoFahrzeug mit den Eigenschaften Geschwindigkeit (Record Type aus Task 1) und NumRaeder als int. 
// Sie soll außerdem ueber die Methode GeschwindigkeitÄndern mit dem Parameter value vom Typ float verfuegen. 
// Diese verändert die Eigenschaft Geschwindigkeit um den Wert des Parameters value.



//      Task 6
// Unser Fahrzeugt ist natürlich noch nicht fertig und muss noch "getuned" werden. Copy-Pasted Euer Ergebnis von Task 5 und bindest es an Fahrzeug.
// Implementiere das zuvor definierte Interface Besitzer.
// Erbe die zuvor definierte Klase Motor (Stichwort inherit).
// Der primaere Kosntruktor soll einen Parameter fuer alle member haben aber erstelle zusaetzlich einen alternativen Konstruktor, welcher einen vorgegebenen Wert fuer
// den Member Diesel hat. ( Stichwort new())



//      Task 6
// Definiere einen Typen names Auto, der von der Klasse Fahrzeug erbt. 
// Der Wert fuer den Parameter NumRaeder ist im primaeren Konstruktor bereits vorgegeben und im alternativen Kosntruktor
// auch der Wert fuer Diesel.



//      Task 7
// Definiere einen Typen names Motorrad, der von der Klasse Fahrzeug inherited. Der Wert fuer den Parameter NumRaed ist im primaeren Konstruktor bereits vorgegeben und im alternativen Kosntruktor
// auch der Wert fuer Diesel.



//      Task 8
// Definiere eine Funktion namens geschwindigkeitsTest mit dem Parameter 'grenze' vom Typ float und dem Parameter 'fahrzeug'. 
// Diese Funktion soll fuer alle Typen, welche von der Klasse Fahrzeug erben ueberpruefen, ob die Geschwindigkeit groeßer ist als die 'grenze'
// und wenn ja, eine Fehlermeldung mit "Die Geschwindigkeit ist zu hoch!" geben.



//      Task 9 (EXTRA)
// Erstelle ein Auto und ein Motorrad
// Schreibe beide in die gleiche Liste



//      Task 10 (EXTRA)
// Nimm die funktion aus Task 8.
// Wenn die Fehlermeldung gegeben wird fange diese ab und printe einen Bußgeldbescheid, der auf den Besitzer des Fahrzeugs ausgestellt ist.
// (open System wird hierfür benötigt)
