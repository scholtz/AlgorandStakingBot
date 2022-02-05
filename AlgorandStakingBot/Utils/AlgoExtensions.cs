using AlgorandStakingBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorandStakingBot.Utils
{
    internal class AlgoExtensions
    {

        /// <summary>
        /// encode and submit signed transactions using algod v2 api
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="signedTx"></param>
        /// <returns></returns>
        public static async Task<Algorand.V2.Algod.Model.PostTransactionsResponse> SubmitTransactions(Algorand.V2.Algod.DefaultApi instance, IEnumerable<Algorand.SignedTransaction> signedTxs) //throws Exception
        {
            List<byte> byteList = new List<byte>();
            foreach (var signedTx in signedTxs)
            {
                byteList.AddRange(Algorand.Encoder.EncodeToMsgPack(signedTx));
            }
            using (MemoryStream ms = new MemoryStream(byteList.ToArray()))
            {
                return await instance.TransactionsAsync(ms);
            }
        }
        public static Algorand.V2.Algod.DefaultApi GetAlgod(AlgodConfiguration config)
        {
            var algodHttpClient = Algorand.V2.HttpClientConfigurator.ConfigureHttpClient(config.Host, config.Token, config.Header);

            var api = new Algorand.V2.Algod.DefaultApi(algodHttpClient)
            {
                BaseUrl = config.Host,
            };
            return api;
        }
        public static Algorand.V2.Indexer.SearchApi GetSearchApi(IndexerConfiguration config)
        {
            var algodHttpClient = Algorand.V2.HttpClientConfigurator.ConfigureHttpClient(config.Host, config.Token, config.Header);

            var api = new Algorand.V2.Indexer.SearchApi(algodHttpClient)
            {
                BaseUrl = config.Host,
            };
            return api;
        }
        public static Algorand.V2.Indexer.LookupApi GetLookupApi(IndexerConfiguration config)
        {
            var algodHttpClient = Algorand.V2.HttpClientConfigurator.ConfigureHttpClient(config.Host, config.Token, config.Header);

            var api = new Algorand.V2.Indexer.LookupApi(algodHttpClient)
            {
                BaseUrl = config.Host,
            };
            return api;
        }
    }
}
