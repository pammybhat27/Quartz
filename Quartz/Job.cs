using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz
{
    public class TestJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            // Send Email Or Tweeting
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + "test");
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }

        }


    }
}
