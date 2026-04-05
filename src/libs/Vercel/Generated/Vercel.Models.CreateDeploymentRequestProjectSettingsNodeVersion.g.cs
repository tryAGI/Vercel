
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Override the Node.js version that should be used for this deployment
    /// </summary>
    public enum CreateDeploymentRequestProjectSettingsNodeVersion
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
    public static class CreateDeploymentRequestProjectSettingsNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestProjectSettingsNodeVersion value)
        {
            return value switch
            {
                CreateDeploymentRequestProjectSettingsNodeVersion.x10X => "10.x",
                CreateDeploymentRequestProjectSettingsNodeVersion.x12X => "12.x",
                CreateDeploymentRequestProjectSettingsNodeVersion.x14X => "14.x",
                CreateDeploymentRequestProjectSettingsNodeVersion.x16X => "16.x",
                CreateDeploymentRequestProjectSettingsNodeVersion.x18X => "18.x",
                CreateDeploymentRequestProjectSettingsNodeVersion.x20X => "20.x",
                CreateDeploymentRequestProjectSettingsNodeVersion.x22X => "22.x",
                CreateDeploymentRequestProjectSettingsNodeVersion.x24X => "24.x",
                CreateDeploymentRequestProjectSettingsNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestProjectSettingsNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => CreateDeploymentRequestProjectSettingsNodeVersion.x10X,
                "12.x" => CreateDeploymentRequestProjectSettingsNodeVersion.x12X,
                "14.x" => CreateDeploymentRequestProjectSettingsNodeVersion.x14X,
                "16.x" => CreateDeploymentRequestProjectSettingsNodeVersion.x16X,
                "18.x" => CreateDeploymentRequestProjectSettingsNodeVersion.x18X,
                "20.x" => CreateDeploymentRequestProjectSettingsNodeVersion.x20X,
                "22.x" => CreateDeploymentRequestProjectSettingsNodeVersion.x22X,
                "24.x" => CreateDeploymentRequestProjectSettingsNodeVersion.x24X,
                "8.10.x" => CreateDeploymentRequestProjectSettingsNodeVersion.x810X,
                _ => null,
            };
        }
    }
}