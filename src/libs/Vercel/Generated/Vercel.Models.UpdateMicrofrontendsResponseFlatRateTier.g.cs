
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseFlatRateTier
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
    public static class UpdateMicrofrontendsResponseFlatRateTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseFlatRateTier value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseFlatRateTier.Advanced => "advanced",
                UpdateMicrofrontendsResponseFlatRateTier.Base => "base",
                UpdateMicrofrontendsResponseFlatRateTier.Critical => "critical",
                UpdateMicrofrontendsResponseFlatRateTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseFlatRateTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => UpdateMicrofrontendsResponseFlatRateTier.Advanced,
                "base" => UpdateMicrofrontendsResponseFlatRateTier.Base,
                "critical" => UpdateMicrofrontendsResponseFlatRateTier.Critical,
                "standard" => UpdateMicrofrontendsResponseFlatRateTier.Standard,
                _ => null,
            };
        }
    }
}