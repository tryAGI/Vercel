
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseBlocks
    {
        /// <summary>
        /// 
        /// </summary>
        BuildStart,
        /// <summary>
        /// 
        /// </summary>
        DeploymentAlias,
        /// <summary>
        /// 
        /// </summary>
        DeploymentPromotion,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStart,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentCheckRunResponseBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseBlocks value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseBlocks.BuildStart => "build-start",
                UpdateDeploymentCheckRunResponseBlocks.DeploymentAlias => "deployment-alias",
                UpdateDeploymentCheckRunResponseBlocks.DeploymentPromotion => "deployment-promotion",
                UpdateDeploymentCheckRunResponseBlocks.DeploymentStart => "deployment-start",
                UpdateDeploymentCheckRunResponseBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => UpdateDeploymentCheckRunResponseBlocks.BuildStart,
                "deployment-alias" => UpdateDeploymentCheckRunResponseBlocks.DeploymentAlias,
                "deployment-promotion" => UpdateDeploymentCheckRunResponseBlocks.DeploymentPromotion,
                "deployment-start" => UpdateDeploymentCheckRunResponseBlocks.DeploymentStart,
                "none" => UpdateDeploymentCheckRunResponseBlocks.None,
                _ => null,
            };
        }
    }
}