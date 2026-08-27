
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant2ProjectSettingsNodeVersion
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
    public static class GetDeploymentResponseVariant2ProjectSettingsNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ProjectSettingsNodeVersion value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x10X => "10.x",
                GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x12X => "12.x",
                GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x14X => "14.x",
                GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x16X => "16.x",
                GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x18X => "18.x",
                GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x20X => "20.x",
                GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x22X => "22.x",
                GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x24X => "24.x",
                GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ProjectSettingsNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x10X,
                "12.x" => GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x12X,
                "14.x" => GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x14X,
                "16.x" => GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x16X,
                "18.x" => GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x18X,
                "20.x" => GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x20X,
                "22.x" => GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x22X,
                "24.x" => GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x24X,
                "8.10.x" => GetDeploymentResponseVariant2ProjectSettingsNodeVersion.x810X,
                _ => null,
            };
        }
    }
}