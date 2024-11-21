using System;
using System.Collections.Generic;
using DAL;
using GUI_CSharp.DTO;

namespace BLL
{
    public class PhanCongBLL
    {
        private PhanCongDAL phanCongDAL;

        public PhanCongBLL()
        {
            phanCongDAL = new PhanCongDAL();
        }

        public List<PhanCongDTO> GetAllPhanCong()
        {
            return phanCongDAL.GetAllPhanCong();
        }

        public PhanCongDTO GetPhanCongBySTT(int stt)
        {
            return phanCongDAL.GetPhanCongBySTT(stt);
        }

        public bool InsertPhanCong(PhanCongDTO pc)
        {
            if (pc == null)
            {
                throw new ArgumentNullException(nameof(pc), "PhanCongDTO cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(pc.MaGiaoVien))
            {
                throw new ArgumentException("MaGiaoVien cannot be null or empty.", nameof(pc.MaGiaoVien));
            }

            if (string.IsNullOrWhiteSpace(pc.MaLop))
            {
                throw new ArgumentException("MaLop cannot be null or empty.", nameof(pc.MaLop));
            }

            if (string.IsNullOrWhiteSpace(pc.MaMonHoc))
            {
                throw new ArgumentException("MaMonHoc cannot be null or empty.", nameof(pc.MaMonHoc));
            }

            if (string.IsNullOrWhiteSpace(pc.MaNamHoc))
            {
                throw new ArgumentException("MaNamHoc cannot be null or empty.", nameof(pc.MaNamHoc));
            }

            return phanCongDAL.InsertPhanCong(pc);
        }

        public bool UpdatePhanCong(PhanCongDTO pc)
        {
            if (pc == null)
            {
                throw new ArgumentNullException(nameof(pc), "PhanCongDTO cannot be null.");
            }

            if (pc.STT <= 0)
            {
                throw new ArgumentException("STT must be greater than zero.", nameof(pc.STT));
            }

            if (string.IsNullOrWhiteSpace(pc.MaGiaoVien))
            {
                throw new ArgumentException("MaGiaoVien cannot be null or empty.", nameof(pc.MaGiaoVien));
            }

            if (string.IsNullOrWhiteSpace(pc.MaLop))
            {
                throw new ArgumentException("MaLop cannot be null or empty.", nameof(pc.MaLop));
            }

            if (string.IsNullOrWhiteSpace(pc.MaMonHoc))
            {
                throw new ArgumentException("MaMonHoc cannot be null or empty.", nameof(pc.MaMonHoc));
            }

            if (string.IsNullOrWhiteSpace(pc.MaNamHoc))
            {
                throw new ArgumentException("MaNamHoc cannot be null or empty.", nameof(pc.MaNamHoc));
            }

            return phanCongDAL.UpdatePhanCong(pc);
        }

        public bool DeletePhanCong(int stt)
        {
            if (stt <= 0)
            {
                throw new ArgumentException("STT must be greater than zero.", nameof(stt));
            }

            return phanCongDAL.DeletePhanCong(stt);
        }

        public List<KeyValuePair<string, string>> LayDanhSachNamHoc()
        {
            return phanCongDAL.LayDanhSachNamHoc();
        }

        public List<KeyValuePair<string, string>> LayDanhSachLop()
        {
            return phanCongDAL.LayDanhSachLop();
        }

        public int GenSTT()
        {
            return phanCongDAL.GenSTT();
        }

        public List<PhanCongDTO> SearchPhanCong(string searchTerm)
        {
            return phanCongDAL.SearchPhanCong(searchTerm);
        }
    }
}
