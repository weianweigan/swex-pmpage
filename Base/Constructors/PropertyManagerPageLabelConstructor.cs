using CodeStack.SwEx.Common.Icons;
using CodeStack.SwEx.PMPage.Attributes;
using CodeStack.SwEx.PMPage.Controls;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.Base;

namespace CodeStack.SwEx.PMPage.Constructors
{
    internal class PropertyManagerPageLabelConstructor<THandler> : PropertyManagerPageControlConstructor<THandler, PropertyManagerPageLabelEx, IPropertyManagerPageLabel>
        where THandler : PropertyManagerPageHandlerEx, new()
    {
        public PropertyManagerPageLabelConstructor(ISldWorks app, IconsConverter iconsConv) : base(app, swPropertyManagerPageControlType_e.swControlType_Label, iconsConv)
        {
        }

        protected override PropertyManagerPageLabelEx CreateControl(IPropertyManagerPageLabel swCtrl, IAttributeSet atts, THandler handler, short height)
        {
            if (height != -1)
            {
                swCtrl.Height = height;
            }

            if (atts.Has<LabelOptionsAttribute>())
            {
                var style = atts.Get<ComboBoxOptionsAttribute>();
                if (style.Style != 0)
                {
                    swCtrl.Style = (int)style.Style;
                }
            }

            return new PropertyManagerPageLabelEx(swCtrl, atts.Id, atts.Tag,   handler);
        }
    }
}
