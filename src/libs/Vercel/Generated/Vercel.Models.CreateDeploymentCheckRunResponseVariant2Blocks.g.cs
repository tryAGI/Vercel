
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant2Blocks
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
    public static class CreateDeploymentCheckRunResponseVariant2BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant2Blocks value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant2Blocks.BuildStart => "build-start",
                CreateDeploymentCheckRunResponseVariant2Blocks.DeploymentAlias => "deployment-alias",
                CreateDeploymentCheckRunResponseVariant2Blocks.DeploymentPromotion => "deployment-promotion",
                CreateDeploymentCheckRunResponseVariant2Blocks.DeploymentStart => "deployment-start",
                CreateDeploymentCheckRunResponseVariant2Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant2Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => CreateDeploymentCheckRunResponseVariant2Blocks.BuildStart,
                "deployment-alias" => CreateDeploymentCheckRunResponseVariant2Blocks.DeploymentAlias,
                "deployment-promotion" => CreateDeploymentCheckRunResponseVariant2Blocks.DeploymentPromotion,
                "deployment-start" => CreateDeploymentCheckRunResponseVariant2Blocks.DeploymentStart,
                "none" => CreateDeploymentCheckRunResponseVariant2Blocks.None,
                _ => null,
            };
        }
    }
}