using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem.SystemErrorHandling
{
    internal class EngineFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Motorfel: Kontrollera motorstatus!";
        }
    }
}
