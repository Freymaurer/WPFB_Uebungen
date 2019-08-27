
#load @"..\.env\.paket\load\net47\FSharp.Plotly.fsx"
#load @"..\.env\.paket\load\net47\FSharp.Stats.fsx"

open FSharp.Plotly
open FSharp.Plotly.Axis
open FSharp.Plotly.StyleParam
open FSharp.Stats

//Aufgabe 1 - Basic descriptive statistics
//1.1 Erstellt zwei Normalverteilungen mit mean=3 und stDev=2, bzw. mean=3 und stDev=0.5 und bindet sie an je einen Namen (Tip: nutzt das Distributions modul).

//1.2 Schreibt eine Funktion 'sampleFrom', die eine Verteilung und eine Stichprobengroesse als Parameter nimmt und eine entsprechend grosse Stichprobensequenz ausgibt.
//      Tip: Gebt dem Parameter 'verteilung' eine konkrete Typdeklaration: (xxx:Distributions.Distribution<float,float>)

//1.3 Erstellt von beiden Verteilungen Stichproben mit unterschiedlichen Stichprobengroessen (n:[2..100]) und berechnet jeweils den mean, sodass als Ergebnis zwei 
//Listen nach folgender Art entstehen (stichprobengroesse*mean) list

//1.4 Stellt die in 1.3 erstellten Sequenzen graphisch dar


//Extra: Fuehrt Aufgaben 1.3 und 1.4 mit Varianzen durch


//Aufgabe 2
//2.1 Es werden Oligonukleotide hergestellt. Die Wahrscheinlichkeit, dass die bestehende Kette mit dem korrekten Nukleotid bestueckt wird, betraegt 0.99. 
//Die enstehende Kette soll 100 Nukleotide lang sein.
//Wie wahrscheinlich ist es, dass alle Nukleotide korrekt sind?

//Aufgabe 3 - Verteilungen
//In einem Experiment werden 1000 Proteine gemessen. Die Abundanz von 200 Proteinen wird waehrend dem signifikant veraendert. 10 dieser Proteine sind Hitzeschockproteinen. Im Organismus gibt es 25 Hitzeschockproteine.
//Wie hoch ist die Wahrscheinlichkeit, dass 
//2.2. genau 10 Hitzeschockproteine durch Zufall unter den 200 signifikanten Proteinen sind?
//2.3. 10, oder mehr Hitzeschockproteine durch Zufall unter den 200 signifikanten Proteinen sind?
//Tip: Welches Urnenmodell liegt hier zugrunde?
//Extra: Visualisiert die PDF und CDF der erstellten Verteilung

   

//Aufgabe 4 - fold change
//4.1 Die Glucosekonzentration von Pflanzen wurde ermittelt. Zur Verfuegung steht eine Kontrolle und mehrere Mutanten mit den unten gezeigten Werten. Stellt die Verhaeltnisse graphisch dar. (Vernachlaessigt vorerst die Fehlerbalken)
//  Tip: evtl. braucht ihr das FSharp.Stats.Ops modul (nicht zwangslaeufig)
let ctrl = [4.;2.;3.;3.]
let mut1 = [1.;0.8;0.5;1.1]
let mut2 = [6.;7.;3.;5.;5.5]

//Aufgabe 5 - testing
//Unten seht ihr die Daten, die in der FSharp.Plotly Vorlesung zur Sprache kamen.
//5.1 gruppiert die Daten sinnvoll (tupel oder record) (Tip: Array.mapi koennte hilfreich sein)
//Fuehrt t tests durch (durchsucht FSharp.Stats.Testing)
//5.2 untersucht ob sich der Blutdruch von Rauchern signifikant von Nichtrauchern unterscheidet.
//5.3 untersucht ob sich das Gewicht von Rauchern signifikant von Nichtrauchern unterscheidet.
//5.4 untersucht ob sich das Alter von Rauchern signifikant von Nichtrauchern unterscheidet.
//EXTRA: Untersucht die mit Benjamnini-Hochberg adjusted p values mit einer FDR von 0.05.
let age = [|38;43;38;40;49;46;33;40;28;31;45;42;25;39;36;48;32;27;37;50;48;39;41;44;28;25;39;25;36;30;45;40;25;47;44;48;44;35;33;38;39;44;44;37;45;37;30;39;42;42;49;44;43;47;50;38;41;45;36;38;29;28;30;28;29;36;45;32;31;48;25;40;39;41;33;31;35;32;42;48;34;39;28;29;32;39;37;49;31;37;38;45;30;48;48;25;44;49;45;48;|]
let smoker = [|true;false;false;false;false;false;true;false;false;false;false;false;false;true;false;true;true;true;false;false;false;false;false;true;true;false;false;false;false;true;true;false;false;false;false;false;true;false;true;false;true;false;true;true;false;false;false;false;false;true;true;true;true;false;true;false;false;true;false;false;false;false;false;false;false;false;false;false;false;true;false;true;false;false;true;true;false;false;false;false;false;false;true;false;false;true;true;true;true;false;true;false;false;false;false;true;true;false;true;false;|]
let weight = [|176;163;131;133;119;142;142;180;183;132;128;137;174;202;129;181;191;131;179;172;133;117;137;146;123;189;143;114;166;186;126;137;138;187;193;137;192;118;180;128;164;183;169;194;172;135;182;121;158;179;170;136;135;147;186;124;134;170;180;130;130;127;141;111;134;189;137;136;130;137;186;127;176;127;115;178;131;183;194;126;186;188;189;120;132;182;120;123;141;129;184;181;124;174;134;171;188;186;172;177;|]
let bp = [|124;109;125;117;122;121;130;115;115;118;114;115;127;130;114;130;124;123;119;125;121;123;114;128;129;114;113;125;120;127;134;121;115;127;121;127;136;117;124;120;128;116;132;137;117;116;119;123;116;124;129;130;132;117;129;118;120;138;117;113;122;115;120;117;123;123;119;110;121;138;125;122;120;117;125;124;121;118;120;118;118;122;134;131;113;125;135;128;123;122;138;124;130;123;129;128;124;119;136;114;|]
