#load "FSharpFUT.fs"
#load "club.fs"
open FSharpFUT.FSharpFUT
open FSharpFUT.TestClub
let RobertLewandowski = {Position = ST; Country = "Poland"; League = "Bundesliga"; Team = "Bayern"}
let MarcoReus = {Position = LW; Country = "Germany"; League = "Bundesliga"; Team = "Dortmund"}
let PhillipLahm = {Position = RB; Country = "Germany"; League = "Bundesliga"; Team = "Bayern"}
let EdenHazard = {Position = LW; Country = "Belgium"; League = "13"; Team = "Chelsea"}
let RomeluLukaku = {Position = ST; Country = "Belgium"; League = "13"; Team = "Chelsea"}

let Mourinho:ManagerInfo = {League = "13"; Country = "1"}
let VanGaal:ManagerInfo = {League = "13"; Country = "2"}
let Low:ManagerInfo = {League = "Bundesliga"; Country = "Germany"}

let RobertMarco = ComputeLink (RobertLewandowski, MarcoReus)
let PhillipRobert = ComputeLink (RobertLewandowski, PhillipLahm)
let PhillipMarco = ComputeLink (PhillipLahm, MarcoReus)
let PhillipEden = ComputeLink (PhillipLahm, EdenHazard)
let EdenRomelu = ComputeLink (EdenHazard, RomeluLukaku)

let testlink1 = ComputeLink (player153079, player192366)
//Aguero, Otamendi

let test10Chem = GetChemistry (player153079, ST, [|player192366|], Mourinho, false)
let test10Chem2 = GetChemistry (player153079, ST, [|player192366; EdenHazard|], Mourinho, true)
let test10Chem3 = GetChemistry (player153079, ST, [|EdenHazard|], Low, true)
let test9Chem = GetChemistry (player153079, ST, [|EdenHazard|], Low, false)
let test3Chem = GetChemistry (player153079, ST, [|MarcoReus|], Low, false)
let test2Chem = GetChemistry (player153079, CF, [|MarcoReus|], Low, false)


