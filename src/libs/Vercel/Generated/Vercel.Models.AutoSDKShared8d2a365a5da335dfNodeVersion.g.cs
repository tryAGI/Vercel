
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8d2a365a5da335dfNodeVersion
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
    public static class AutoSDKShared8d2a365a5da335dfNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8d2a365a5da335dfNodeVersion value)
        {
            return value switch
            {
                AutoSDKShared8d2a365a5da335dfNodeVersion.x10X => "10.x",
                AutoSDKShared8d2a365a5da335dfNodeVersion.x12X => "12.x",
                AutoSDKShared8d2a365a5da335dfNodeVersion.x14X => "14.x",
                AutoSDKShared8d2a365a5da335dfNodeVersion.x16X => "16.x",
                AutoSDKShared8d2a365a5da335dfNodeVersion.x18X => "18.x",
                AutoSDKShared8d2a365a5da335dfNodeVersion.x20X => "20.x",
                AutoSDKShared8d2a365a5da335dfNodeVersion.x22X => "22.x",
                AutoSDKShared8d2a365a5da335dfNodeVersion.x24X => "24.x",
                AutoSDKShared8d2a365a5da335dfNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8d2a365a5da335dfNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKShared8d2a365a5da335dfNodeVersion.x10X,
                "12.x" => AutoSDKShared8d2a365a5da335dfNodeVersion.x12X,
                "14.x" => AutoSDKShared8d2a365a5da335dfNodeVersion.x14X,
                "16.x" => AutoSDKShared8d2a365a5da335dfNodeVersion.x16X,
                "18.x" => AutoSDKShared8d2a365a5da335dfNodeVersion.x18X,
                "20.x" => AutoSDKShared8d2a365a5da335dfNodeVersion.x20X,
                "22.x" => AutoSDKShared8d2a365a5da335dfNodeVersion.x22X,
                "24.x" => AutoSDKShared8d2a365a5da335dfNodeVersion.x24X,
                "8.10.x" => AutoSDKShared8d2a365a5da335dfNodeVersion.x810X,
                _ => null,
            };
        }
    }
}