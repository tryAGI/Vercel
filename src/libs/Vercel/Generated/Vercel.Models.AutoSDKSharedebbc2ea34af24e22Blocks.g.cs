
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedebbc2ea34af24e22Blocks
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
    public static class AutoSDKSharedebbc2ea34af24e22BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedebbc2ea34af24e22Blocks value)
        {
            return value switch
            {
                AutoSDKSharedebbc2ea34af24e22Blocks.BuildStart => "build-start",
                AutoSDKSharedebbc2ea34af24e22Blocks.DeploymentAlias => "deployment-alias",
                AutoSDKSharedebbc2ea34af24e22Blocks.DeploymentPromotion => "deployment-promotion",
                AutoSDKSharedebbc2ea34af24e22Blocks.DeploymentStart => "deployment-start",
                AutoSDKSharedebbc2ea34af24e22Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedebbc2ea34af24e22Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => AutoSDKSharedebbc2ea34af24e22Blocks.BuildStart,
                "deployment-alias" => AutoSDKSharedebbc2ea34af24e22Blocks.DeploymentAlias,
                "deployment-promotion" => AutoSDKSharedebbc2ea34af24e22Blocks.DeploymentPromotion,
                "deployment-start" => AutoSDKSharedebbc2ea34af24e22Blocks.DeploymentStart,
                "none" => AutoSDKSharedebbc2ea34af24e22Blocks.None,
                _ => null,
            };
        }
    }
}