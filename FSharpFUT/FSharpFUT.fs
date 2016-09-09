namespace FSharpFUT

module FSharpFUT =

    type FSharpFUT() = 
        member this.X = "F#"

    type PlayerInfo = {
        Country: string;
        League: string;
        Team: string
    }

    type LinkQuality = Bad | Okay | Good | Perfect

    let ComputeLink (player1 : PlayerInfo, player2: PlayerInfo) = 
        match (player1, player2) with
        | _ when player1.Country = player2.Country && player1.League <> player2.League -> Okay
        | _ when player1.Country = player2.Country && player1.League = player2.League && player1.Team <> player2.Team -> Good
        | _ when player1.Country = player2.Country && player1.League = player2.League && player1.Team = player2.Team -> Perfect
        | _ when player1.Country <> player2.Country && player1.League = player2.League && player1.Team = player2.Team -> Good
        | _ when player1.Country <> player2.Country && player1.League = player2.League && player1.Team <> player2.Team -> Okay
        | _ -> Bad
    