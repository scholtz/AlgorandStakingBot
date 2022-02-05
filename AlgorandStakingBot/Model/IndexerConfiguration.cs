using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorandStakingBot.Model
{
    public class IndexerConfiguration
    {
        /// <summary>
        /// Hostname of indexer
        /// 
        /// for example:
        /// http://localhost:8980
        /// https://algoindexer.algoexplorerapi.io
        /// https://algoindexer.testnet.algoexplorerapi.io
        /// </summary>
        public string Host { get; set; } = "https://algoindexer.testnet.algoexplorerapi.io";
        /// <summary>
        /// Auth header
        /// X-API-Key for purestake
        /// X-Indexer-API-Token for sandbox, and algoexplorer
        /// </summary>
        public string Header { get; set; } = "X-Indexer-API-Token";
        /// <summary>
        /// Auth token
        /// </summary>
        public string Token { get; set; } = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        /// <summary>
        /// Delay between indexer requests
        /// </summary>
        public int DelayMs { get; set; } = 1000;
    }
}
