﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Doanvat.Module.Doanvat
{

    [DefaultProperty("Nhacungcap_ID")]
    public partial class Phieunhap : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Nhacungcap fNhacungcap_ID;
        [Association(@"PhieunhapReferencesNhacungcap")]
        public Nhacungcap Nhacungcap_ID
        {
            get { return fNhacungcap_ID; }
            set { SetPropertyValue<Nhacungcap>(nameof(Nhacungcap_ID), ref fNhacungcap_ID, value); }
        }
        Nhanvien fNhanvien_ID;
        [Association(@"PhieunhapReferencesNhanvien")]
        public Nhanvien Nhanvien_ID
        {
            get { return fNhanvien_ID; }
            set { SetPropertyValue<Nhanvien>(nameof(Nhanvien_ID), ref fNhanvien_ID, value); }
        }
        Hanghoa fHanghoa_ID;
        public Hanghoa Hanghoa_ID
        {
            get { return fHanghoa_ID; }
            set { SetPropertyValue<Hanghoa>(nameof(Hanghoa_ID), ref fHanghoa_ID, value); }
        }
        DateTime fNgaynhap;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask","dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat","{0:dd/MM/yyyy HH:mm}")
]
        public DateTime Ngaynhap
        {
            get { return fNgaynhap; }
            set { SetPropertyValue<DateTime>(nameof(Ngaynhap), ref fNgaynhap, value); }
        }
        [Association(@"PN_HHReferencesPhieunhap")]
        public XPCollection<PN_HH> PN_HHs { get { return GetCollection<PN_HH>(nameof(PN_HHs)); } }
    }

}
