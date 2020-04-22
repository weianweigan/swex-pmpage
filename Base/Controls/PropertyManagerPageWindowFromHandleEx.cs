using CodeStack.SwEx.PMPage.Base;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms.Integration;
using Xarial.VPages.Framework.PageElements;

namespace CodeStack.SwEx.PMPage.Controls
{
    internal class PropertyManagerPageWindowFromHandleEx : PropertyManagerPageControlEx<UIElement, IPropertyManagerPageWindowFromHandle>, IPropertyManagerWinFromHandlerEx
    {
        protected override event ControlValueChangedDelegate<UIElement> ValueChanged;

        private ElementHost host;
        private UIElement ui;

        public PropertyManagerPageWindowFromHandleEx(IPropertyManagerPageWindowFromHandle ctrl, int id, object tag, PropertyManagerPageHandlerEx handler) : base(ctrl, id, tag, handler)
        {
            m_Handler.WindowFromHandleControlCreated += M_Handler_WindowFromHandleControlCreated;
        }

        private void M_Handler_WindowFromHandleControlCreated(int Id, bool Status)
        {
            ValueChanged?.Invoke(this, ui);
        }

        protected override UIElement GetSpecificValue()
        {
            return ui;
            //SwSpecificControl.
            //throw new NotImplementedException();
        }

        protected override void SetSpecificValue(UIElement value)
        {
            ui = value;
            SetHandle();
        }

        private void SetHandle()
        {

            if (ui != null)
            {
                if (host == null)
                {
                    host = new ElementHost() { Child = ui };
                }
                SwSpecificControl.SetWindowHandlex64(host.Handle.ToInt64());
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            m_Handler.WindowFromHandleControlCreated -= M_Handler_WindowFromHandleControlCreated;
            host = null;
            ui = null;
        }

        public void ReSetHandle()
        {
            SetHandle();
        }
    }
}
