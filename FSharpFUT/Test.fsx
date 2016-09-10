#load "FSharpFUT.fs"
#load "formations.fs"
#load "club.fs"
#load "MyClub.fs"
open FSharpFUT.FSharpFUT
open FSharpFUT.Formations
open FSharpFUT.TestClub
open FSharpFUT.MyClub
let RobertMarco = ComputeLink (RobertLewandowski, MarcoReus)
let PhillipRobert = ComputeLink (RobertLewandowski, PhillipLahm)
let PhillipMarco = ComputeLink (PhillipLahm, MarcoReus)
let PhillipEden = ComputeLink (PhillipLahm, EdenHazard)
let EdenRomelu = ComputeLink (EdenHazard, RomeluLukaku)

let testlink1 = ComputeLink (player153079, player192366)
//Aguero, Otamendi

let test10Chem = GetChemistry (player153079, ST, [|player192366|], Mourinho)
let test10Chem2 = GetChemistry (player153079, ST, [|player192366; EdenHazard|], Mourinho)
let test10Chem3 = GetChemistry (player153079, ST, [|EdenHazard|], Low)
let test9Chem = GetChemistry (player153079, ST, [|EdenHazard|], Low)
let test3Chem = GetChemistry (player153079, ST, [|MarcoReus|], Low)
let test2Chem = GetChemistry (player153079, CF, [|MarcoReus|], Low)

let testSquadChemistry = GetSquadChemistry testSquad1

let testSquad2 = {
    Formation = formation3421;
    Manager = Low;
    Players = [ BerndLeno;  //GK
                RonaldoAparecidoRodrigues;  //LCB
                NicolásGaitán; //CB
                PhilippLahm; //RCB
                AndréSchürrle; //LM
                MarioGötze; //LCM
                ArturoVidal; //CAM
                RomeluLukaku; //RCM
                KevinMirallas; //RM
                ThomasMüller; //ST
                RobertLewandowski] //ST 
}   

let testSquad2Chemistry = GetSquadChemistry testSquad2


