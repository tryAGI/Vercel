
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseBlocks
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
    public static class CreateDeploymentCheckRunResponseBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseBlocks value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseBlocks.BuildStart => "build-start",
                CreateDeploymentCheckRunResponseBlocks.DeploymentAlias => "deployment-alias",
                CreateDeploymentCheckRunResponseBlocks.DeploymentPromotion => "deployment-promotion",
                CreateDeploymentCheckRunResponseBlocks.DeploymentStart => "deployment-start",
                CreateDeploymentCheckRunResponseBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => CreateDeploymentCheckRunResponseBlocks.BuildStart,
                "deployment-alias" => CreateDeploymentCheckRunResponseBlocks.DeploymentAlias,
                "deployment-promotion" => CreateDeploymentCheckRunResponseBlocks.DeploymentPromotion,
                "deployment-start" => CreateDeploymentCheckRunResponseBlocks.DeploymentStart,
                "none" => CreateDeploymentCheckRunResponseBlocks.None,
                _ => null,
            };
        }
    }
}