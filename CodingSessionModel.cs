using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTracker;

internal class CodingSessionModel
{
    public int Id { get; set; }

    // All DateTime(s) will be converted to string when put into db
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public DateTime Duration { get; set; }
}
