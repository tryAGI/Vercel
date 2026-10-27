
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbe3f0c688bc34a31NodeVersion
    {
        /// <summary>
        ///
        /// </summary>
        x10X,
        /// <summary>
        ///
        /// </summary>
        x12X,
        /// <summary>
        ///
        /// </summary>
        x14X,
        /// <summary>
        ///
        /// </summary>
        x16X,
        /// <summary>
        ///
        /// </summary>
        x18X,
        /// <summary>
        ///
        /// </summary>
        x20X,
        /// <summary>
        ///
        /// </summary>
        x22X,
        /// <summary>
        ///
        /// </summary>
        x24X,
        /// <summary>
        ///
        /// </summary>
        x26X,
        /// <summary>
        ///
        /// </summary>
        x810X,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbe3f0c688bc34a31NodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbe3f0c688bc34a31NodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedbe3f0c688bc34a31NodeVersion.x10X => "10.x",
                AutoSDKSharedbe3f0c688bc34a31NodeVersion.x12X => "12.x",
                AutoSDKSharedbe3f0c688bc34a31NodeVersion.x14X => "14.x",
                AutoSDKSharedbe3f0c688bc34a31NodeVersion.x16X => "16.x",
                AutoSDKSharedbe3f0c688bc34a31NodeVersion.x18X => "18.x",
                AutoSDKSharedbe3f0c688bc34a31NodeVersion.x20X => "20.x",
                AutoSDKSharedbe3f0c688bc34a31NodeVersion.x22X => "22.x",
                AutoSDKSharedbe3f0c688bc34a31NodeVersion.x24X => "24.x",
                AutoSDKSharedbe3f0c688bc34a31NodeVersion.x26X => "26.x",
                AutoSDKSharedbe3f0c688bc34a31NodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbe3f0c688bc34a31NodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedbe3f0c688bc34a31NodeVersion.x10X,
                "12.x" => AutoSDKSharedbe3f0c688bc34a31NodeVersion.x12X,
                "14.x" => AutoSDKSharedbe3f0c688bc34a31NodeVersion.x14X,
                "16.x" => AutoSDKSharedbe3f0c688bc34a31NodeVersion.x16X,
                "18.x" => AutoSDKSharedbe3f0c688bc34a31NodeVersion.x18X,
                "20.x" => AutoSDKSharedbe3f0c688bc34a31NodeVersion.x20X,
                "22.x" => AutoSDKSharedbe3f0c688bc34a31NodeVersion.x22X,
                "24.x" => AutoSDKSharedbe3f0c688bc34a31NodeVersion.x24X,
                "26.x" => AutoSDKSharedbe3f0c688bc34a31NodeVersion.x26X,
                "8.10.x" => AutoSDKSharedbe3f0c688bc34a31NodeVersion.x810X,
                _ => null,
            };
        }
    }
}