
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectFlatRateTier
    {
        /// <summary>
        /// 
        /// </summary>
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        Base,
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectFlatRateTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectFlatRateTier value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectFlatRateTier.Advanced => "advanced",
                GetMicrofrontendsInGroupResponseProjectFlatRateTier.Base => "base",
                GetMicrofrontendsInGroupResponseProjectFlatRateTier.Critical => "critical",
                GetMicrofrontendsInGroupResponseProjectFlatRateTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectFlatRateTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => GetMicrofrontendsInGroupResponseProjectFlatRateTier.Advanced,
                "base" => GetMicrofrontendsInGroupResponseProjectFlatRateTier.Base,
                "critical" => GetMicrofrontendsInGroupResponseProjectFlatRateTier.Critical,
                "standard" => GetMicrofrontendsInGroupResponseProjectFlatRateTier.Standard,
                _ => null,
            };
        }
    }
}