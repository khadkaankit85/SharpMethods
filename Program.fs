
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let calculateTax salary = 
    let amount = float salary   
    if amount <= 49020 then amount * 0.15
    elif amount <= 98040 then amount * 0.205
    elif amount <= 151987 then amount * 0.26
    elif amount <= 216511 then amount * 0.29
    else amount * 0.33

let highSalaries = salaries |> List.filter (fun x -> x > 100000)
printfn "High-Income Salaries: %A" highSalaries
printfn "Origin Salaries: %A" salaries
printfn "----------------------------------------"


let taxAmounts = salaries |> List.map calculateTax
printfn "Taxes: %A" taxAmounts
printfn "Origin Salaries: %A" salaries

printfn "----------------------------------------"

let updatedLowSalaries = 
    salaries 
    |> List.filter (fun x -> x < 49020) 
    |> List.map (fun x -> x + 20000)
printfn "Updated Low Salaries: %A" updatedLowSalaries
printfn "Origin Salaries: %A" salaries
printfn "----------------------------------------"

let totalMidRangeSalaries = 
    salaries 
    |> List.filter (fun x -> x >= 50000 && x <= 100000)
    |> List.fold (fun acc x -> acc + x) 0
printfn "Total of Mid-Range Salaries: %d" totalMidRangeSalaries
printfn "Origin Salaries: %A" salaries
printfn "----------------------------------------"

let sumOfMultiplesOf3 n =
    let rec loop current sum =
        if current > n then sum 
        else loop (current + 3) (sum + current) 
    loop 3 0 

let result = sumOfMultiplesOf3 27
printfn "The sum of all multiples of 3 up to 27 is: %d" result

