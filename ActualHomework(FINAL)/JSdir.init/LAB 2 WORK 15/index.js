let s;
let a = Number(prompt("Enter the value of a:"));
let b = Number(prompt("Enter the value of b:"));
let x = Number(prompt("Enter the value of x:"));

if (x < 2)
{
    s = a * Math.sin(x) + b * Math.cos(x)
    console.log("s = " + s);
}
if (x > 3)
{
    ElMax = Math.pow(x, 3)
    if (ElMax < Math.exp(x))
    {
        ElMax = Math.exp(x);
    }
    if (ElMax < Math.pow(10, 3))
    {
        ElMax = Math.pow(10, 3);
    }
    s = ElMax;
    console.log("ElMax = " + ElMax);
    console.log("s = " + s);
}
else
{
    ElMin = Math.sin(x)/x
    ElMax = Math.pow(a, x)
    if (ElMin > ElMax)
    {
        ElMin = ElMax;
        if (ElMax < Math.pow(x, 3))
            {
                ElMax = Math.pow(x, 3);
                s = Elmax;
                console.log("s = " + s);
                console.log("ElMin = " + ElMin);
                console.log("ElMax = " + ElMax);
            }
    }
    if (ElMin > x * Math.pow(Math.log(), 2) * x)
    {
        ElMin = x * Math.pow(Math.log(), 2) * x;
        s = ElMin;
        console.log("s = " + s);
        console.log("ElMin = " + ElMin);
        console.log("ElMax = " + ElMax);
    }
}
