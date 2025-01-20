using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Fractions
{
    // Create two atributes for top and bottom numbers and make them private
    private int _topNumber;
    private int _bottomNumber;

    // Constructor that has no parameters that initializes the number to 1/1
    public Fractions()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    // Constructor that has one parameter for the top and that initializes the
    // denominator to 1 (5/1)

    public Fractions(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }

    //Constructor that has two parameters, one for the top and one for the
    // bottom

    public Fractions(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public string GetFraction()
    {
        string text = $"{_topNumber}/{_bottomNumber}";
        return text;
    }

    public double GetDecimal()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }



}
