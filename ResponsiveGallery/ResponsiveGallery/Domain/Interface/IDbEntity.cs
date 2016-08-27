using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveGallery.Domain.Interface
{
    public interface IDbEntity
    {
        int Id { get; set; }
        bool Active { get; set; }
    }
}
