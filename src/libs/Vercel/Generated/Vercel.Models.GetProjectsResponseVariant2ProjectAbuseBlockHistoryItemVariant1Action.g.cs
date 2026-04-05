
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant1Action
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant1Action value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant1Action.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant1Action? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant1Action.Blocked,
                _ => null,
            };
        }
    }
}