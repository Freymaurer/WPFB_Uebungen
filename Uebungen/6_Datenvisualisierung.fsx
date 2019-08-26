//Dieser Codeblock dient zum laden der noetigen Abhaengigkeiten und Bibliotheken:
#load @"..\.env\.paket\load\net47\FSharp.Plotly.fsx"
#load @"..\.env\PlotlyData.fsx"
open PlotlyData
open FSharp.Plotly
//Er muss idR. nicht geaendert werden. 
//Einmaliges laden der Zeilen per markieren -> Alt+Enter laedt per loadscript alle Abhaengigkeiten in die Konsole.
//Dies muss einmal pro Konsolen-Session getan werden.

//Hilfe und Dokumentation der Funktionen von FSharp.Plotly finden sie hier: http://muehlhaus.github.io/FSharp.Plotly/



//==========================================================================//
//!!  Verwenden sie fuer alle Diagramme stets adequate Skalenbeschriftung  !!//
//!!                                                                      !!//
//!!  Verwenden sie auch mindestens einmal den dynamic object style       !!//
//!!  zum stylen ihrer Diagramme                                          !!//
//==========================================================================//

//1   Visualisierung von X/Y Beziehungen
//======================================

//1.1 Erstellen Sie eine Liste mit dem Namen 'xValues', welche die Werte von 0.0 bis (4 * PI) mit einer Schrittgroesse von 0.001 
//    enthaelt.
//---------------------------------------------------------------------------------------------------------------------------------



//1.2 Erstellen sie zwei Listen, die die passenden Funktionswerte von sin(x) und cos(x) fuer 'xValues' enthalten.
//---------------------------------------------------------------------------------------------------------------------------------



//1.4: Erstellen sie zwei Punkt- und zwei Liniendiagramme in denen sie die Werte von 'xValues' und die jeweiligen Funktionswerte
//     von sin(x) oder cos(x) auf je eine Positionsskala abbilden. Am Ende sollten sie 4 einzelne Diagramme haben.
//---------------------------------------------------------------------------------------------------------------------------------



//1.5: Kombinieren sie die Punkt- und Liniendiagramme aus 1.4. in einem einzigen Koordinatensystem (zu einem einzigen Diagramm mit
//     4 Unterdiagrammen). Warum ist das Resultat ein Diagramm mit einer zusaetzlichen Dimension?
//---------------------------------------------------------------------------------------------------------------------------------


//1.6: Visualisieren sie die (x,y) tuple in der folgenden Liste zunaechst mit einer linearen X und Y Skala.
//     Transformieren sie die Daten mit einer nichtlinearen Tranformation, die ihnen sinnvoll erscheint und visualisieren 
//     sie das Ergebnis. Tipp: sollten sie anstatt der Daten die Achse transformieren wollen: 
//     Chart.withY_Axis( Axis.LinearAxis.init(StyleParam.AxisType. ...)  )
//---------------------------------------------------------------------------------------------------------------------------------

let someData = [0. .. 1. .. 10.] |> List.map (fun x -> x,(10. ** x))

//2   Visualisierung von Anzahl/Groessen
//====================================

//2.1 Visualisieren sie die Abundanz verschiedener Haarfarben der Teilnehmer des Kurses. Falls keine Erhebung gemacht werden soll,
//    denken sie sich einen Datensatz mit 5 verschiedenen Haarfarben und 20 Probanden aus.
//---------------------------------------------------------------------------------------------------------------------------------



//2.2 Visualisieren sie die die Menge an erzeugten Terrawattstunden in Deutschland nach verschiedenen Energietraeger im Jahr 2018
//    https://de.wikipedia.org/wiki/Stromerzeugung
//---------------------------------------------------------------------------------------------------------------------------------



//2.3 Datenvisialisierung kann oft zur Erkennung von Mustern in einem Datensatz fuehren, die bei blosser Betrachtung der Werte 
//    nicht ersichtlich waeren, besonders wenn der Datensatz sehr gross und/oder mehrdimensional ist. 
//
//    Der vorbereitete Testdatensatz enthaelt 3 Dimensionen: die Indices des aeusseren Arrays, die Indices der inneren Arrays, und
//    die tatsaechlichen Zahlenwerte in den inneren Arrays. Visualisieren sie die drei Dimensionen mithilfe einer Heatmap.
//
//    Welche information koennte in den 3 Dimensionen kodiert sein? Beschriften sie die Skalen nach ihrer Einschaetzung.
//---------------------------------------------------------------------------------------------------------------------------------

//Das oben geladene Script (Zeile 3) laedt den Testdatensatz. Das Einlesen von Daten wird in spaeteren Uebungen behandelt.

//der Testdatensatz:
testData3Dimensions




//3   Visualisierung von Proportionen
//====================================

//3.1 Visualisieren sie das Ergebnis der Landtagswahl in einem beliebigen Bundesland.
//    https://de.wikipedia.org/wiki/Liste_der_letzten_Landtagswahlergebnisse_in_Deutschland
//---------------------------------------------------------------------------------------------------------------------------------



//3.2 Vergleichen sie die Stimmanteile aus 2.2 visuell mit mindestens 3 weiteren Landtagswahlergebnissen aus anderen Bundeslaendern.
//---------------------------------------------------------------------------------------------------------------------------------



//3.3: Visualisieren sie die Daten aus 2.2 als Anteil an der Gesamtstromerzeugung.
//---------------------------------------------------------------------------------------------------------------------------------



//4   Visualisierung von Geographischer Lage
//==========================================

//4.1: Visualisieren sie den Anteil der 16 bevoelkerungsreichsten Laender an der Gesamtbevoelkerung der Erde. 
//     https://de.wikipedia.org/wiki/Weltbev%C3%B6lkerung
//---------------------------------------------------------------------------------------------------------------------------------



//5   Bonus
//======================================================
//    Erstellen sie ein Klimadiagramm fuer Kaiserslautern
//    https://de.climate-data.org/europa/deutschland/rheinland-pfalz/kaiserslautern-2135/
//    Hierzu muessen verschiedene Charttypen miteinander kombiniert werden.