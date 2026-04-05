
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If set it overrides the `projectSettings.nodeVersion` for this deployment.
    /// </summary>
    public enum CancelDeploymentResponseNodeVersion
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
    public static class CancelDeploymentResponseNodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseNodeVersion value)
        {
            return value switch
            {
                CancelDeploymentResponseNodeVersion.x10X => "10.x",
                CancelDeploymentResponseNodeVersion.x12X => "12.x",
                CancelDeploymentResponseNodeVersion.x14X => "14.x",
                CancelDeploymentResponseNodeVersion.x16X => "16.x",
                CancelDeploymentResponseNodeVersion.x18X => "18.x",
                CancelDeploymentResponseNodeVersion.x20X => "20.x",
                CancelDeploymentResponseNodeVersion.x22X => "22.x",
                CancelDeploymentResponseNodeVersion.x24X => "24.x",
                CancelDeploymentResponseNodeVersion.x810X => "8.10.x",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseNodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "10.x" => CancelDeploymentResponseNodeVersion.x10X,
                "12.x" => CancelDeploymentResponseNodeVersion.x12X,
                "14.x" => CancelDeploymentResponseNodeVersion.x14X,
                "16.x" => CancelDeploymentResponseNodeVersion.x16X,
                "18.x" => CancelDeploymentResponseNodeVersion.x18X,
                "20.x" => CancelDeploymentResponseNodeVersion.x20X,
                "22.x" => CancelDeploymentResponseNodeVersion.x22X,
                "24.x" => CancelDeploymentResponseNodeVersion.x24X,
                "8.10.x" => CancelDeploymentResponseNodeVersion.x810X,
                _ => null,
            };
        }
    }
}