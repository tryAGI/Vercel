
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If set it overrides the `projectSettings.nodeVersion` for this deployment.
    /// </summary>
    public enum CreateDeploymentResponseNodeVersion
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
    public static class CreateDeploymentResponseNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseNodeVersion value)
        {
            return value switch
            {
                CreateDeploymentResponseNodeVersion.x10X => "10.x",
                CreateDeploymentResponseNodeVersion.x12X => "12.x",
                CreateDeploymentResponseNodeVersion.x14X => "14.x",
                CreateDeploymentResponseNodeVersion.x16X => "16.x",
                CreateDeploymentResponseNodeVersion.x18X => "18.x",
                CreateDeploymentResponseNodeVersion.x20X => "20.x",
                CreateDeploymentResponseNodeVersion.x22X => "22.x",
                CreateDeploymentResponseNodeVersion.x24X => "24.x",
                CreateDeploymentResponseNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => CreateDeploymentResponseNodeVersion.x10X,
                "12.x" => CreateDeploymentResponseNodeVersion.x12X,
                "14.x" => CreateDeploymentResponseNodeVersion.x14X,
                "16.x" => CreateDeploymentResponseNodeVersion.x16X,
                "18.x" => CreateDeploymentResponseNodeVersion.x18X,
                "20.x" => CreateDeploymentResponseNodeVersion.x20X,
                "22.x" => CreateDeploymentResponseNodeVersion.x22X,
                "24.x" => CreateDeploymentResponseNodeVersion.x24X,
                "8.10.x" => CreateDeploymentResponseNodeVersion.x810X,
                _ => null,
            };
        }
    }
}