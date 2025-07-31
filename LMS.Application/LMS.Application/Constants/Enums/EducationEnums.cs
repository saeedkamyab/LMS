using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Constants.Enums
{
    public enum ClassType
    {
        None = 0,
        PrivateNormal = 1,
        PrivateCompact = 2,
        PublicNormal = 3,
        PublicCompact = 4
    }


    [Flags]
    public enum WeekDays
    {
        None = 0,
        Saturday = 1,
        Sunday = 2,
        Monday = 4,
        Tuesday = 8,
        Wednesday = 16,
        Thursday = 32,
        Friday = 64
    }
}
