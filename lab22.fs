printfn "siuuuuuuuuuuuuuuuuuu"
type DescriminatedUnionGenre= 
  | Horror
  | Drama
  | Comedy
  | Thriller
  | Fantasy
  | Sport

type Director ={Name:string; Movies: int}

type Movie= {Name:string; RunLength:int; Genre:DescriminatedUnionGenre; Director:Director;IMDBRating:float}

let CODA= { Name = "CODA"; RunLength = 112; Genre = Drama; Director = { Name = "Sian Heder"; Movies = 9 }; IMDBRating = 8.1 }
let Belfast= { Name = "Belfast"; RunLength = 99; Genre = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDBRating = 7.3 }
let DontLookUp= { Name = "Don't Look Up"; RunLength = 139; Genre = Comedy; Director = { Name = "Adam McKay"; Movies = 27 }; IMDBRating = 7.2 }
let DriveMyCar= { Name = "Drive My Car"; RunLength = 180; Genre = Drama; Director = { Name = "Rysuke Hamaguchi"; Movies = 16 }; IMDBRating = 7.6 }
let Dune= { Name = "Dune"; RunLength = 156; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDBRating = 8.1 }
let KingRichard= { Name = "King Richard"; RunLength = 145; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDBRating = 7.5 }
let LicoricePizza= { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; Movies = 49 }; IMDBRating = 7.4 }
let NightmareAlley= { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; Movies = 22 }; IMDBRating = 7.1 }

let movies = [CODA; Belfast; DontLookUp; DriveMyCar; Dune; KingRichard; LicoricePizza; NightmareAlley]

let possibleWinners=
   movies 
   |> List.filter(fun movie-> movie.IMDBRating > 7.4)

printfn "Name of the possible winners: "
possibleWinners |> List.map(fun winner -> winner.Name) |> printfn "%A"

// printfn "%A" possibleWinners

let movieLengths = movies|> List.map(fun movie-> movie.RunLength) 
printfn "%A" movieLengths

let convertToTime minute= 
  let hours= minute/60 
  let minutes=minute-hours *60  
  hours.ToString()+"h"+minutes.ToString()+"m"

movieLengths |> List.iter (fun length -> convertToTime length |> printfn "%s")
