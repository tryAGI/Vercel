
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ProjectSettingsNodeVersion
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
    public static class GetDeploymentResponseVariant1ProjectSettingsNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ProjectSettingsNodeVersion value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x10X => "10.x",
                GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x12X => "12.x",
                GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x14X => "14.x",
                GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x16X => "16.x",
                GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x18X => "18.x",
                GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x20X => "20.x",
                GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x22X => "22.x",
                GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x24X => "24.x",
                GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ProjectSettingsNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x10X,
                "12.x" => GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x12X,
                "14.x" => GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x14X,
                "16.x" => GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x16X,
                "18.x" => GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x18X,
                "20.x" => GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x20X,
                "22.x" => GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x22X,
                "24.x" => GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x24X,
                "8.10.x" => GetDeploymentResponseVariant1ProjectSettingsNodeVersion.x810X,
                _ => null,
            };
        }
    }
}