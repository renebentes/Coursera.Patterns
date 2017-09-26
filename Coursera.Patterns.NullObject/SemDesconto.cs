using System;
using System.Collections.Generic;
using System.Text;

namespace Coursera.Patterns.NullObject
{
    public class SemDesconto : IDesconto
    {
        public double DarDesconto(double valorOriginal) => valorOriginal;
    }
}