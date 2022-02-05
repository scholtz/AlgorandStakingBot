using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorandStakingBot.Model
{
    public class AlgodConfiguration
    {
        /// <summary>
        /// Hostname of AlgoD
        /// 
        /// for example:
        /// http://localhost:4001
        /// https://node.algoexplorerapi.io
        /// https://node.testnet.algoexplorerapi.io
        /// </summary>
        public string Host { get; set; } = "https://node.testnet.algoexplorerapi.io";
        /// <summary>
        /// Auth header
        /// X-API-Key for purestake
        /// X-Algo-API-Token for sandbox, and algoexplorer
        /// </summary>
        public string Header { get; set; } = "X-Algo-API-Token";
        /// <summary>
        /// Auth token
        /// </summary>
        public string Token { get; set; } = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

    }
}
