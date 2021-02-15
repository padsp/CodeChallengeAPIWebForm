using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace CodeChallengeAPIWebForm
{
    public class AccountProcessor
    {
        public async Task<List<Account>> LoadAccounts()
        {
            string BaseUrl = "https://frontiercodingtests.azurewebsites.net/api/accounts/getall";

            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(BaseUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<Account> accountList = new List<Account>();
                    accountList = await response.Content.ReadAsAsync<List<Account>>();
                    return accountList;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}