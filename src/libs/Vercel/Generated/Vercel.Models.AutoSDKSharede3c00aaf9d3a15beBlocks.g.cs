
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede3c00aaf9d3a15beBlocks
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
    public static class AutoSDKSharede3c00aaf9d3a15beBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede3c00aaf9d3a15beBlocks value)
        {
            return value switch
            {
                AutoSDKSharede3c00aaf9d3a15beBlocks.BuildStart => "build-start",
                AutoSDKSharede3c00aaf9d3a15beBlocks.DeploymentAlias => "deployment-alias",
                AutoSDKSharede3c00aaf9d3a15beBlocks.DeploymentPromotion => "deployment-promotion",
                AutoSDKSharede3c00aaf9d3a15beBlocks.DeploymentStart => "deployment-start",
                AutoSDKSharede3c00aaf9d3a15beBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede3c00aaf9d3a15beBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => AutoSDKSharede3c00aaf9d3a15beBlocks.BuildStart,
                "deployment-alias" => AutoSDKSharede3c00aaf9d3a15beBlocks.DeploymentAlias,
                "deployment-promotion" => AutoSDKSharede3c00aaf9d3a15beBlocks.DeploymentPromotion,
                "deployment-start" => AutoSDKSharede3c00aaf9d3a15beBlocks.DeploymentStart,
                "none" => AutoSDKSharede3c00aaf9d3a15beBlocks.None,
                _ => null,
            };
        }
    }
}