
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant2Action
    {
        /// <summary>
        /// 
        /// </summary>
        Unblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant2Action value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant2Action.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "unblocked" => GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant2Action.Unblocked,
                _ => null,
            };
        }
    }
}