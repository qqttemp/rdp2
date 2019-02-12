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
            string url = $"{CardAPIBaseUrl}/repo/{repoId}/token";
            NetworkClient networkClient = new NetworkClient(url);
            string resultJson =  networkClient.HttpGet();
            return JsonConvert.DeserializeObject<CardTokens>(resultJson);
        }

        public NewCardToken CreateTokenizedCard(string repoid, NewCard newCard)
        {
            string url = $"{CardAPIBaseUrl}/repo/{repoid}/token";
            NetworkClient networkClient = new NetworkClient(url);
            networkClient.PostData = JsonConvert.SerializeObject(newCard);
            string resultJson = networkClient.HttpPost();
            return JsonConvert.DeserializeObject<NewCardToken>(resultJson);
        }

        public CardInfo RetrieveToken(string repoId, string tokenId)
        {
            string url = $"{CardAPIBaseUrl}/repo/{repoId}/token/{tokenId}";
            NetworkClient networkClient = new NetworkClient(url);
            string resultJson = networkClient.HttpGet();
            return JsonConvert.DeserializeObject<CardInfo>(resultJson);
        }

        public object DeleteToken(string repoId, string tokenId)
        {
            string url = $"{CardAPIBaseUrl}/repo/{repoId}/token/{tokenId}";
            NetworkClient networkClient = new NetworkClient(url);
            string resultJson = networkClient.HttpDelete();
            return JsonConvert.SerializeObject(resultJson);
        }

        public CardInfo RetrieveUnmaskedToken(string repoId, string tokenId)
        {
            string url = $"{CardAPIBaseUrl}/repo/{repoId}/token/{tokenId}/unmasked";
            NetworkClient networkClient = new NetworkClient(url);
            string resultJson = networkClient.HttpGet();
            return JsonConvert.DeserializeObject<CardInfo>(resultJson);
        }

        public NewCardToken RenewToken(string repoId, string tokenId, RenewCard renewCard)
        {
            string url = $"{CardAPIBaseUrl}/repo/{repoId}/token/{tokenId}/renew";
            NetworkClient networkClient = new NetworkClient(url);
            networkClient.PostData = JsonConvert.SerializeObject(renewCard);
            string resultJson = networkClient.HttpPost();
            return JsonConvert.DeserializeObject<NewCardToken>(resultJson);
        }

        public NewRepo CreateRepository(NewRepo newRepo)
        {
            string url = $"{CardAPIBaseUrl}/repo";
            NetworkClient networkClient = new NetworkClient(url);
            networkClient.PostData = JsonConvert.SerializeObject(newRepo);
            string resultJson = networkClient.HttpPost();
            return JsonConvert.DeserializeObject<NewRepo>(resultJson);
        }
    }
}
