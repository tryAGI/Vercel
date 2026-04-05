
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamLimitedLimitedByItem
    {
        /// <summary>
        /// 
        /// </summary>
        Mfa,
        /// <summary>
        /// 
        /// </summary>
        Scope,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamLimitedLimitedByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamLimitedLimitedByItem value)
        {
            return value switch
            {
                TeamLimitedLimitedByItem.Mfa => "mfa",
                TeamLimitedLimitedByItem.Scope => "scope",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamLimitedLimitedByItem? ToEnum(string value)
        {
            return value switch
            {
                "mfa" => TeamLimitedLimitedByItem.Mfa,
                "scope" => TeamLimitedLimitedByItem.Scope,
                _ => null,
            };
        }
    }
}