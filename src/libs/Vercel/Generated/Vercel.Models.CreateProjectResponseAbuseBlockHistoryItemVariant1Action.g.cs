
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseAbuseBlockHistoryItemVariant1Action
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseAbuseBlockHistoryItemVariant1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAbuseBlockHistoryItemVariant1Action value)
        {
            return value switch
            {
                CreateProjectResponseAbuseBlockHistoryItemVariant1Action.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAbuseBlockHistoryItemVariant1Action? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => CreateProjectResponseAbuseBlockHistoryItemVariant1Action.Blocked,
                _ => null,
            };
        }
    }
}