using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using SIKOPI_DOPY_MVC_GREENBEAN.Models;
using SIKOPI_DOPY_MVC_GREENBEAN.Repositories;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Controllers
{
    public class BahanBakuController
    {
        private readonly IRepositoriGreenBean _repositoriGreenBean;

        public BahanBakuController()
        {
            _repositoriGreenBean = new RepositoriGreenBean();
        }

        public DataTable AmbilSemuaGreenBean()
        {
            return _repositoriGreenBean.AmbilSemua();
        }

        public GreenBean? AmbilGreenBeanById(long id)
        {
            if (id <= 0)
                throw new Exception("ID green bean tidak valid.");

            return _repositoriGreenBean.AmbilById(id);
        }

        public void TambahGreenBean(GreenBean greenBean)
        {
            ValidasiGreenBean(greenBean);
            _repositoriGreenBean.Tambah(greenBean);
        }

        public void UbahGreenBean(GreenBean greenBean)
        {
            if (greenBean.Id <= 0)
                throw new Exception("ID green bean tidak valid.");

            ValidasiGreenBean(greenBean);
            _repositoriGreenBean.Ubah(greenBean);
        }

        public void HapusGreenBean(long id)
        {
            if (id <= 0)
                throw new Exception("ID green bean tidak valid.");

            _repositoriGreenBean.Hapus(id);
        }

        private void ValidasiGreenBean(GreenBean greenBean)
        {
            if (string.IsNullOrWhiteSpace(greenBean.Name))
                throw new Exception("Nama green bean wajib diisi.");

            if (greenBean.BeanTypeId <= 0)
                throw new Exception("Jenis green bean wajib dipilih.");

            if (!greenBean.ProcessMethodId.HasValue || greenBean.ProcessMethodId.Value <= 0)
                throw new Exception("Metode proses wajib dipilih.");

            if (!greenBean.GradeId.HasValue || greenBean.GradeId.Value <= 0)
                throw new Exception("Grade wajib dipilih.");

            if (greenBean.StockKg < 0)
                throw new Exception("Stok tidak boleh kurang dari 0.");

            if (greenBean.PricePerKg < 0)
                throw new Exception("Harga tidak boleh kurang dari 0.");
        }
    }
}