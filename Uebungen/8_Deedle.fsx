#nowarn "211"
#r "../.env/packages/Deedle/lib/net45/Deedle.dll"
#load "../.env/packages/Deedle/Deedle.fsx"
#load @"..\.env\.paket\load\net47\FSharp.Plotly.fsx"
#load @"..\.env\.paket\load\net47\FSharp.Stats.fsx"

open Deedle
open FSharp.Plotly
open FSharp.Plotly.Axis
open FSharp.Plotly.StyleParam
open FSharp.Stats

//Aufgabe 1 - Deedle Basics
// 1.1 Mach dich mit Deedle vertraut! Im Folgenden findest du den Quellcode der in der Vorlesung verwendet wurde, erstelle selbst eine Series, die du zusaetzlich zum Frame 
// 'persons' hinzufuegst.
let firstNames      = Series.ofValues ["Kevin";"Lukas";"Benedikt";"Michael"] 
let coffeesPerWeek  = Series.ofValues [15;12;10;11] 
let lastNames       = Series.ofValues ["Schneider";"Weil";"Venn";"Schroda"]  
let group           = Series.ofValues ["CSB";"CSB";"CSB";"MBS"] 
let persons = Frame(["fN";"lN";"cpw";"g"],[firstNames;lastNames;coffeesPerWeek;group])
// 1.2 Folge dem obigen Schema und erstelle einen weiteren Frame der exakt gleich aufgebaut ist, allerdings andere Personen representiert (der Frame kann ruhig klein sein  z.b. zwei Personen)
// Nutze die Funktion Frame.merge um deinen Frame und 'persons' zu kombinieren
// 1.3 Zurueck zu dem Frame 'persons'! Im Folgenden siehst du eine Reihe von Frame/Series Manipulationen. Schreibe
// Kommentare die jeden Schritt erklaeren
let coffeePerWeek' :Series<int,int> = Frame.getCol ("cpw") persons 
let groupedByG :Frame<string*int,_> = persons |> Frame.groupRowsBy "g"
let withOutG :Frame<string*int,_> = groupedByG |> Frame.sliceCols ["fN";"lN";"cpw"]
let coffeePerWeek'' :Series<string*int,int>= groupedByG |> Frame.getCol ("cpw")
let coffeePerWeekPerGroup = Series.applyLevel Pair.get1Of2 (Series.values >> Seq.sum) coffeePerWeek''
// 1.4 Nun ist es Zeit externe Daten einzulesen. Benutze dafuer den statischen Member 'Frame.ReadCsv' und lese den Iris Datensatz.
// im auskommentierten Code Beispiel ist das verwendete Trennzeichen ('separators') nicht spezifiziert. Schau dir den Datensatz in einem 
// Texteditor an um das richtige Trennzeichen zu ermitteln

//let rawDataPath = @"...\Daten\irisData.tsv"
//let rawData :Frame<int,string> = Frame.ReadCsv(rawDataPath,separators=)

// 1.5 Speichere den Iris Frame unter einem anderen Namen und unter Verwendung eines anderen Trennzeichens (z.b. ',')

let nameAndCoffeCount = 
    persons
    |> Frame.mapRows (fun k s -> 
        s.GetAs<string>("fN"),s.GetAs<float>("cpw")
        )
    |> Series.values
    
//1.6 Konvertiert den Datensatz in eine Recordtypliste
type Flower = {
    SepalLength :float
    SepalWidth : float
    PetalLength: float
    PetalWidth : float
    Species :string}
    
let createFlower sl sw pl pw s = {
    SepalLength= sl
    SepalWidth = sw
    PetalLength= pl
    PetalWidth = pw
    Species    = s}
    
//Regression
//R1: Isoliere aus dem iris Datensatz die Werte von Petal length und Petal width als jeweils eine Collection
//let pl = //:float[]
//let pw = //:float[]

//R2: Stelle die Petal width in Abhaengigkeit der Petal length graphisch dar.

//R3: Erstellt eine lineare Regressionsgerade indem ihr
//R3.1: zuerst die Koeffizienten einer Linearen Regressionsgeraden ermittelt (s. Vorlesung)
//R3.2: ermittelt die fitting Funktion und wendet diese auf Werte eines geeigneten Definitionsbereichs an.
//R3.3: Stellt diese zusammen mit den Rohdaten graphisch dar.
//NOTFALLHILFE: https://csbiology.github.io/FSharp.Stats/Fitting.html
//EXTRA: Wiederholt das Fitting mit Polynomen unterschiedlicher Ordnung.


//Clustering
//C1: Isoliert euch die Daten von pl und pw, sodass sie folgendermassen sortiert sind. [[pl1;pw1];[pl2;pw2];...]


//C2: clustert eure daten mit DBSCAN
//Dazu nutzt die funktion FSharp.Stats.ML.Unsupervised.DbScan.compute
//Die passende Distanzfunktion findet ihr hier: FSharp.Stats.ML.DistanceMetrics
//Als Parameter nutzt: MinPts = 5 und eps = 0.3
//Die input Daten habt ihr in C1 schon passend angeordnet.


//C3: Stellt die Ergebnisse graphisch dar. Nutzt dazu die unten genannte Funktion und versucht sie zu verstehen.
//Benennt die Cluster (jedes Cluster soll einen eigenen namen haben) und Achsen
let irisChart (dbscan:ML.Unsupervised.DbScan.DbscanResult<float []>) = 
    let cluster = 
        dbscan.Clusterlist
        
    let noise = 
        dbscan.Noisepoints
        
    let chartCluster = 
        cluster
        |> Seq.mapi (fun clusterindex cluster -> 
            cluster
            |> Seq.map (fun x -> x.[0],x.[1])
            |> Chart.Point
            |> Chart.withTraceName (sprintf "cluster ..." )
            )
        |> Chart.Combine

    let chartNoise = 
        noise
        |> Seq.map (fun x -> x.[0],x.[1])
        |> Chart.Point
        
    [
    chartCluster 
    chartNoise |> Chart.withTraceName "xxx"
    ]
    |> Chart.Combine
    |> Chart.withX_AxisStyle "xxx"
    |> Chart.withY_AxisStyle "xxx"
    |> Chart.Show