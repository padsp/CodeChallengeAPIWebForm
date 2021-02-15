using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeChallengeAPIWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            CodeChallengeAPIWebForm.APIHelper.InitializeClient();
            AccountProcessor accountProcessor = new AccountProcessor();
            List<Account> accountList = new List<Account>(); ;
            accountList = await accountProcessor.LoadAccounts();
            
            foreach (Account item in accountList.OrderBy(row => row.PaymentDueDate != null).ThenBy(row => row.PaymentDueDate))
            {
                if (item.AccountStatusId == AccountStatuses.Active)
                {
                    this.active_account.InnerHtml += "<ul class='account-data-list'>";
                    this.active_account.InnerHtml += "<li><label>Name: </label>" + item.LastName + ", " + item.FirstName + "</li>";
                    this.active_account.InnerHtml += "<li><label>Email: </label>" + item.Email + "</li>";
                    this.active_account.InnerHtml += "<li><label>Phone Number: </label>" + string.Format("{0:(###) ###-####}", Convert.ToInt64(item.PhoneNumber)) + "</li>";
                    this.active_account.InnerHtml += "<li><label>Amount Due: </label>" + item.AmountDue.ToString("c") + "</li>";
                    this.active_account.InnerHtml += "<li><label>Due Date: </label>" + string.Format("{0: MM/dd/yyyy}", item.PaymentDueDate) + "</li>";
                    this.active_account.InnerHtml += "</ul>";
                }
                else if (item.AccountStatusId == AccountStatuses.Inactive)
                {
                    this.inactive_account.InnerHtml += "<ul class='account-data-list'>";
                    this.inactive_account.InnerHtml += "<li><label>Name: </label>" + item.LastName + ", " + item.FirstName + "</li>";
                    this.inactive_account.InnerHtml += "<li><label>Email: </label>" + item.Email + "</li>";
                    this.inactive_account.InnerHtml += "<li><label>Phone Number: </label>" + String.Format("{0:(###) ###-####}", Convert.ToInt64(item.PhoneNumber)) + " </li>";
                    this.inactive_account.InnerHtml += "<li><label>Amount Due: </label>" + item.AmountDue.ToString("c") + "</li>";
                    if (item.PaymentDueDate != null || item.PaymentDueDate > DateTime.MinValue)
                    {
                        this.inactive_account.InnerHtml += "<li><label>Due Date: </label>" + string.Format("{0: MM/dd/yyyy}", item.PaymentDueDate) + "</li>";
                    }
                    this.inactive_account.InnerHtml += "</ul>";
                }
                else //overdue
                {
                    this.overdue_account.InnerHtml += "<ul class='account-data-list'>";
                    this.overdue_account.InnerHtml += "<li><label>Name: </label>" + item.LastName + ", " + item.FirstName + "</li>";
                    this.overdue_account.InnerHtml += "<li><label>Email: </label>" + item.Email + "</li>";
                    this.overdue_account.InnerHtml += "<li><label>Phone Number: </label>" + String.Format("{0:(###) ###-####}", Convert.ToInt64(item.PhoneNumber)) + "</li>";
                    this.overdue_account.InnerHtml += "<li><label>Amount Due: </label>" + item.AmountDue.ToString("c") + "</li>";
                    this.overdue_account.InnerHtml += "<li><label>Due Date: </label>" + string.Format("{0: MM/dd/yyyy}", item.PaymentDueDate) + "</li>";
                    this.overdue_account.InnerHtml += "</ul>";
                }
            }
            //close objects
            accountList = null;
        }
    }
}