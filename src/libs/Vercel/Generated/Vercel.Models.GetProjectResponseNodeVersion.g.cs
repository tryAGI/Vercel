
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseNodeVersion
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
    public static class GetProjectResponseNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseNodeVersion value)
        {
            return value switch
            {
                GetProjectResponseNodeVersion.x10X => "10.x",
                GetProjectResponseNodeVersion.x12X => "12.x",
                GetProjectResponseNodeVersion.x14X => "14.x",
                GetProjectResponseNodeVersion.x16X => "16.x",
                GetProjectResponseNodeVersion.x18X => "18.x",
                GetProjectResponseNodeVersion.x20X => "20.x",
                GetProjectResponseNodeVersion.x22X => "22.x",
                GetProjectResponseNodeVersion.x24X => "24.x",
                GetProjectResponseNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => GetProjectResponseNodeVersion.x10X,
                "12.x" => GetProjectResponseNodeVersion.x12X,
                "14.x" => GetProjectResponseNodeVersion.x14X,
                "16.x" => GetProjectResponseNodeVersion.x16X,
                "18.x" => GetProjectResponseNodeVersion.x18X,
                "20.x" => GetProjectResponseNodeVersion.x20X,
                "22.x" => GetProjectResponseNodeVersion.x22X,
                "24.x" => GetProjectResponseNodeVersion.x24X,
                "8.10.x" => GetProjectResponseNodeVersion.x810X,
                _ => null,
            };
        }
    }
}