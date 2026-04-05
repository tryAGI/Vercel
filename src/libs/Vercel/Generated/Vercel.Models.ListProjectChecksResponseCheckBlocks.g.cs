
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectChecksResponseCheckBlocks
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
    public static class ListProjectChecksResponseCheckBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectChecksResponseCheckBlocks value)
        {
            return value switch
            {
                ListProjectChecksResponseCheckBlocks.BuildStart => "build-start",
                ListProjectChecksResponseCheckBlocks.DeploymentAlias => "deployment-alias",
                ListProjectChecksResponseCheckBlocks.DeploymentPromotion => "deployment-promotion",
                ListProjectChecksResponseCheckBlocks.DeploymentStart => "deployment-start",
                ListProjectChecksResponseCheckBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectChecksResponseCheckBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => ListProjectChecksResponseCheckBlocks.BuildStart,
                "deployment-alias" => ListProjectChecksResponseCheckBlocks.DeploymentAlias,
                "deployment-promotion" => ListProjectChecksResponseCheckBlocks.DeploymentPromotion,
                "deployment-start" => ListProjectChecksResponseCheckBlocks.DeploymentStart,
                "none" => ListProjectChecksResponseCheckBlocks.None,
                _ => null,
            };
        }
    }
}