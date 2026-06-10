using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_MVC_GREENBEAN.Models;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Repositories
{
    public interface IRepositoriLookup
    {
        List<Lookup> AmbilBeanTypes();

        List<Lookup> AmbilProcessMethods();

        List<Lookup> AmbilGrades();
    }
}