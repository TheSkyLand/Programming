'use strict';


let x = Number(prompt("enter x = "));
let y = Number(prompt("enter y = "));
let a = 0.8 * Math.pow(10, -5) * Math.pow(x * Math.exp(-x * (y - 1.2)) - y * x, 3);
console.log(a);
