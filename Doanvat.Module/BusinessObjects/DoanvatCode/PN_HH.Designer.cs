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

    [DefaultProperty("Hanghoa_ID")]
    public partial class PN_HH : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Hanghoa fHanghoa_ID;
        [Association(@"PN_HHReferencesHanghoa")]
        public Hanghoa Hanghoa_ID
        {
            get { return fHanghoa_ID; }
            set { SetPropertyValue<Hanghoa>(nameof(Hanghoa_ID), ref fHanghoa_ID, value); }
        }
        Phieunhap fPhieunhap_ID;
        [Association(@"PN_HHReferencesPhieunhap")]
        public Phieunhap Phieunhap_ID
        {
            get { return fPhieunhap_ID; }
            set { SetPropertyValue<Phieunhap>(nameof(Phieunhap_ID), ref fPhieunhap_ID, value); }
        }
        double fSoluongHH;
        public double SoluongHH
        {
            get { return fSoluongHH; }
            set { SetPropertyValue<double>(nameof(SoluongHH), ref fSoluongHH, value); }
        }
        decimal fDongia;
        [DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat","### ### ### ###"),
DevExpress.ExpressApp.Model.ModelDefault("EditMask","### ### ### ###")]
        public decimal Dongia
        {
            get { return fDongia; }
            set { SetPropertyValue<decimal>(nameof(Dongia), ref fDongia, value); }
        }
    }

}
