﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses.Accounts
{
    /// <summary>
    /// Response to GetAccount request (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountId)
    /// </summary>
    public class GetAccountResponse : EtherchainApiResponse<List<GetAccountResponseData>>
    {
    }

    public class GetAccountResponseData
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("balance")]
        public decimal Balance { get; set; }
        [JsonProperty("nonce")]
        public string Nonce { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("storage")]
        public string Storage { get; set; }
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }
    }
}
