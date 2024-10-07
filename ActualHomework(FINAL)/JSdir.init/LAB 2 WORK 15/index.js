let s;
let a = Number(prompt("Enter the value of a:"));
let b = Number(prompt("Enter the value of b:"));

let x = Number(prompt("Enter the value of x:"));
let ElMax = Math.pow(x, 3); //Предположение
let ElMin = Math.sin(x) / x; //Предположение
let ElMax1 = Math.pow(a, x); //Предположение

if (x < 2)
{
    s = a * Math.sin(x) + b * Math.cos(x)
    console.log("s = " + s);
}
if (x > 3)
{
    if (ElMax < Math.exp(x))
    {
        ElMax = Math.exp(x);
    }
    if (ElMax < Math.pow(10, 3))
    {
        ElMax = Math.pow(10, 3);
    }
    s = ElMax;
    console.log("ElMin = " + ElMin);
    console.log("ElMax = " + ElMax);
    console.log("s = " + s);
}
else
{
    if (ElMin > ElMax1)
    {
        ElMin = ElMax1;
        if (ElMax1 < Math.pow(x, 3))
            {
                ElMax1 = Math.pow(x, 3);
            }
    }        
    if (ElMin > x * Math.pow(Math.log(), 2) * x)
    {
        ElMin = x * Math.pow(Math.log(), 2) * x;
    }
    s = ElMin;
    console.log("ElMin = " + ElMin);
    console.log("ElMax1 = " + ElMax1);
    console.log("s = " + s);
    
}
