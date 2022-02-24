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
        public Run(string id)
        {
            SetVariables();
            try
            {
                Testcase tc = new Testcase(id);
                TCResult r = tc.Execute();
                TestContext.AddTestAttachment(r.report);
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

        }
    }
}
