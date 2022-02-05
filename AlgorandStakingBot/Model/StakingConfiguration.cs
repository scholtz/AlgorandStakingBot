using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorandStakingBot.Model
{
    public class StakingConfiguration
    {
        /// <summary>
        /// Asset Id
        /// </summary>
        public ulong AssetId { get; set; } = 452399768; // 452399768 = VoteCoin mainnet assetid, 48806985
        /// <summary>
        /// Each account with minimum balance is allowed to stake
        /// 
        /// The balance is in token base units
        /// </summary>
        public ulong MinimumBalanceForStaking { get; set; } = 1000000000; // 1000 * 1000000
        /// <summary>
        /// Maximum effective balance for staking per account
        /// </summary>
        public ulong MaximumBalanceForStaking { get; set; } = 10000000000; // 1000 * 1000000
        /// <summary>
        /// Interest rate expressed in annual rate percentage.
        /// 
        /// 10 means 10%
        /// 1 means 1%
        /// 
        /// if hourly compounding is on, 10% means, that each compounding interval user gets
        /// 1.1^(1/8760)= ( 1,000273769805 - 1 ) *100 = 0,027376% balance
        /// 1.1^(1/8760) ^24 = 0,659120308% per day
        /// 
        /// if daily compounding is on, 10% means, that each compounding interval user gets
        /// 1.1^(1/365)= ( 1,00659120308899 - 1 ) *100 = 0,65912% balance
        /// </summary>
        public decimal InterestRate { get; set; } = 1;
        /// <summary>
        /// Interval in seconds.
        /// 
        /// Whenever is the CurrentRount%Interval == 0, new staking distribution is triggered
        /// </summary>
        public ulong Interval { get; set; } = 86400;
        /// <summary>
        /// List of blacklisted or excluded addresses ..
        /// </summary>
        public HashSet<string> ExcludedAccounts { get; set; } = new HashSet<string>();

        /// <summary>
        /// Address from which is the interest dispenced
        /// </summary>
        public string DispenserMnemonic { get; set; } = "";

    }
}
