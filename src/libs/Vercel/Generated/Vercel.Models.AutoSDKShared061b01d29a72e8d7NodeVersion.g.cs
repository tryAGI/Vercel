
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7NodeVersion
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
    public static class AutoSDKShared061b01d29a72e8d7NodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7NodeVersion value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7NodeVersion.x10X => "10.x",
                AutoSDKShared061b01d29a72e8d7NodeVersion.x12X => "12.x",
                AutoSDKShared061b01d29a72e8d7NodeVersion.x14X => "14.x",
                AutoSDKShared061b01d29a72e8d7NodeVersion.x16X => "16.x",
                AutoSDKShared061b01d29a72e8d7NodeVersion.x18X => "18.x",
                AutoSDKShared061b01d29a72e8d7NodeVersion.x20X => "20.x",
                AutoSDKShared061b01d29a72e8d7NodeVersion.x22X => "22.x",
                AutoSDKShared061b01d29a72e8d7NodeVersion.x24X => "24.x",
                AutoSDKShared061b01d29a72e8d7NodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7NodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKShared061b01d29a72e8d7NodeVersion.x10X,
                "12.x" => AutoSDKShared061b01d29a72e8d7NodeVersion.x12X,
                "14.x" => AutoSDKShared061b01d29a72e8d7NodeVersion.x14X,
                "16.x" => AutoSDKShared061b01d29a72e8d7NodeVersion.x16X,
                "18.x" => AutoSDKShared061b01d29a72e8d7NodeVersion.x18X,
                "20.x" => AutoSDKShared061b01d29a72e8d7NodeVersion.x20X,
                "22.x" => AutoSDKShared061b01d29a72e8d7NodeVersion.x22X,
                "24.x" => AutoSDKShared061b01d29a72e8d7NodeVersion.x24X,
                "8.10.x" => AutoSDKShared061b01d29a72e8d7NodeVersion.x810X,
                _ => null,
            };
        }
    }
}