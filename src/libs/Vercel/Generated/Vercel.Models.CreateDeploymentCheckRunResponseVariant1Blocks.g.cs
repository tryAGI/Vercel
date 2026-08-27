
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant1Blocks
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
    public static class CreateDeploymentCheckRunResponseVariant1BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant1Blocks value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant1Blocks.BuildStart => "build-start",
                CreateDeploymentCheckRunResponseVariant1Blocks.DeploymentAlias => "deployment-alias",
                CreateDeploymentCheckRunResponseVariant1Blocks.DeploymentPromotion => "deployment-promotion",
                CreateDeploymentCheckRunResponseVariant1Blocks.DeploymentStart => "deployment-start",
                CreateDeploymentCheckRunResponseVariant1Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant1Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => CreateDeploymentCheckRunResponseVariant1Blocks.BuildStart,
                "deployment-alias" => CreateDeploymentCheckRunResponseVariant1Blocks.DeploymentAlias,
                "deployment-promotion" => CreateDeploymentCheckRunResponseVariant1Blocks.DeploymentPromotion,
                "deployment-start" => CreateDeploymentCheckRunResponseVariant1Blocks.DeploymentStart,
                "none" => CreateDeploymentCheckRunResponseVariant1Blocks.None,
                _ => null,
            };
        }
    }
}