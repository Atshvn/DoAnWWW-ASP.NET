﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDoAn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class TaiKhoan
    {
        [Required]
        public string ID { get; set; }

        [Required]
        public string passWord { get; set; }
        [DisplayName("Tài Khoản Dùng Cho")]
        public string loaiTaiKhoan { get; set; }
    
        public virtual GiangVien GiangVien { get; set; }
        public virtual QuanTri QuanTri { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
    public enum loaiTaiKhoan
    {
        GiangVien, QuanTri, SinhVien
    }
}
