'use strict';

let a;
let x = Number(prompt("enter x = "));
let y = Number(prompt("enter y = "));
let e = Number(prompt("enter e = "));
a = 0.8 * Math.pow(10, -5) * (x * Math.pow(Math.pow(e, -x*(y - 1.2) - y * x), 3));
console.log(a);