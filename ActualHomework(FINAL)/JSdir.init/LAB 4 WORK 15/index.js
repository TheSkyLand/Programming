let a  = Number(prompt("Enter the value of a:"));
let b = Number(prompt("Enter the value of b:"));
let c = Number(prompt("Enter the value of c:"));
let p = (a + b + c) / 2;
let y = -c;
let oppositeC = Math.tan(y) / 2;
oppositeC = area(a, b, c);
console.log(area);
console.log(oppositeC);
function calculateArea(a, b, c,) {
    let area = Math.sqrt(p * (p - a) * (p - b) * (p - c));
    return area;
}
