using System.Collections.Generic;
using System.Text;
using AssistPurchase.Models;
using MailKit.Security;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;


namespace AssistPurchase.Repository
{
    public class CustomerAlertRepository: ICustomerAlertRepository
    {
        private readonly List<CustomerModel> _customerList;

        public CustomerAlertRepository()
        {
            

            _customerList = new List<CustomerModel>()
            { 
                new CustomerModel()
                {
                    CustomerId="A1",
                    CustomerName="Akash",
                    CustomerEmailId="akashspiman@gmail.com",
                    CustomerPhoneNumber="1234765"
                }
            };
        }
        public void AddCustomer(CustomerModel customer)
        {
            _customerList.Add(customer);
        }

        public CustomerModel FindCustomer(string customerId)
        {
            foreach (var customer in _customerList)
            {
                if (customerId == customer.CustomerId)
                    return customer;
            }

            return null;
        }

        public void SendEmail(CustomerModel customer)
        {
            var messageBody = new StringBuilder();
            messageBody.Append("Hello,\n");
            messageBody.Append("The following customer has booked the product.\n");
            messageBody.Append("Please see the details and attend the same.\n");
            messageBody.Append("Customer Name: " + customer.CustomerName + "\n");
            messageBody.Append("Customer Phone Number: " + customer.CustomerPhoneNumber + "\n");
            messageBody.Append("Customer Email Id: " + customer.CustomerEmailId + "\n");
            messageBody.Append("Customer Product Name: " + customer.ProductName);

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("s21b12.testmail@gmail.com"));
            email.To.Add(MailboxAddress.Parse("akashspiman@gmail.com"));
            email.Subject = "Customer Booking Received";
            email.Body = new TextPart(TextFormat.Plain) { Text = messageBody.ToString() };

            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("s21b12.testmail", "assistpurchase");
            smtp.Send(email);
            smtp.Disconnect(true);

        }

    }
}
