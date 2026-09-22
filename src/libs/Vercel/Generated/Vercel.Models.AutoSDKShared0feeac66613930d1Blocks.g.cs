
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0feeac66613930d1Blocks
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
    public static class AutoSDKShared0feeac66613930d1BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0feeac66613930d1Blocks value)
        {
            return value switch
            {
                AutoSDKShared0feeac66613930d1Blocks.BuildStart => "build-start",
                AutoSDKShared0feeac66613930d1Blocks.DeploymentAlias => "deployment-alias",
                AutoSDKShared0feeac66613930d1Blocks.DeploymentPromotion => "deployment-promotion",
                AutoSDKShared0feeac66613930d1Blocks.DeploymentStart => "deployment-start",
                AutoSDKShared0feeac66613930d1Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0feeac66613930d1Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => AutoSDKShared0feeac66613930d1Blocks.BuildStart,
                "deployment-alias" => AutoSDKShared0feeac66613930d1Blocks.DeploymentAlias,
                "deployment-promotion" => AutoSDKShared0feeac66613930d1Blocks.DeploymentPromotion,
                "deployment-start" => AutoSDKShared0feeac66613930d1Blocks.DeploymentStart,
                "none" => AutoSDKShared0feeac66613930d1Blocks.None,
                _ => null,
            };
        }
    }
}