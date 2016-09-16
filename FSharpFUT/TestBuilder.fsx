#load "FSharpFUT.fs"
#load "formations.fs"
#load "club.fs"
#load "MyClub.fs"
#load "SquadBuilder.fs"
open FSharpFUT.FSharpFUT
open FSharpFUT.Formations
open FSharpFUT.TestClub
open FSharpFUT.MyClub
open FSharpFUT.SquadBuilder

let positionsCompatibleWithCB = GetCompatiblePositions CB LinkQuality.Okay

printfn "%A" positionsCompatibleWithCB

let playersConsideredForCB = GetAllForPosition [RobertLewandowski; Danilo; JeromeBoateng] CB

printfn "%A" playersConsideredForCB

