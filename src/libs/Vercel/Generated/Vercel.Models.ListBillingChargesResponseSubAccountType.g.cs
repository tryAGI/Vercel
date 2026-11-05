
#nullable enable

namespace Vercel
{
    /// <summary>
    /// `Team`, or null on Organization (unallocated) rows
    /// </summary>
    public enum ListBillingChargesResponseSubAccountType
    {
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBillingChargesResponseSubAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBillingChargesResponseSubAccountType value)
        {
            return value switch
            {
                ListBillingChargesResponseSubAccountType.Team => "Team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBillingChargesResponseSubAccountType? ToEnum(string value)
        {
            return value switch
            {
                "Team" => ListBillingChargesResponseSubAccountType.Team,
                _ => null,
            };
        }
    }
}