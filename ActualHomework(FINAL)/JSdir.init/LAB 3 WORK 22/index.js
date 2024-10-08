let y;

for (let x = -Math.PI; x <= Math.PI; x += Math.PI / 8) {
    y = Math.sin(4 * x) - 2
    console.log(" Y = ", + y)
    
}

console.log("--------------------------------------------");

let x = -Math.PI;

while (x <= Math.PI) {
    y = Math.sin(4 * x)- 2;
    x += Math.PI / 8;
    console.log(" Y = ", + y)
}



console.log("--------------------------------------------");

x = -Math.PI;

do {
    y = Math.sin(4* x) - 2;
    x += Math.PI / 8;
    console.log(" Y = ", + y)

} while (x <= Math.PI);
