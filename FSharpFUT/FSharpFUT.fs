namespace FSharpFUT

module FSharpFUT =

    open Microsoft.FSharp.Data
    type FSharpFUT() = 
        member this.X = "F#"

    type Position = GK | RB | CB | LB | RWB | LWB | CDM | CM | CAM | RM | LM | RW | LW | CF | RF | LF | ST

    type PlayerInfo = {
        Position: Position;
        Country: string;
        League: string;
        Team: string;
        Loyalty: bool;
        Name:string
    }
    let defaultPlayer = {
        Position = GK;
        Country = "";
        League = "";
        Team = "";
        Loyalty = false;
        Name = "default"
    }

    
    type ManagerInfo = {
        League: string;
        Country: string;
    }

    type ChemistryPosition = {
        Position: Position
        Name: string;
        Links: string[];
        Index: int
    }
    
    type PlayerPosition = {
        Player: PlayerInfo;
        Position: ChemistryPosition
    }

    type Formation = {
        Name: string;
        Positions: ChemistryPosition list
    }

    type Squad = {
        Formation: Formation;
        Manager: ManagerInfo;
        Players: PlayerInfo list;

    }
    
    type SquadWithChemistry = {
        Squad: Squad;
        Chemistry: int[]
    }

    type LinkQuality = Bad=0 | Okay=1 | Good=2 | Perfect=3


    let ComputeLink (player1 : PlayerInfo, player2: PlayerInfo) = 
        match (player1, player2) with
        | _ when player1.Country = player2.Country && player1.League <> player2.League -> LinkQuality.Okay
        | _ when player1.Country = player2.Country && player1.League = player2.League && player1.Team <> player2.Team -> LinkQuality.Good
        | _ when player1.Country = player2.Country && player1.League = player2.League && player1.Team = player2.Team -> LinkQuality.Perfect
        | _ when player1.Country <> player2.Country && player1.League = player2.League && player1.Team = player2.Team -> LinkQuality.Good
        | _ when player1.Country <> player2.Country && player1.League = player2.League && player1.Team <> player2.Team -> LinkQuality.Okay
        | _ -> LinkQuality.Bad

    let ComputePositionQuality (normalPos:Position, currentPos:Position) =
        match (normalPos, currentPos) with
        | _ when normalPos = currentPos -> LinkQuality.Perfect
        | (RB, CB) | (RB, LB) | (RB, RM) -> LinkQuality.Okay
        | (RB, RWB) -> LinkQuality.Good
        | (LB, CB) | (LB, RB) | (LB, LM) -> LinkQuality.Okay
        | (LB, RWB) -> LinkQuality.Good
        | (CB, LB) | (CB, RB) | (CB, CDM) -> LinkQuality.Okay
        | (RWB, RB) -> LinkQuality.Good
        | (RWB, LWB) | (RWB, RM) | (RWB, RW) -> LinkQuality.Okay
        | (LWB, LB) -> LinkQuality.Good
        | (LWB, RWB) | (LWB, LM) | (LWB, LW) -> LinkQuality.Okay
        | (CDM, CM) -> LinkQuality.Good
        | (CDM, CAM) | (CDM, CB) -> LinkQuality.Okay
        | (CM, CDM) | (CDM, CAM) -> LinkQuality.Good
        | (CM, RM) | (CM, LM) -> LinkQuality.Okay
        | (CAM, CM) | (CAM, CF) -> LinkQuality.Good
        | (CAM, CDM) -> LinkQuality.Okay
        | (RM, RW) -> LinkQuality.Good
        | (RM, RB) | (RM, RWB) | (RM, CM) | (RM, CM) | (RM, LM) | (RM, RF) -> LinkQuality.Okay
        | (LM, LW) -> LinkQuality.Good
        | (LM, LB) | (LM, LWB) | (LM, CM) | (LM, CM) | (LM, RM) | (LM, LF) -> LinkQuality.Okay
        | (RW, RM) | (RW, RF) -> LinkQuality.Good
        | (RW, RWB) | (RW, LW) -> LinkQuality.Okay
        | (LW, LM) | (LW, LF) -> LinkQuality.Good
        | (LW, LWB) | (LW, RW) -> LinkQuality.Okay
        | (CF, CAM) | (CF, ST) -> LinkQuality.Good
        | (CF, RF) | (CF, LF) -> LinkQuality.Okay
        | (RF, RW) -> LinkQuality.Good
        | (RF, RM) | (RF, CF) | (RF, LF) | (RF, ST) -> LinkQuality.Okay
        | (LF, LW) -> LinkQuality.Good
        | (LF, LM) | (LF, CF) | (LF, RF) | (LF, ST) -> LinkQuality.Okay
        | (ST, CF) -> LinkQuality.Good
        | (ST, RF) | (ST, LF) -> LinkQuality.Okay
        | _ -> LinkQuality.Bad

    let ComputeChemistryNumber (links:float, pos:LinkQuality) =
        match (links, pos) with
        | (_, LinkQuality.Bad) when links < 0.3 -> 0
        | (_, LinkQuality.Bad) when links < float 1 -> 1
        | (_, LinkQuality.Bad) when links <= 1.6 -> 2
        | (_, LinkQuality.Bad) -> 2
        | (_, LinkQuality.Okay) when links < 0.3 -> 1
        | (_, LinkQuality.Okay) when links < float 1 -> 3
        | (_, LinkQuality.Okay) when links <= 1.6 -> 5
        | (_, LinkQuality.Okay) -> 5
        | (_, LinkQuality.Good) when links < 0.3 -> 2
        | (_, LinkQuality.Good) when links < float 1 -> 5
        | (_, LinkQuality.Good) when links <= 1.6 -> 8
        | (_, LinkQuality.Good) -> 9
        | (_, LinkQuality.Perfect) when links < 0.3 -> 3
        | (_, LinkQuality.Perfect) when links < float 1 -> 6
        | (_, LinkQuality.Perfect) when links <= 1.6 -> 9
        | (_, LinkQuality.Perfect) -> 10
        | _ -> 0

    let GetLinks (player1:PlayerInfo, players:PlayerInfo[]) =
         Seq.map (fun player -> ComputeLink(player1, player) |> float) players |> Seq.average


    let GetLinkPosChemistry (player1:PlayerInfo, pos:Position, players:PlayerInfo[]) = 
        let links = GetLinks(player1, players)
        let position = ComputePositionQuality(player1.Position, pos)
        ComputeChemistryNumber(links, position)

    let CapChemistry (x:int) = 
        match x with
            | _ when x > 10 -> 10
            | _ -> x
    
    let GetChemistry(player1:PlayerInfo, pos:Position, players:PlayerInfo[], manager:ManagerInfo) =
        match player1.Loyalty with
        | true ->
            match (player1, manager) with
            | (_,_) when player1.Country = manager.Country || player1.League = manager.League 
                -> 2 + GetLinkPosChemistry (player1, pos, players) |> CapChemistry
            | (_,_) -> 1 + GetLinkPosChemistry (player1, pos, players) |> CapChemistry
        | false ->
            match (player1, manager) with
            | (_,_) when player1.Country = manager.Country || player1.League = manager.League 
                -> 1 + GetLinkPosChemistry (player1, pos, players) |> CapChemistry
            | (_,_) -> GetLinkPosChemistry (player1, pos, players) |> CapChemistry


    
    let GetLinkedIndices (pos:ChemistryPosition, formation:Formation) =
        formation.Positions |> Seq.filter (fun position -> Seq.exists(fun x -> position.Name = x) pos.Links)  

    let GetLinkedPlayers (pos:ChemistryPosition, formation:Formation, players: PlayerInfo list) =
        Seq.filter (fun player -> 
            let index = Seq.findIndex(fun sPlayer -> player = sPlayer) players
            let positions = GetLinkedIndices(pos, formation)
            Seq.exists(fun position -> position.Index = index) positions) players |> Seq.toArray

    // let GetLinkedPlayers (pos:ChemistryPosition, players:PlayerInfo list) =
    //     Seq.map (fun index -> players.[index]) pos.Links |> Seq.toArray
    
    let ComputeSquadChemistry (squad:Squad) = 
        match squad with
        | _ when squad.Players.Length <> 11 -> null
        | _  -> squad.Players |> Seq.map (fun player ->
                let index = Seq.findIndex(fun sPlayer -> player = sPlayer) squad.Players 
                let position = squad.Formation.Positions.[index]
                let links = position.Links
                let playersLinked = GetLinkedPlayers (position, squad.Formation, squad.Players)
                GetChemistry(player, position.Position, playersLinked, squad.Manager)) |> Seq.toArray
 
    let GetSquadChemistry (squad:Squad) = 
        let chemistry = ComputeSquadChemistry squad
        {Squad = squad; Chemistry = chemistry}
