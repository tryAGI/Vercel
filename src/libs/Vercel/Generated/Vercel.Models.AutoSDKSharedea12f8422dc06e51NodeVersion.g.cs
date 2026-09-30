
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51NodeVersion
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
        x810X,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedea12f8422dc06e51NodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51NodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51NodeVersion.x10X => "10.x",
                AutoSDKSharedea12f8422dc06e51NodeVersion.x12X => "12.x",
                AutoSDKSharedea12f8422dc06e51NodeVersion.x14X => "14.x",
                AutoSDKSharedea12f8422dc06e51NodeVersion.x16X => "16.x",
                AutoSDKSharedea12f8422dc06e51NodeVersion.x18X => "18.x",
                AutoSDKSharedea12f8422dc06e51NodeVersion.x20X => "20.x",
                AutoSDKSharedea12f8422dc06e51NodeVersion.x22X => "22.x",
                AutoSDKSharedea12f8422dc06e51NodeVersion.x24X => "24.x",
                AutoSDKSharedea12f8422dc06e51NodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51NodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedea12f8422dc06e51NodeVersion.x10X,
                "12.x" => AutoSDKSharedea12f8422dc06e51NodeVersion.x12X,
                "14.x" => AutoSDKSharedea12f8422dc06e51NodeVersion.x14X,
                "16.x" => AutoSDKSharedea12f8422dc06e51NodeVersion.x16X,
                "18.x" => AutoSDKSharedea12f8422dc06e51NodeVersion.x18X,
                "20.x" => AutoSDKSharedea12f8422dc06e51NodeVersion.x20X,
                "22.x" => AutoSDKSharedea12f8422dc06e51NodeVersion.x22X,
                "24.x" => AutoSDKSharedea12f8422dc06e51NodeVersion.x24X,
                "8.10.x" => AutoSDKSharedea12f8422dc06e51NodeVersion.x810X,
                _ => null,
            };
        }
    }
}