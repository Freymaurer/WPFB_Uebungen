#load @".paket\load\net47\FSharpAux.fsx"
#load @".paket\load\net47\FSharpAux.IO.fsx"
open FSharpAux
open FSharpAux.IO
let testData3Dimensions =
    Seq.fromFileWithSep '\t' (__SOURCE_DIRECTORY__ + "\..\Daten\heatmapData.txt")
    |> JaggedArray.ofJaggedSeq
    |> JaggedArray.map float