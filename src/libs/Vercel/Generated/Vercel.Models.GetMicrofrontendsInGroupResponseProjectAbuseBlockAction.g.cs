
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAbuseBlockAction
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectAbuseBlockActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAbuseBlockAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAbuseBlockAction.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAbuseBlockAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetMicrofrontendsInGroupResponseProjectAbuseBlockAction.Blocked,
                _ => null,
            };
        }
    }
}