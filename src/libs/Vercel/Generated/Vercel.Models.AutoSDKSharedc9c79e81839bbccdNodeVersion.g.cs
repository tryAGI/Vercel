
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdNodeVersion
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
    public static class AutoSDKSharedc9c79e81839bbccdNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdNodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdNodeVersion.x10X => "10.x",
                AutoSDKSharedc9c79e81839bbccdNodeVersion.x12X => "12.x",
                AutoSDKSharedc9c79e81839bbccdNodeVersion.x14X => "14.x",
                AutoSDKSharedc9c79e81839bbccdNodeVersion.x16X => "16.x",
                AutoSDKSharedc9c79e81839bbccdNodeVersion.x18X => "18.x",
                AutoSDKSharedc9c79e81839bbccdNodeVersion.x20X => "20.x",
                AutoSDKSharedc9c79e81839bbccdNodeVersion.x22X => "22.x",
                AutoSDKSharedc9c79e81839bbccdNodeVersion.x24X => "24.x",
                AutoSDKSharedc9c79e81839bbccdNodeVersion.x26X => "26.x",
                AutoSDKSharedc9c79e81839bbccdNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedc9c79e81839bbccdNodeVersion.x10X,
                "12.x" => AutoSDKSharedc9c79e81839bbccdNodeVersion.x12X,
                "14.x" => AutoSDKSharedc9c79e81839bbccdNodeVersion.x14X,
                "16.x" => AutoSDKSharedc9c79e81839bbccdNodeVersion.x16X,
                "18.x" => AutoSDKSharedc9c79e81839bbccdNodeVersion.x18X,
                "20.x" => AutoSDKSharedc9c79e81839bbccdNodeVersion.x20X,
                "22.x" => AutoSDKSharedc9c79e81839bbccdNodeVersion.x22X,
                "24.x" => AutoSDKSharedc9c79e81839bbccdNodeVersion.x24X,
                "26.x" => AutoSDKSharedc9c79e81839bbccdNodeVersion.x26X,
                "8.10.x" => AutoSDKSharedc9c79e81839bbccdNodeVersion.x810X,
                _ => null,
            };
        }
    }
}