﻿//**********************
//SwEx.Pmp
//Copyright(C) 2018 www.codestack.net
//License: https://github.com/codestack-net-dev/vpages-sw/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/pmp/
//**********************

using CodeStack.SwEx.Pmp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.Constructors;
using Xarial.VPages.Framework.Base;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using CodeStack.SwEx.Pmp.Attributes;

namespace CodeStack.SwEx.Pmp.Constructors
{
    internal class PropertyManagerPageConstructor<THandler> : PageConstructor<PropertyManagerPagePageEx<THandler>>
        where THandler : PropertyManagerPageHandlerEx, new()
    {
        private ISldWorks m_App;

        internal PropertyManagerPageConstructor(ISldWorks app)
        {
            m_App = app;
        }

        protected override PropertyManagerPagePageEx<THandler> Create(IAttributeSet atts)
        {
            var handler = new THandler();
            handler.Init(m_App);
            int err = -1;

            swPropertyManagerPageOptions_e opts;

            if (atts.Has<PropertyManagerPageOptionsAttribute>())
            {
                opts = atts.Get<PropertyManagerPageOptionsAttribute>().Options;
            }
            else
            {
                opts = swPropertyManagerPageOptions_e.swPropertyManagerOptions_OkayButton;
            }

            var helpLink = "";
            var whatsNewLink = "";

            if (atts.Has<PropertyManagerPageHelpAttribute>())
            {
                var helpAtt = atts.Get<PropertyManagerPageHelpAttribute>();

                if (!string.IsNullOrEmpty(helpAtt.WhatsNewLink))
                {
                    if (!opts.HasFlag(swPropertyManagerPageOptions_e.swPropertyManagerOptions_WhatsNew))
                    {
                        opts |= swPropertyManagerPageOptions_e.swPropertyManagerOptions_WhatsNew;
                    }
                }

                helpLink = helpAtt.HelpLink;
                whatsNewLink = helpAtt.WhatsNewLink;
            }

            var page = m_App.CreatePropertyManagerPage(atts.Name,
                (int)opts,
                handler, ref err) as IPropertyManagerPage2;

            return new PropertyManagerPagePageEx<THandler>(page, handler, m_App, helpLink, whatsNewLink);
        }
    }
}
