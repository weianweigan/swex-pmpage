using CodeStack.SwEx.Common.Base;
using CodeStack.SwEx.PMPage.Base;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.PageElements;

namespace CodeStack.SwEx.PMPage.Controls
{
    internal class PropertyManagerPageLabelEx : PropertyManagerPageControlEx<string, IPropertyManagerPageLabel>
    {
        protected override event ControlValueChangedDelegate<string> ValueChanged;

        private string text;

        public PropertyManagerPageLabelEx(IPropertyManagerPageLabel ctrl, int id, object tag, PropertyManagerPageHandlerEx handler) : base(ctrl, id, tag, handler)
        {
            ValueChanged?.Invoke(this, text);
        }

        protected override string GetSpecificValue()
        {
            return text;
        }

        protected override void SetSpecificValue(string value)
        {
            text = value;
            if (text != null)
            {
                SwSpecificControl.Caption = text;
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            text = null;
        }
    }
}
