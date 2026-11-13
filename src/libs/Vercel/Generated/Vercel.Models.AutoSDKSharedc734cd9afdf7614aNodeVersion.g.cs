
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc734cd9afdf7614aNodeVersion
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
    public static class AutoSDKSharedc734cd9afdf7614aNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc734cd9afdf7614aNodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedc734cd9afdf7614aNodeVersion.x10X => "10.x",
                AutoSDKSharedc734cd9afdf7614aNodeVersion.x12X => "12.x",
                AutoSDKSharedc734cd9afdf7614aNodeVersion.x14X => "14.x",
                AutoSDKSharedc734cd9afdf7614aNodeVersion.x16X => "16.x",
                AutoSDKSharedc734cd9afdf7614aNodeVersion.x18X => "18.x",
                AutoSDKSharedc734cd9afdf7614aNodeVersion.x20X => "20.x",
                AutoSDKSharedc734cd9afdf7614aNodeVersion.x22X => "22.x",
                AutoSDKSharedc734cd9afdf7614aNodeVersion.x24X => "24.x",
                AutoSDKSharedc734cd9afdf7614aNodeVersion.x26X => "26.x",
                AutoSDKSharedc734cd9afdf7614aNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc734cd9afdf7614aNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedc734cd9afdf7614aNodeVersion.x10X,
                "12.x" => AutoSDKSharedc734cd9afdf7614aNodeVersion.x12X,
                "14.x" => AutoSDKSharedc734cd9afdf7614aNodeVersion.x14X,
                "16.x" => AutoSDKSharedc734cd9afdf7614aNodeVersion.x16X,
                "18.x" => AutoSDKSharedc734cd9afdf7614aNodeVersion.x18X,
                "20.x" => AutoSDKSharedc734cd9afdf7614aNodeVersion.x20X,
                "22.x" => AutoSDKSharedc734cd9afdf7614aNodeVersion.x22X,
                "24.x" => AutoSDKSharedc734cd9afdf7614aNodeVersion.x24X,
                "26.x" => AutoSDKSharedc734cd9afdf7614aNodeVersion.x26X,
                "8.10.x" => AutoSDKSharedc734cd9afdf7614aNodeVersion.x810X,
                _ => null,
            };
        }
    }
}