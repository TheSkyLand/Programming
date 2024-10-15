let a = +prompt("Enter the value of a: ");
let b = +prompt("Enter the value of b: ");
let c = +prompt("Enter the value of c: ");
let p = (a + b + c) / 2;
let y = -c;
let oppositeC = Math.tan(y) / 2;
oppositeC = calculateArea(a, b, c);
console.log(oppositeC);
function calculateArea(a, b, c,) 
{
    return Math.sqrt(p * (p - a) * (p - b) * (p - c));
}
