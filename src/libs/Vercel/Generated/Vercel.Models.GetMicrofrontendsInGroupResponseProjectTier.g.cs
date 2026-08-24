
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTier
    {
        /// <summary>
        /// 
        /// </summary>
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        Critical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTier value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTier.Advanced => "advanced",
                GetMicrofrontendsInGroupResponseProjectTier.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => GetMicrofrontendsInGroupResponseProjectTier.Advanced,
                "critical" => GetMicrofrontendsInGroupResponseProjectTier.Critical,
                _ => null,
            };
        }
    }
}