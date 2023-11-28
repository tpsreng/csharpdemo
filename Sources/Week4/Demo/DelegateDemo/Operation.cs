using System.Security.Cryptography.X509Certificates;

namespace DelegateDemo;
public class Operation
{
    public double _one = 0.0;
    public double _two = 1.0;

    public Operation() { }
    public Operation(double one, double two) {_one = one; _two = two; }

    public double GetOne() { return _one; }
    public double GetTwo() { return _two; }
    public double Result(Calculation calc)   {     return calc(_one, _two);   }
    public void View(List<Calculation> calculations)
    {
        foreach(var calc in calculations)
        {
            Console.WriteLine($"{calc.Method.Name}({this.GetOne()}, {this.GetOne()})=>{this.Result(calc)}");
        }
    }
}