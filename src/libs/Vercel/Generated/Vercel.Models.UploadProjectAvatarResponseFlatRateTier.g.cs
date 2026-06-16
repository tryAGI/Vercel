
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseFlatRateTier
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
    public static class UploadProjectAvatarResponseFlatRateTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseFlatRateTier value)
        {
            return value switch
            {
                UploadProjectAvatarResponseFlatRateTier.Advanced => "advanced",
                UploadProjectAvatarResponseFlatRateTier.Base => "base",
                UploadProjectAvatarResponseFlatRateTier.Critical => "critical",
                UploadProjectAvatarResponseFlatRateTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseFlatRateTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => UploadProjectAvatarResponseFlatRateTier.Advanced,
                "base" => UploadProjectAvatarResponseFlatRateTier.Base,
                "critical" => UploadProjectAvatarResponseFlatRateTier.Critical,
                "standard" => UploadProjectAvatarResponseFlatRateTier.Standard,
                _ => null,
            };
        }
    }
}