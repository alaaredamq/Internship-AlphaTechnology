﻿namespace Design_Pattern_Exercices.Proxy; 

public interface IMath
{
    double Add(double x, double y);
    double Sub(double x, double y);
    double Mul(double x, double y);
    double Div(double x, double y);
}