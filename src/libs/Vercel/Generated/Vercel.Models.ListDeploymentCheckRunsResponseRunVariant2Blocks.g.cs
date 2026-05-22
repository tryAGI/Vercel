
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant2Blocks
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
    public static class ListDeploymentCheckRunsResponseRunVariant2BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant2Blocks value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant2Blocks.BuildStart => "build-start",
                ListDeploymentCheckRunsResponseRunVariant2Blocks.DeploymentAlias => "deployment-alias",
                ListDeploymentCheckRunsResponseRunVariant2Blocks.DeploymentPromotion => "deployment-promotion",
                ListDeploymentCheckRunsResponseRunVariant2Blocks.DeploymentStart => "deployment-start",
                ListDeploymentCheckRunsResponseRunVariant2Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant2Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => ListDeploymentCheckRunsResponseRunVariant2Blocks.BuildStart,
                "deployment-alias" => ListDeploymentCheckRunsResponseRunVariant2Blocks.DeploymentAlias,
                "deployment-promotion" => ListDeploymentCheckRunsResponseRunVariant2Blocks.DeploymentPromotion,
                "deployment-start" => ListDeploymentCheckRunsResponseRunVariant2Blocks.DeploymentStart,
                "none" => ListDeploymentCheckRunsResponseRunVariant2Blocks.None,
                _ => null,
            };
        }
    }
}