using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Data;
using Models;
using System.Net;
using System.Net.Mail;


namespace Logic
{
    public class UserCollectionlogic : UserLogic
    {
        public User user;

        private UserCollectionRepository userCollectionRepository = new UserCollectionRepository(new UserCollectionContext());

        public UserCollectionlogic(User user)
        {
            this.user = user;
        }
        public UserCollectionlogic()
        {
            
        }

        public void SignUp(User user) => userCollectionRepository.SingUp(user);

        public void sendwelcommail(string email,string name)
        {
           // try
          //  {
                string subject = "Welcome to YouStore!";
            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.Append("Dear " + name + ",<br/><br/>");
            sbEmailBody.Append("We are glad that you have joined YouStore.");
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("Team YouStore");
            
            string message = sbEmailBody.ToString();
              var senderEmail = new MailAddress("Aquatest.2803@gmail.com", "");
                var receiverEmail = new MailAddress(email, "Email");
                var password = "Aqua-AQUA-9999";
                var sub = subject;
                var body = message;
                var smtp = new SmtpClient
                {
                    //smtp.gmail.com
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                using (var mess = new MailMessage(senderEmail, receiverEmail)
                {
                    Subject = subject,
                    Body = body
                })
                {
                mess.IsBodyHtml = true;

                    smtp.Send(mess);
                }
            //}
            //catch { }
        }
    }
}
