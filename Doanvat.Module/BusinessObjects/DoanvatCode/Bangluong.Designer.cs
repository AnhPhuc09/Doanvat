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

    [DefaultProperty("Nhanvien_ID")]
    public partial class Bangluong : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Nhanvien fNhanvien_ID;
        [Association(@"BangluongReferencesNhanvien")]
        public Nhanvien Nhanvien_ID
        {
            get { return fNhanvien_ID; }
            set { SetPropertyValue<Nhanvien>(nameof(Nhanvien_ID), ref fNhanvien_ID, value); }
        }
        DateTime fThang;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask","dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat","{0:dd/MM/yyyy HH:mm}")
]
        public DateTime Thang
        {
            get { return fThang; }
            set { SetPropertyValue<DateTime>(nameof(Thang), ref fThang, value); }
        }
        decimal fMucluongtheogio;
        public decimal Mucluongtheogio
        {
            get { return fMucluongtheogio; }
            set { SetPropertyValue<decimal>(nameof(Mucluongtheogio), ref fMucluongtheogio, value); }
        }
        decimal fThuong;
        public decimal Thuong
        {
            get { return fThuong; }
            set { SetPropertyValue<decimal>(nameof(Thuong), ref fThuong, value); }
        }
        decimal fSogio;
        public decimal Sogio
        {
            get { return fSogio; }
            set { SetPropertyValue<decimal>(nameof(Sogio), ref fSogio, value); }
        }
        decimal fPhucap;
        public decimal Phucap
        {
            get { return fPhucap; }
            set { SetPropertyValue<decimal>(nameof(Phucap), ref fPhucap, value); }
        }
        [PersistentAlias("[Mucluongtheogio] * [Sogio] + [Phucap] + [Thuong]")]
        public string Tongluong
        {
            get { return (string)(EvaluateAlias(nameof(Tongluong))); }
        }
    }

}
