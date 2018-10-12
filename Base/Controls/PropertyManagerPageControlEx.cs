﻿//**********************
//SwEx.Pmp
//Copyright(C) 2018 www.codestack.net
//License: https://github.com/codestack-net-dev/vpages-sw/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/pmp/
//**********************

using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.Base;
using Xarial.VPages.Framework.PageElements;

namespace CodeStack.SwEx.PMPage.Controls
{
    public interface IPropertyManagerPageControlEx : IControl
    {
        IPropertyManagerPageControl SwControl { get; }
    }

    public abstract class PropertyManagerPageControlEx<TVal> : Control<TVal>, IPropertyManagerPageControlEx
    {
        protected PropertyManagerPageHandlerEx m_Handler;
        
        protected PropertyManagerPageControlEx(int id, object tag, PropertyManagerPageHandlerEx handler) 
            : base(id, tag)
        {
            m_Handler = handler;
        }

        public IPropertyManagerPageControl SwControl => throw new NotImplementedException();
    }
}
