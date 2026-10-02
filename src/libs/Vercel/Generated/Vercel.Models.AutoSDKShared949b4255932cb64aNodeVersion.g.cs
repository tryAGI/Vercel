
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared949b4255932cb64aNodeVersion
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
    public static class AutoSDKShared949b4255932cb64aNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared949b4255932cb64aNodeVersion value)
        {
            return value switch
            {
                AutoSDKShared949b4255932cb64aNodeVersion.x10X => "10.x",
                AutoSDKShared949b4255932cb64aNodeVersion.x12X => "12.x",
                AutoSDKShared949b4255932cb64aNodeVersion.x14X => "14.x",
                AutoSDKShared949b4255932cb64aNodeVersion.x16X => "16.x",
                AutoSDKShared949b4255932cb64aNodeVersion.x18X => "18.x",
                AutoSDKShared949b4255932cb64aNodeVersion.x20X => "20.x",
                AutoSDKShared949b4255932cb64aNodeVersion.x22X => "22.x",
                AutoSDKShared949b4255932cb64aNodeVersion.x24X => "24.x",
                AutoSDKShared949b4255932cb64aNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared949b4255932cb64aNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKShared949b4255932cb64aNodeVersion.x10X,
                "12.x" => AutoSDKShared949b4255932cb64aNodeVersion.x12X,
                "14.x" => AutoSDKShared949b4255932cb64aNodeVersion.x14X,
                "16.x" => AutoSDKShared949b4255932cb64aNodeVersion.x16X,
                "18.x" => AutoSDKShared949b4255932cb64aNodeVersion.x18X,
                "20.x" => AutoSDKShared949b4255932cb64aNodeVersion.x20X,
                "22.x" => AutoSDKShared949b4255932cb64aNodeVersion.x22X,
                "24.x" => AutoSDKShared949b4255932cb64aNodeVersion.x24X,
                "8.10.x" => AutoSDKShared949b4255932cb64aNodeVersion.x810X,
                _ => null,
            };
        }
    }
}