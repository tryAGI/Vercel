
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb2df422af367f681NodeVersion
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
    public static class AutoSDKSharedb2df422af367f681NodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb2df422af367f681NodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedb2df422af367f681NodeVersion.x10X => "10.x",
                AutoSDKSharedb2df422af367f681NodeVersion.x12X => "12.x",
                AutoSDKSharedb2df422af367f681NodeVersion.x14X => "14.x",
                AutoSDKSharedb2df422af367f681NodeVersion.x16X => "16.x",
                AutoSDKSharedb2df422af367f681NodeVersion.x18X => "18.x",
                AutoSDKSharedb2df422af367f681NodeVersion.x20X => "20.x",
                AutoSDKSharedb2df422af367f681NodeVersion.x22X => "22.x",
                AutoSDKSharedb2df422af367f681NodeVersion.x24X => "24.x",
                AutoSDKSharedb2df422af367f681NodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb2df422af367f681NodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedb2df422af367f681NodeVersion.x10X,
                "12.x" => AutoSDKSharedb2df422af367f681NodeVersion.x12X,
                "14.x" => AutoSDKSharedb2df422af367f681NodeVersion.x14X,
                "16.x" => AutoSDKSharedb2df422af367f681NodeVersion.x16X,
                "18.x" => AutoSDKSharedb2df422af367f681NodeVersion.x18X,
                "20.x" => AutoSDKSharedb2df422af367f681NodeVersion.x20X,
                "22.x" => AutoSDKSharedb2df422af367f681NodeVersion.x22X,
                "24.x" => AutoSDKSharedb2df422af367f681NodeVersion.x24X,
                "8.10.x" => AutoSDKSharedb2df422af367f681NodeVersion.x810X,
                _ => null,
            };
        }
    }
}