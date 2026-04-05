
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseProjectSettingsNodeVersion
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
    public static class CancelDeploymentResponseProjectSettingsNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseProjectSettingsNodeVersion value)
        {
            return value switch
            {
                CancelDeploymentResponseProjectSettingsNodeVersion.x10X => "10.x",
                CancelDeploymentResponseProjectSettingsNodeVersion.x12X => "12.x",
                CancelDeploymentResponseProjectSettingsNodeVersion.x14X => "14.x",
                CancelDeploymentResponseProjectSettingsNodeVersion.x16X => "16.x",
                CancelDeploymentResponseProjectSettingsNodeVersion.x18X => "18.x",
                CancelDeploymentResponseProjectSettingsNodeVersion.x20X => "20.x",
                CancelDeploymentResponseProjectSettingsNodeVersion.x22X => "22.x",
                CancelDeploymentResponseProjectSettingsNodeVersion.x24X => "24.x",
                CancelDeploymentResponseProjectSettingsNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseProjectSettingsNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => CancelDeploymentResponseProjectSettingsNodeVersion.x10X,
                "12.x" => CancelDeploymentResponseProjectSettingsNodeVersion.x12X,
                "14.x" => CancelDeploymentResponseProjectSettingsNodeVersion.x14X,
                "16.x" => CancelDeploymentResponseProjectSettingsNodeVersion.x16X,
                "18.x" => CancelDeploymentResponseProjectSettingsNodeVersion.x18X,
                "20.x" => CancelDeploymentResponseProjectSettingsNodeVersion.x20X,
                "22.x" => CancelDeploymentResponseProjectSettingsNodeVersion.x22X,
                "24.x" => CancelDeploymentResponseProjectSettingsNodeVersion.x24X,
                "8.10.x" => CancelDeploymentResponseProjectSettingsNodeVersion.x810X,
                _ => null,
            };
        }
    }
}