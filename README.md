Fast Expression Evaluator Library (c++, .net)
====

Yet another Expression Evaluator, but with **compilation** into **native code**
With this library you can evaluate math expressions fast and easily.

Get Started:
---
    var expression = new ExpressionEvaluator("sqrt(r^2 - x^2)");

    expression.SetVariableValue("r", 10);
    expression.SetVariableValue("x", 5);

    Console.WriteLine(expression.Execute());

Also you can see [Tests](https://github.com/DrA1ex/FEEL/tree/master/ExpressionEvaluator.Test), simple demo [project](https://github.com/DrA1ex/FEEL/blob/master/ExpressionCalculatorDemo/Program.cs), [benchmark](https://github.com/DrA1ex/FEEL/blob/master/ExpressionEvaluatorNetBenchmark/Program.cs), or advanced example [Curves Demo](https://github.com/DrA1ex/FEEL.CurveDemo).

Installation:
---
For all platforms:

FEEL require Visual C++ 2015 Redistributable. You can download it from here: https://www.microsoft.com/download/details.aspx?id=48145

For .NET version:

    Install-Package Feel.Net

For C++:
See [releases](https://github.com/DrA1ex/FEEL/releases) section

Features:
---

1. Easy extensible (you can add more operations if you want)
2. Fast (expression **compiling** into **native code**)
3. Powerful (you can use variables and change it without side effects)


At this point Expression Evaluator supports only Windows platform. 

Compile isn't perfect now, but more faster, than generic solution.

Some benchmarks:
---

```
Expression:     "(cos(x)^0.5*cos(200*x)+abs(x)^0.5-0.7)*(4-x^2)^0.01"
Start value:    -1.5
End value:      1.5
Steps:          1000000 (1m)

.NET Benchmark results:
Library name            Avg. time
FEEL (this library):    343.42 ms
Ciloci.Flee:            376.78 ms (9.72 % slower)
NCalc:                  3280.52 ms (855.26 % slower)

C# compiled code:       194.35 ms (43.41 % faster)

C++ Benchmark results:
Library name            Avg. time
FEEL (this library):    223.8 ms

C++ compiled code:      123.2 ms (81.3941% faster)
```

License:
---
The MIT License
