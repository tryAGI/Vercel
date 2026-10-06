
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429cd580a486c43eBlocks
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
    public static class AutoSDKShared429cd580a486c43eBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429cd580a486c43eBlocks value)
        {
            return value switch
            {
                AutoSDKShared429cd580a486c43eBlocks.BuildStart => "build-start",
                AutoSDKShared429cd580a486c43eBlocks.DeploymentAlias => "deployment-alias",
                AutoSDKShared429cd580a486c43eBlocks.DeploymentPromotion => "deployment-promotion",
                AutoSDKShared429cd580a486c43eBlocks.DeploymentStart => "deployment-start",
                AutoSDKShared429cd580a486c43eBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429cd580a486c43eBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => AutoSDKShared429cd580a486c43eBlocks.BuildStart,
                "deployment-alias" => AutoSDKShared429cd580a486c43eBlocks.DeploymentAlias,
                "deployment-promotion" => AutoSDKShared429cd580a486c43eBlocks.DeploymentPromotion,
                "deployment-start" => AutoSDKShared429cd580a486c43eBlocks.DeploymentStart,
                "none" => AutoSDKShared429cd580a486c43eBlocks.None,
                _ => null,
            };
        }
    }
}