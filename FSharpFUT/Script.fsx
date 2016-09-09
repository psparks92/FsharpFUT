#load "FSharpFUT.fs"
open FSharpFUT

// Define your library scripting code here



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