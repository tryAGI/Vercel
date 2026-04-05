
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant1Action
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant1Action value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant1Action.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant1Action? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant1Action.Blocked,
                _ => null,
            };
        }
    }
}