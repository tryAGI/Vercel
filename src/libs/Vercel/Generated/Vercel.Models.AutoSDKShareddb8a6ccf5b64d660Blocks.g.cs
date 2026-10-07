
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddb8a6ccf5b64d660Blocks
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
    public static class AutoSDKShareddb8a6ccf5b64d660BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddb8a6ccf5b64d660Blocks value)
        {
            return value switch
            {
                AutoSDKShareddb8a6ccf5b64d660Blocks.BuildStart => "build-start",
                AutoSDKShareddb8a6ccf5b64d660Blocks.DeploymentAlias => "deployment-alias",
                AutoSDKShareddb8a6ccf5b64d660Blocks.DeploymentPromotion => "deployment-promotion",
                AutoSDKShareddb8a6ccf5b64d660Blocks.DeploymentStart => "deployment-start",
                AutoSDKShareddb8a6ccf5b64d660Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddb8a6ccf5b64d660Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => AutoSDKShareddb8a6ccf5b64d660Blocks.BuildStart,
                "deployment-alias" => AutoSDKShareddb8a6ccf5b64d660Blocks.DeploymentAlias,
                "deployment-promotion" => AutoSDKShareddb8a6ccf5b64d660Blocks.DeploymentPromotion,
                "deployment-start" => AutoSDKShareddb8a6ccf5b64d660Blocks.DeploymentStart,
                "none" => AutoSDKShareddb8a6ccf5b64d660Blocks.None,
                _ => null,
            };
        }
    }
}