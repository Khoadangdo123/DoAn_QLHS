﻿using System;

namespace GUI_CSharp.DTO
{
    public class NamHocDTO
    {
        // Fields
        public string maNamHoc;   // Corresponds to MaNamHoc VARCHAR(6)
        public string tenNamHoc;  // Corresponds to TenNamHoc NVARCHAR(30)

        // Getters and Setters
        public string MaNamHoc
        {
            get { return maNamHoc; }
            set { maNamHoc = value; }
        }

        public string TenNamHoc
        {
            get { return tenNamHoc; }
            set { tenNamHoc = value; }
        }

        // Constructor
        public NamHocDTO() { }

        public NamHocDTO(string maNamHoc, string tenNamHoc)
        {
            this.maNamHoc = maNamHoc;
            this.tenNamHoc = tenNamHoc;
        }
    }
}
