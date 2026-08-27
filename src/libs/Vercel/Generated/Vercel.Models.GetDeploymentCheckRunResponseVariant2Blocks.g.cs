
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant2Blocks
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
    public static class GetDeploymentCheckRunResponseVariant2BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant2Blocks value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant2Blocks.BuildStart => "build-start",
                GetDeploymentCheckRunResponseVariant2Blocks.DeploymentAlias => "deployment-alias",
                GetDeploymentCheckRunResponseVariant2Blocks.DeploymentPromotion => "deployment-promotion",
                GetDeploymentCheckRunResponseVariant2Blocks.DeploymentStart => "deployment-start",
                GetDeploymentCheckRunResponseVariant2Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant2Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => GetDeploymentCheckRunResponseVariant2Blocks.BuildStart,
                "deployment-alias" => GetDeploymentCheckRunResponseVariant2Blocks.DeploymentAlias,
                "deployment-promotion" => GetDeploymentCheckRunResponseVariant2Blocks.DeploymentPromotion,
                "deployment-start" => GetDeploymentCheckRunResponseVariant2Blocks.DeploymentStart,
                "none" => GetDeploymentCheckRunResponseVariant2Blocks.None,
                _ => null,
            };
        }
    }
}