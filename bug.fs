let mutable x = 0
let mutable y = 0

let rec loop i = 
    if i > 10 then ()
    else
        x <- x + 1; 
        y <- y + i; 
        loop (i+1)

loop 1
printf "x = %d, y = %d" x y