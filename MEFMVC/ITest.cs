using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace MEFMVC
{
    public interface ITest
    {
        String GetMessage();
    }

    [Export(typeof(ITest))]
    public class MyTest : ITest
    {
        public MyTest()
        {
            creationDate = DateTime.Now;
        }

        public string GetMessage()
        {
            return String.Format("MyTest created at {0}", creationDate.ToString("hh:mm:ss"));
        }

        private DateTime creationDate;
    }

}


