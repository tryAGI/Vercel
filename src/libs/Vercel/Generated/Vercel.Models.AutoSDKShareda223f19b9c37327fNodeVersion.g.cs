
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fNodeVersion
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
    public static class AutoSDKShareda223f19b9c37327fNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fNodeVersion value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fNodeVersion.x10X => "10.x",
                AutoSDKShareda223f19b9c37327fNodeVersion.x12X => "12.x",
                AutoSDKShareda223f19b9c37327fNodeVersion.x14X => "14.x",
                AutoSDKShareda223f19b9c37327fNodeVersion.x16X => "16.x",
                AutoSDKShareda223f19b9c37327fNodeVersion.x18X => "18.x",
                AutoSDKShareda223f19b9c37327fNodeVersion.x20X => "20.x",
                AutoSDKShareda223f19b9c37327fNodeVersion.x22X => "22.x",
                AutoSDKShareda223f19b9c37327fNodeVersion.x24X => "24.x",
                AutoSDKShareda223f19b9c37327fNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKShareda223f19b9c37327fNodeVersion.x10X,
                "12.x" => AutoSDKShareda223f19b9c37327fNodeVersion.x12X,
                "14.x" => AutoSDKShareda223f19b9c37327fNodeVersion.x14X,
                "16.x" => AutoSDKShareda223f19b9c37327fNodeVersion.x16X,
                "18.x" => AutoSDKShareda223f19b9c37327fNodeVersion.x18X,
                "20.x" => AutoSDKShareda223f19b9c37327fNodeVersion.x20X,
                "22.x" => AutoSDKShareda223f19b9c37327fNodeVersion.x22X,
                "24.x" => AutoSDKShareda223f19b9c37327fNodeVersion.x24X,
                "8.10.x" => AutoSDKShareda223f19b9c37327fNodeVersion.x810X,
                _ => null,
            };
        }
    }
}