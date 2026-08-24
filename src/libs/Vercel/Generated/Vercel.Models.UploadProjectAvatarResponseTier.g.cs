
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseTier
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
    public static class UploadProjectAvatarResponseTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTier value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTier.Advanced => "advanced",
                UploadProjectAvatarResponseTier.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => UploadProjectAvatarResponseTier.Advanced,
                "critical" => UploadProjectAvatarResponseTier.Critical,
                _ => null,
            };
        }
    }
}