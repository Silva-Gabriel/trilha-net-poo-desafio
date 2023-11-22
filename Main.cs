using DesafioPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Program
    {
        static void Main() 
        {
            var iphone = new Iphone("1", "1", "1", 128);
            var nokia = new Nokia("1", "1", "1", 32);

            iphone.InstalarAplicativo("Digital Innovation One");
            nokia.InstalarAplicativo("Digital Innovation One");

            iphone.Ligar();
            nokia.Ligar();

            iphone.ReceberLigacao();
            nokia.ReceberLigacao();
        }
    }
}
