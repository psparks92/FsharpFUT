#load "FSharpFUT.fs"
#load "formations.fs"
#load "club.fs"
#load "MyClub.fs"
//#load "../packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"
open FSharpFUT.FSharpFUT
open FSharpFUT.Formations
open FSharpFUT.TestClub
open FSharpFUT.MyClub
//let RobertMarco = ComputeLink (RobertLewandowski, MarcoReus)
//let PhillipRobert = ComputeLink (RobertLewandowski, PhillipLahm)
//let PhillipMarco = ComputeLink (PhillipLahm, MarcoReus)
//let PhillipEden = ComputeLink (PhillipLahm, EdenHazard)
//let EdenRomelu = ComputeLink (EdenHazard, RomeluLukaku)
//
//let testlink1 = ComputeLink (player153079, player192366)
////Aguero, Otamendi
//
//let test10Chem = GetChemistry (player153079, ST, [|player192366|], Mourinho)
//let test10Chem2 = GetChemistry (player153079, ST, [|player192366; EdenHazard|], Mourinho)
//let test10Chem3 = GetChemistry (player153079, ST, [|EdenHazard|], Low)
//let test9Chem = GetChemistry (player153079, ST, [|EdenHazard|], Low)
//let test3Chem = GetChemistry (player153079, ST, [|MarcoReus|], Low)
//let test2Chem = GetChemistry (player153079, CF, [|MarcoReus|], Low)
//
// let testSquadChemistry = GetSquadChemistry testSquad1

let testPositionQuality1 = ComputePositionQuality (CB, CB)
let testPositionQuality2 = ComputePositionQuality (RonaldoAparecidoRodrigues.Position, CB)
let testPositionQuality3 = ComputePositionQuality (BerndLeno.Position, formation3421.Positions.[1].Position)

let testSquad2 = {
    Formation = formation3421;
    Manager = Low;
    Players = [ BerndLeno;  //GK
                RonaldoAparecidoRodrigues;  //LCB
                Dante; //CB
                JeromeBoateng; //RCB
                AndréSchürrle; //LM
                MarioGötze; //LCM
                ArturoVidal; //CAM
                RomeluLukaku; //RCM
                KevinMirallas; //LF
                ThomasMüller; //ST
                RobertLewandowski] //RF 
}   

let testSquad2Chemistry = GetSquadChemistry testSquad2


