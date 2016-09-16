namespace FSharpFUT

open FSharpFUT
open Microsoft.FSharp.Reflection
module SquadBuilder =

    let EvaluateSquad squad = 
        let squadWithChem = GetSquadChemistry squad
        squadWithChem.TotalScore

    let GetCompatiblePositions (pos:Position) minQuality =
        let positions = [GK ; RB ; CB ; LB ; RWB ; LWB ; CDM ; CM ; CAM ; RM ; LM ; RW ; LW ; CF ; RF ; LF ; ST] |> seq<Position>
        Seq.filter (fun position -> ComputePositionQuality (pos, position) >= minQuality)  positions

    let GetAllForPosition (players:seq<PlayerInfo>) pos =
        let positions = GetCompatiblePositions pos LinkQuality.Okay
        Seq.filter (fun (player:PlayerInfo) -> Seq.exists(fun position -> player.Position = position) positions) players

    
    