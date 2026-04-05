
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant2Action
    {
        /// <summary>
        /// 
        /// </summary>
        Unblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant2Action value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant2Action.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "unblocked" => GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant2Action.Unblocked,
                _ => null,
            };
        }
    }
}