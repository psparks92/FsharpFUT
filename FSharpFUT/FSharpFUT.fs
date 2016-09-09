namespace FSharpFUT

module FSharpFUT =

    type FSharpFUT() = 
        member this.X = "F#"

    type PlayerInfo = {
        Country: string;
        League: string;
        Team: string
    }


    let ComputeLink (player1 : PlayerInfo, player2: PlayerInfo) = 
        match (player1, player2) with
        | _ when player1.Country = player2.Country && player1.League <> player2.League -> 1
        | _ when player1.Country = player2.Country && player1.League = player2.League && player1.Team <> player2.Team -> 2
        | _ when player1.Country = player2.Country && player1.League = player2.League && player1.Team = player2.Team -> 3
        | _ when player1.Country <> player2.Country && player1.League = player2.League && player1.Team = player2.Team -> 2
        | _ when player1.Country <> player2.Country && player1.League = player2.League && player1.Team <> player2.Team -> 1
        | _ -> 0
    