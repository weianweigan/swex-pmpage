using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.Base;

namespace CodeStack.SwEx.PMPage.Attributes
{
    /// <summary>
    /// Provides additional options for label
    /// </summary>
    public class LabelOptionsAttribute:Attribute,IAttribute
    {
        /// <summary>
        /// Constructor for specifying style of label
        /// </summary>
        /// <param name="style"></param>
        public LabelOptionsAttribute(swPropMgrPageLabelStyle_e style = 0)
        {
            Style = style;
        }

        internal swPropMgrPageLabelStyle_e Style { get; private set; }

    }
}
