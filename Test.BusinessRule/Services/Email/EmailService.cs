using System;
using System.Collections.Generic;
using System.Text;

namespace Test.BusinessRule.Services.Email
{
    public interface IEmailService
    {
        bool Notify();
    }

    public class EmailService : IEmailService
    {
        public bool Notify()
        {
            return true;
            //throw new NotImplementedException();
        }
    }
}
