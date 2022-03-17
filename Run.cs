using luatsqa;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Run
    {
        public Run(string id, string testdatafile=null)
        {
            SetVariables();
            try
            {
                Testcase tc = new Testcase(id, testdatafile);
                TCResult r = tc.Execute();
                TestContext.AddTestAttachment(r.report);
                TestContext.AddTestAttachment(r.log);
                if(r.result == 1)
                {
                    Assert.Pass("Test Case PASSED");
                }
                else
                {
                    Assert.Fail("Test Case FAILED");
                }
                System.Diagnostics.Process.Start(@"cmd.exe ", @"/c " + r.report);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetVariables()
        {

            Environment.SetEnvironmentVariable("Ldomain", "https://demo.luatsqa.com/");
            Environment.SetEnvironmentVariable("Lusername", "demo");
            Environment.SetEnvironmentVariable("Lpassword", "demo");
            Environment.SetEnvironmentVariable("Lenv", "1");//1-TEST, 2-INTG, 3-UAT, 4-PROD
            Environment.SetEnvironmentVariable("Lteam", "demo");
            Environment.SetEnvironmentVariable("a1", "foo2");
            Environment.SetEnvironmentVariable("a2", "bar");

        }
    }
}
