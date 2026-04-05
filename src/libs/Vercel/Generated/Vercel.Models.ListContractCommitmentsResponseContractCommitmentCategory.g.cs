
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Highest-level classification of the contract commitment. 'Spend' for Pro ($20/month), 'Usage' for Enterprise (MIU allocation).
    /// </summary>
    public enum ListContractCommitmentsResponseContractCommitmentCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Spend,
        /// <summary>
        /// 
        /// </summary>
        Usage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListContractCommitmentsResponseContractCommitmentCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListContractCommitmentsResponseContractCommitmentCategory value)
        {
            return value switch
            {
                ListContractCommitmentsResponseContractCommitmentCategory.Spend => "Spend",
                ListContractCommitmentsResponseContractCommitmentCategory.Usage => "Usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListContractCommitmentsResponseContractCommitmentCategory? ToEnum(string value)
        {
            return value switch
            {
                "Spend" => ListContractCommitmentsResponseContractCommitmentCategory.Spend,
                "Usage" => ListContractCommitmentsResponseContractCommitmentCategory.Usage,
                _ => null,
            };
        }
    }
}