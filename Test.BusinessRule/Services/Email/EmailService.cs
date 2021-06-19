using System;
using System.Collections.Generic;
using System.Text;

namespace Test.BusinessRule.Services.Email
{
    public interface IEmailService
    {
        void Notify();
    }

    public class EmailService : IEmailService
    {
        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
