using CodeStack.SwEx.Common.Icons;
using CodeStack.SwEx.PMPage.Controls;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Xarial.VPages.Framework.Attributes;
using Xarial.VPages.Framework.Base;

namespace CodeStack.SwEx.PMPage.Constructors
{
    [DefaultType(typeof(UIElement))]
    internal class PropertyManagerPageWindowFromHandleConstructor<THandler> : PropertyManagerPageControlConstructor<THandler, PropertyManagerPageWindowFromHandleEx, IPropertyManagerPageWindowFromHandle>
        where THandler : PropertyManagerPageHandlerEx, new()
    {
        public PropertyManagerPageWindowFromHandleConstructor(ISldWorks app, IconsConverter iconsConv) : base(app, swPropertyManagerPageControlType_e.swControlType_WindowFromHandle, iconsConv)
        {

        }

        protected override PropertyManagerPageWindowFromHandleEx CreateControl(IPropertyManagerPageWindowFromHandle swCtrl, IAttributeSet atts, THandler handler, short height)
        {
            if (height == -1)
            {
                height = 100;
            }
            swCtrl.Height = height;


            return new PropertyManagerPageWindowFromHandleEx(swCtrl,atts.Id, atts.Tag, handler);
        }
    }
}
