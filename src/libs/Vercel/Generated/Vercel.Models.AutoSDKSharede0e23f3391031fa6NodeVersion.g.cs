
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6NodeVersion
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
    public static class AutoSDKSharede0e23f3391031fa6NodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6NodeVersion value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6NodeVersion.x10X => "10.x",
                AutoSDKSharede0e23f3391031fa6NodeVersion.x12X => "12.x",
                AutoSDKSharede0e23f3391031fa6NodeVersion.x14X => "14.x",
                AutoSDKSharede0e23f3391031fa6NodeVersion.x16X => "16.x",
                AutoSDKSharede0e23f3391031fa6NodeVersion.x18X => "18.x",
                AutoSDKSharede0e23f3391031fa6NodeVersion.x20X => "20.x",
                AutoSDKSharede0e23f3391031fa6NodeVersion.x22X => "22.x",
                AutoSDKSharede0e23f3391031fa6NodeVersion.x24X => "24.x",
                AutoSDKSharede0e23f3391031fa6NodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6NodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharede0e23f3391031fa6NodeVersion.x10X,
                "12.x" => AutoSDKSharede0e23f3391031fa6NodeVersion.x12X,
                "14.x" => AutoSDKSharede0e23f3391031fa6NodeVersion.x14X,
                "16.x" => AutoSDKSharede0e23f3391031fa6NodeVersion.x16X,
                "18.x" => AutoSDKSharede0e23f3391031fa6NodeVersion.x18X,
                "20.x" => AutoSDKSharede0e23f3391031fa6NodeVersion.x20X,
                "22.x" => AutoSDKSharede0e23f3391031fa6NodeVersion.x22X,
                "24.x" => AutoSDKSharede0e23f3391031fa6NodeVersion.x24X,
                "8.10.x" => AutoSDKSharede0e23f3391031fa6NodeVersion.x810X,
                _ => null,
            };
        }
    }
}