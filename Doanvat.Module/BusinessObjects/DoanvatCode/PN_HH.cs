﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Doanvat.Module.Doanvat
{

    public partial class PN_HH
    {
        public PN_HH(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
