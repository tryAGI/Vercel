
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant1Blocks
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
    public static class GetDeploymentCheckRunResponseVariant1BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant1Blocks value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant1Blocks.BuildStart => "build-start",
                GetDeploymentCheckRunResponseVariant1Blocks.DeploymentAlias => "deployment-alias",
                GetDeploymentCheckRunResponseVariant1Blocks.DeploymentPromotion => "deployment-promotion",
                GetDeploymentCheckRunResponseVariant1Blocks.DeploymentStart => "deployment-start",
                GetDeploymentCheckRunResponseVariant1Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant1Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => GetDeploymentCheckRunResponseVariant1Blocks.BuildStart,
                "deployment-alias" => GetDeploymentCheckRunResponseVariant1Blocks.DeploymentAlias,
                "deployment-promotion" => GetDeploymentCheckRunResponseVariant1Blocks.DeploymentPromotion,
                "deployment-start" => GetDeploymentCheckRunResponseVariant1Blocks.DeploymentStart,
                "none" => GetDeploymentCheckRunResponseVariant1Blocks.None,
                _ => null,
            };
        }
    }
}