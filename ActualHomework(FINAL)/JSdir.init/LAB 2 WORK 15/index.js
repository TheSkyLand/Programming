let s;
let a = Number(prompt("Enter the value of a:"));
let b = Number(prompt("Enter the value of b:"));
let e = Number(prompt("Enter the value of e:"));
let x = Number(prompt("Enter the value of x:"));
let ElMax = Math.pow(x, 3);
let ElMin = Math.sin(x) / x;
let ElMax1 = Math.pow(a, x);

if (x < 2)
{
    s = a * Math.sin(x) + b * Math.cos(x)
    console.log("s = " + s);
}
if (x > 3)
{
    if (ElMax < Math.pow(e, x))
    {
        ElMax = Math.pow(e, x);
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
        ElMin = ElMax;
        if (ElMax1 < Math.pow(x, 3))
            {
                ElMax1 = Math.pow(x, 3);
            }
            if (ElMax1 < x * Math.pow(Math.log(x), 2))
            {
                s = ElMax1 = x * Math.pow(Math.log(x), 2);
            }
            console.log("ElMin = " + ElMin);
            console.log("ElMax1 = " + ElMax1);
            console.log("s = " + s);
    }
}
