
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseNodeVersion
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
    public static class UpdateProjectResponseNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseNodeVersion value)
        {
            return value switch
            {
                UpdateProjectResponseNodeVersion.x10X => "10.x",
                UpdateProjectResponseNodeVersion.x12X => "12.x",
                UpdateProjectResponseNodeVersion.x14X => "14.x",
                UpdateProjectResponseNodeVersion.x16X => "16.x",
                UpdateProjectResponseNodeVersion.x18X => "18.x",
                UpdateProjectResponseNodeVersion.x20X => "20.x",
                UpdateProjectResponseNodeVersion.x22X => "22.x",
                UpdateProjectResponseNodeVersion.x24X => "24.x",
                UpdateProjectResponseNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => UpdateProjectResponseNodeVersion.x10X,
                "12.x" => UpdateProjectResponseNodeVersion.x12X,
                "14.x" => UpdateProjectResponseNodeVersion.x14X,
                "16.x" => UpdateProjectResponseNodeVersion.x16X,
                "18.x" => UpdateProjectResponseNodeVersion.x18X,
                "20.x" => UpdateProjectResponseNodeVersion.x20X,
                "22.x" => UpdateProjectResponseNodeVersion.x22X,
                "24.x" => UpdateProjectResponseNodeVersion.x24X,
                "8.10.x" => UpdateProjectResponseNodeVersion.x810X,
                _ => null,
            };
        }
    }
}