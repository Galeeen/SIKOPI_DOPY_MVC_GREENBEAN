using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SIKOPI_DOPY_MVC_GREENBEAN.Models;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Repositories
{
    public interface IRepositoriGreenBean
    {
        DataTable AmbilSemua();

        GreenBean? AmbilById(long id);

        void Tambah(GreenBean greenBean);

        void Ubah(GreenBean greenBean);

        void Hapus(long id);
    }
}