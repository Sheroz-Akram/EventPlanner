using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Domain.Common
{
    public interface IHasModificationTime
    {
        DateTime LastModifiedDate { get; set; }
    }
}
