﻿using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class TTDOCGIADAO
    {
        private static TTDOCGIADAO instance;

        public static TTDOCGIADAO Instance
        {
            get { if (instance == null) instance = new TTDOCGIADAO(); return instance; }
            set => instance = value;
        }
        private TTDOCGIADAO() { }
        //QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public List<TTDOCGIADTO> GetListDocGiaInfo()
        {
            List<TTDOCGIADTO> listDocGiaInfo = new List<TTDOCGIADTO>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var data = ((from u in db.DOCGIAs
                           join n in db.USERs on u.IDUser equals n.IDUser
                           select new { u.MaDocGia, u.HoTen, u.NgaySinh, u.DiaChi, u.Email, u.NgayLapThe, u.NgayHetHan, u.MaLoaiDocGia, u.IDUser, n.PasswordUser})).ToList();
                foreach (var item in data)
                {
                    TTDOCGIADTO ttdg = new TTDOCGIADTO
                    {
                        MaDocGia = item.MaDocGia,
                        HoTen = item.HoTen,
                        NgaySinh = item.NgaySinh,
                        DiaChi = item.DiaChi,
                        Email = item.Email,
                        NgayLapThe = item.NgayLapThe,
                        NgayHetHan = item.NgayHetHan,
                        MaLoaiDocGia = item.MaLoaiDocGia,
                        IDUser = item.IDUser,
                        PasswordUser = item.PasswordUser
                    };
                    listDocGiaInfo.Add(ttdg);
                }
            }
            return listDocGiaInfo;
        }
    }
}
