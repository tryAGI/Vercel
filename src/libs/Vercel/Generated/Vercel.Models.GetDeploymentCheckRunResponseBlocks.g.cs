
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseBlocks
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
    public static class GetDeploymentCheckRunResponseBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseBlocks value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseBlocks.BuildStart => "build-start",
                GetDeploymentCheckRunResponseBlocks.DeploymentAlias => "deployment-alias",
                GetDeploymentCheckRunResponseBlocks.DeploymentPromotion => "deployment-promotion",
                GetDeploymentCheckRunResponseBlocks.DeploymentStart => "deployment-start",
                GetDeploymentCheckRunResponseBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => GetDeploymentCheckRunResponseBlocks.BuildStart,
                "deployment-alias" => GetDeploymentCheckRunResponseBlocks.DeploymentAlias,
                "deployment-promotion" => GetDeploymentCheckRunResponseBlocks.DeploymentPromotion,
                "deployment-start" => GetDeploymentCheckRunResponseBlocks.DeploymentStart,
                "none" => GetDeploymentCheckRunResponseBlocks.None,
                _ => null,
            };
        }
    }
}