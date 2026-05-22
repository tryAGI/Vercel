
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant1Blocks
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
    public static class UpdateDeploymentCheckRunResponseVariant1BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant1Blocks value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant1Blocks.BuildStart => "build-start",
                UpdateDeploymentCheckRunResponseVariant1Blocks.DeploymentAlias => "deployment-alias",
                UpdateDeploymentCheckRunResponseVariant1Blocks.DeploymentPromotion => "deployment-promotion",
                UpdateDeploymentCheckRunResponseVariant1Blocks.DeploymentStart => "deployment-start",
                UpdateDeploymentCheckRunResponseVariant1Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant1Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => UpdateDeploymentCheckRunResponseVariant1Blocks.BuildStart,
                "deployment-alias" => UpdateDeploymentCheckRunResponseVariant1Blocks.DeploymentAlias,
                "deployment-promotion" => UpdateDeploymentCheckRunResponseVariant1Blocks.DeploymentPromotion,
                "deployment-start" => UpdateDeploymentCheckRunResponseVariant1Blocks.DeploymentStart,
                "none" => UpdateDeploymentCheckRunResponseVariant1Blocks.None,
                _ => null,
            };
        }
    }
}