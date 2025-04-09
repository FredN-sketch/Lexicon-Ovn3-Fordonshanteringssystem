using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem.SystemErrorHandling
{
    internal class TransmissionError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Växellådsproblem: Reparation krävs!";
        }
    }
}
