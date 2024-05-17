using Ilmume.Primary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilmume.CoreAPI.SDK.API
{
    public interface IVenueAPI
    {
        Venue GetVenueByID(Guid id);
    }
}
