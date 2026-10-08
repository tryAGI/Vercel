
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eNodeVersion
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
    public static class AutoSDKSharede870b907cc1fb37eNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eNodeVersion value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eNodeVersion.x10X => "10.x",
                AutoSDKSharede870b907cc1fb37eNodeVersion.x12X => "12.x",
                AutoSDKSharede870b907cc1fb37eNodeVersion.x14X => "14.x",
                AutoSDKSharede870b907cc1fb37eNodeVersion.x16X => "16.x",
                AutoSDKSharede870b907cc1fb37eNodeVersion.x18X => "18.x",
                AutoSDKSharede870b907cc1fb37eNodeVersion.x20X => "20.x",
                AutoSDKSharede870b907cc1fb37eNodeVersion.x22X => "22.x",
                AutoSDKSharede870b907cc1fb37eNodeVersion.x24X => "24.x",
                AutoSDKSharede870b907cc1fb37eNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharede870b907cc1fb37eNodeVersion.x10X,
                "12.x" => AutoSDKSharede870b907cc1fb37eNodeVersion.x12X,
                "14.x" => AutoSDKSharede870b907cc1fb37eNodeVersion.x14X,
                "16.x" => AutoSDKSharede870b907cc1fb37eNodeVersion.x16X,
                "18.x" => AutoSDKSharede870b907cc1fb37eNodeVersion.x18X,
                "20.x" => AutoSDKSharede870b907cc1fb37eNodeVersion.x20X,
                "22.x" => AutoSDKSharede870b907cc1fb37eNodeVersion.x22X,
                "24.x" => AutoSDKSharede870b907cc1fb37eNodeVersion.x24X,
                "8.10.x" => AutoSDKSharede870b907cc1fb37eNodeVersion.x810X,
                _ => null,
            };
        }
    }
}