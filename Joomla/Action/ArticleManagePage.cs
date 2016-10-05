using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joomla.Common;
using NUnit.Framework;

namespace Joomla.Action
{
    public class ArticleManagePage:BaseAction
    {
        public void VerifySuccessfullyMessage(string message)
        {
            Assert.AreEqual(getControlText("lblMessage"),message);
        }
    }
}
