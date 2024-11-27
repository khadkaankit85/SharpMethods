type Coach = {
    Name: string
    FormerPlayer: bool
}

type Stats = {
    Wins: int
    Losses: int
}

type Team = {
    Name: string
    Coach: Coach
    Stats: Stats
}

let coach1 = { Name = "Quin Snyder"; FormerPlayer = true }
let coach2 = { Name = "Joe Mazzulla"; FormerPlayer = true }
let coach3 = { Name = "Jason Kidd"; FormerPlayer = false }
let coach4 = { Name = "Charles Lee"; FormerPlayer = false }
let coach5 = { Name = "Billy Donovan"; FormerPlayer = false }

let stats1 = { Wins = 7; Losses = 11 }
let stats2 = { Wins = 15; Losses = 3 }
let stats3 = { Wins = 10; Losses = 8 }
let stats4 = { Wins = 6; Losses = 11 }
let stats5 = { Wins = 8; Losses = 11 }

let team1 = { Name = "Atlanta Hawks"; Coach = coach1; Stats = stats1 }
let team2 = { Name = "Boston Celtics"; Coach = coach2; Stats = stats2 }
let team3 = { Name = "Dallas Mavericks"; Coach = coach3; Stats = stats3 }
let team4 = { Name = "Charlotte Hornets"; Coach = coach4; Stats = stats4 }
let team5 = { Name = "Chicago Bulls"; Coach = coach5; Stats = stats5 }

let teams = [team1; team2; team3; team4; team5]

let successfulTeams = teams |> List.filter (fun team -> team.Stats.Wins > team.Stats.Losses)

printfn "%s" "original teams are"
printfn "%A" teams
printfn "%s" "successful teams are"
printfn "%A" successfulTeams

let successPercentages = 
    successfulTeams 
    |> List.map (fun team -> 
        let wins = float team.Stats.Wins
        let losses = float team.Stats.Losses
        let percentage = (wins / (wins + losses)) * 100.0
        (team.Name, percentage)
    )
printfn "%s" "success percentages are"
printfn "%A" successPercentages

type Cuisine =
    | Korean
    | Turkish

type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks

type Activity =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int * float

let calculateBudget activity =
    match activity with
    | BoardGame -> 0.0
    | Chill -> 0.0
    | Movie movieType ->
        match movieType with
        | Regular -> 12.0
        | IMAX -> 17.0
        | DBOX -> 20.0
        | RegularWithSnacks -> 12.0 + 5.0
        | IMAXWithSnacks -> 17.0 + 5.0
        | DBOXWithSnacks -> 20.0 + 5.0
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70.0
        | Turkish -> 65.0
    | LongDrive (kilometers, fuelPerKilometer) -> float kilometers * fuelPerKilometer

let activity1 = Movie RegularWithSnacks
let activity2 = Restaurant Korean
let activity3 = LongDrive (100, 1.5)

let budget1 = calculateBudget activity1
let budget2 = calculateBudget activity2
let budget3 = calculateBudget activity3
let total=budget1+budget2+budget3


printfn "Budget for activity1: %f" budget1
printfn "Budget for activity2: %f" budget2
printfn "Budget for activity3: %f" budget3
printfn "total budget: %f" total
