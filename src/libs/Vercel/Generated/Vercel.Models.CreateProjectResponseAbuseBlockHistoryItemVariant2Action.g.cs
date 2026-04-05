
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseAbuseBlockHistoryItemVariant2Action
    {
        /// <summary>
        /// 
        /// </summary>
        Unblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseAbuseBlockHistoryItemVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAbuseBlockHistoryItemVariant2Action value)
        {
            return value switch
            {
                CreateProjectResponseAbuseBlockHistoryItemVariant2Action.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAbuseBlockHistoryItemVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "unblocked" => CreateProjectResponseAbuseBlockHistoryItemVariant2Action.Unblocked,
                _ => null,
            };
        }
    }
}