#load "FSharpFUT.fs"
#load "club.fs"
open FSharpFUT.FSharpFUT
open FSharpFUT.TestClub
let RobertLewandowski = {Country = "Poland"; League = "Bundesliga"; Team = "Bayern"}
let MarcoReus = {Country = "Germany"; League = "Bundesliga"; Team = "Dortmund"}
let PhillipLahm = {Country = "Germany"; League = "Bundesliga"; Team = "Bayern"}
let EdenHazard = {Country = "Belgium"; League = "PremierLeague"; Team = "Chelsea"}
let RomeluLukaku = {Country = "Belgium"; League = "PremierLeague"; Team = "Chelsea"}

let RobertMarco = ComputeLink (RobertLewandowski, MarcoReus)
let PhillipRobert = ComputeLink (RobertLewandowski, PhillipLahm)
let PhillipMarco = ComputeLink (PhillipLahm, MarcoReus)
let PhillipEden = ComputeLink (PhillipLahm, EdenHazard)
let EdenRomelu = ComputeLink (EdenHazard, RomeluLukaku)

let test1 = ComputeLink (player153079, player192366)


