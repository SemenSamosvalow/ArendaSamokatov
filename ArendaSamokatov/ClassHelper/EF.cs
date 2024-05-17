using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArendaSamokatov.ClassHelper
{
    internal class EF
    {
        public static DB.VehicleRentEntities1 Context { get; } = new DB.VehicleRentEntities1();
    }
}
