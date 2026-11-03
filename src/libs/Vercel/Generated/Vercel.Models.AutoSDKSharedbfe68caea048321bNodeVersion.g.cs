
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bNodeVersion
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
    public static class AutoSDKSharedbfe68caea048321bNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bNodeVersion value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bNodeVersion.x10X => "10.x",
                AutoSDKSharedbfe68caea048321bNodeVersion.x12X => "12.x",
                AutoSDKSharedbfe68caea048321bNodeVersion.x14X => "14.x",
                AutoSDKSharedbfe68caea048321bNodeVersion.x16X => "16.x",
                AutoSDKSharedbfe68caea048321bNodeVersion.x18X => "18.x",
                AutoSDKSharedbfe68caea048321bNodeVersion.x20X => "20.x",
                AutoSDKSharedbfe68caea048321bNodeVersion.x22X => "22.x",
                AutoSDKSharedbfe68caea048321bNodeVersion.x24X => "24.x",
                AutoSDKSharedbfe68caea048321bNodeVersion.x26X => "26.x",
                AutoSDKSharedbfe68caea048321bNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => AutoSDKSharedbfe68caea048321bNodeVersion.x10X,
                "12.x" => AutoSDKSharedbfe68caea048321bNodeVersion.x12X,
                "14.x" => AutoSDKSharedbfe68caea048321bNodeVersion.x14X,
                "16.x" => AutoSDKSharedbfe68caea048321bNodeVersion.x16X,
                "18.x" => AutoSDKSharedbfe68caea048321bNodeVersion.x18X,
                "20.x" => AutoSDKSharedbfe68caea048321bNodeVersion.x20X,
                "22.x" => AutoSDKSharedbfe68caea048321bNodeVersion.x22X,
                "24.x" => AutoSDKSharedbfe68caea048321bNodeVersion.x24X,
                "26.x" => AutoSDKSharedbfe68caea048321bNodeVersion.x26X,
                "8.10.x" => AutoSDKSharedbfe68caea048321bNodeVersion.x810X,
                _ => null,
            };
        }
    }
}