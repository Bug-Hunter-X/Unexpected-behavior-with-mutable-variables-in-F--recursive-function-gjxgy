let rec loop i accX accY = 
    if i > 10 then (accX, accY)
    else
        loop (i+1) (accX + 1) (accY + i)

let x, y = loop 1 0 0
printf "x = %d, y = %d" x y