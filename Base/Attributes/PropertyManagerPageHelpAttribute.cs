﻿//**********************
//SwEx.Pmp
//Copyright(C) 2018 www.codestack.net
//License: https://github.com/codestack-net-dev/vpages-sw/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/pmp/
//**********************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.Base;

namespace CodeStack.SwEx.Pmp.Attributes
{
    public class PropertyManagerPageHelpAttribute : Attribute, IAttribute
    {
        public string HelpLink { get; private set; }
        public string WhatsNewLink { get; private set; }

        public PropertyManagerPageHelpAttribute(string helpLink, string whatsNewLink = "")
        {
            HelpLink = helpLink;
            WhatsNewLink = whatsNewLink;
        }
    }
}
