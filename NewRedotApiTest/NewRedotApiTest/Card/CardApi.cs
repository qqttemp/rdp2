using NewRedotApiTest.Card.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NewRedotApiTest
{
    public class CardApi
    {
        public string CardAPIBaseUrl = "https://card.api.reddotpay.sg/v1";

        public CardTokens ListAllTokens(string repoId,string bin = null)
        {
            throw new NotImplementedException();
        }
    }
}
