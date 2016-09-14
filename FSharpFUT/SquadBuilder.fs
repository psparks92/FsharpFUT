namespace FSharpFUT

open FSharpFUT

module SquadBuilder =

    let EvaluateSquad squad = 
        let squadWithChem = GetSquadChemistry squad
        squadWithChem.TotalScore