﻿//**********************
//SwEx.Pmp
//Copyright(C) 2018 www.codestack.net
//License: https://github.com/codestack-net-dev/vpages-sw/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/pmp/
//**********************

using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.Base;

namespace CodeStack.SwEx.PMPage.Attributes
{
    /// <summary>
    /// Additional options for selection box control
    /// </summary>
    public class SelectionBoxOptionsAttribute : Attribute, IAttribute
    {
        /// <summary>
        /// Selection box style as defined in <see href="http://help.solidworks.com/2016/english/api/swconst/solidworks.interop.swconst~solidworks.interop.swconst.swpropmgrpageselectionboxstyle_e.html">swPropMgrPageSelectionBoxStyle_e Enumeration</see>
        /// </summary>
        public swPropMgrPageSelectionBoxStyle_e Style { get; private set; }

        /// <summary>
        /// Color of the selections in this selection box
        /// </summary>
        public KnownColor SelectionColor { get; private set; }

        public SelectionBoxOptionsAttribute(
            swPropMgrPageSelectionBoxStyle_e style = 0,
            KnownColor selColor = 0)
        {
            Style = style;
            SelectionColor = selColor;
        }
    }
}