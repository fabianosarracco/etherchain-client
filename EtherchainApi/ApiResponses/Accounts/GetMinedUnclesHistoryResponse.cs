﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses.Accounts
{
    /// <summary>
    /// Response to GetMinedUnclesHistory request
    ///  (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountIdMiningunclehistory)
    /// </summary>
    public class GetMinedUnclesHistoryResponse : EtherchainApiResponse<List<GetMinedUnclesHistoryResponseData>>
    {
    }

    public class GetMinedUnclesHistoryResponseData
    {
        [JsonProperty("day")]
        public string Day { get; set; }

        public DateTime DayAsDateTime => DateTime.Parse(Day);

        [JsonProperty("minedUncles")]
        public int MinedUncles { get; set; }
    }
}
