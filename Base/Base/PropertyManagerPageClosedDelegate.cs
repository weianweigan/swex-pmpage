﻿//**********************
//SwEx.PMPage - data driven framework for SOLIDWORKS Property Manager Pages
//Copyright(C) 2019 www.codestack.net
//License: https://github.com/codestackdev/swex-pmpage/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/pmp/
//**********************

using SolidWorks.Interop.swconst;

namespace CodeStack.SwEx.PMPage.Base
{
    /// <summary>
    /// Delegate for handling the parameters of property manager page closed event
    /// </summary>
    /// <param name="reason">Reason of closing as defined in <see href="http://help.solidworks.com/2016/english/api/swconst/solidworks.interop.swconst~solidworks.interop.swconst.swpropertymanagerpageclosereasons_e.html">swPropertyManagerPageCloseReasons_e Enumeration</see></param>
    public delegate void PropertyManagerPageClosedDelegate(swPropertyManagerPageCloseReasons_e reason);
}
