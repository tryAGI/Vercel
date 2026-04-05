
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunBlocks
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
    public static class ListDeploymentCheckRunsResponseRunBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunBlocks value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunBlocks.BuildStart => "build-start",
                ListDeploymentCheckRunsResponseRunBlocks.DeploymentAlias => "deployment-alias",
                ListDeploymentCheckRunsResponseRunBlocks.DeploymentPromotion => "deployment-promotion",
                ListDeploymentCheckRunsResponseRunBlocks.DeploymentStart => "deployment-start",
                ListDeploymentCheckRunsResponseRunBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => ListDeploymentCheckRunsResponseRunBlocks.BuildStart,
                "deployment-alias" => ListDeploymentCheckRunsResponseRunBlocks.DeploymentAlias,
                "deployment-promotion" => ListDeploymentCheckRunsResponseRunBlocks.DeploymentPromotion,
                "deployment-start" => ListDeploymentCheckRunsResponseRunBlocks.DeploymentStart,
                "none" => ListDeploymentCheckRunsResponseRunBlocks.None,
                _ => null,
            };
        }
    }
}