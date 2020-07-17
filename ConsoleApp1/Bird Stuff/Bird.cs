using NPOI.SS.Formula.Functions;
using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Bird
    {
        public abstract string Name { get; }
        public abstract Color Color { get; set; }
        public abstract string Call();
    }
}
