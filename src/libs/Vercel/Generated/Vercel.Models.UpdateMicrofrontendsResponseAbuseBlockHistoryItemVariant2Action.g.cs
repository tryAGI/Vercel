
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant2Action
    {
        /// <summary>
        /// 
        /// </summary>
        Unblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant2Action value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant2Action.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "unblocked" => UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant2Action.Unblocked,
                _ => null,
            };
        }
    }
}