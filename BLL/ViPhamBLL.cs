using DAL;
using GUI_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ViPhamBLL
    {
        private ViPhamDAL viPhamDAL = new ViPhamDAL();
       
        public string GenMaVP()
        {
            return viPhamDAL.GenMaVP();
        }
        public List<ViPhamDTO> GetAllViPham()
        {
            return viPhamDAL.GetAllViPham();
        }

        public bool InsertViPham(ViPhamDTO viPham)
        {
            return viPhamDAL.InsertViPham(viPham);
        }
        public bool DeleteViPham(string maViPham)
        {
            return viPhamDAL.DeleteViPham(maViPham);
        }
        public bool UpdateViPham(ViPhamDTO viPham)
        {
            return viPhamDAL.UpdateViPham(viPham);
        }
        public List<ViPhamDTO> SearchViPham(string searchTerm)
        {
            return viPhamDAL.SearchViPham(searchTerm);
        }
        public ViPhamDTO GetViPhamByMa(string maViPham)
        {
            return viPhamDAL.GetViPhamByMa(maViPham);
        }

    }
}
