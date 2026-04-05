
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectChecksBlocks
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
    public static class ListProjectChecksBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectChecksBlocks value)
        {
            return value switch
            {
                ListProjectChecksBlocks.BuildStart => "build-start",
                ListProjectChecksBlocks.DeploymentAlias => "deployment-alias",
                ListProjectChecksBlocks.DeploymentPromotion => "deployment-promotion",
                ListProjectChecksBlocks.DeploymentStart => "deployment-start",
                ListProjectChecksBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectChecksBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => ListProjectChecksBlocks.BuildStart,
                "deployment-alias" => ListProjectChecksBlocks.DeploymentAlias,
                "deployment-promotion" => ListProjectChecksBlocks.DeploymentPromotion,
                "deployment-start" => ListProjectChecksBlocks.DeploymentStart,
                "none" => ListProjectChecksBlocks.None,
                _ => null,
            };
        }
    }
}