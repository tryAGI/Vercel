
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant2Blocks
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
    public static class UpdateDeploymentCheckRunResponseVariant2BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant2Blocks value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant2Blocks.BuildStart => "build-start",
                UpdateDeploymentCheckRunResponseVariant2Blocks.DeploymentAlias => "deployment-alias",
                UpdateDeploymentCheckRunResponseVariant2Blocks.DeploymentPromotion => "deployment-promotion",
                UpdateDeploymentCheckRunResponseVariant2Blocks.DeploymentStart => "deployment-start",
                UpdateDeploymentCheckRunResponseVariant2Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant2Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => UpdateDeploymentCheckRunResponseVariant2Blocks.BuildStart,
                "deployment-alias" => UpdateDeploymentCheckRunResponseVariant2Blocks.DeploymentAlias,
                "deployment-promotion" => UpdateDeploymentCheckRunResponseVariant2Blocks.DeploymentPromotion,
                "deployment-start" => UpdateDeploymentCheckRunResponseVariant2Blocks.DeploymentStart,
                "none" => UpdateDeploymentCheckRunResponseVariant2Blocks.None,
                _ => null,
            };
        }
    }
}