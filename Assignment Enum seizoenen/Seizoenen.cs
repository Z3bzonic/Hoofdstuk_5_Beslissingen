using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Enum_seizoenen
{
    internal enum Seizoenen
    {
        // default op 0, geen invloed op de rest van de benoemde data tenzij je (Seizoen)0 had gebruikt. Dan is er nog steeds slechts één waarde te wijzigen.
        Default,
        Winter,
        Lente,
        Zomer,
        Herfst = 5
    }
}
