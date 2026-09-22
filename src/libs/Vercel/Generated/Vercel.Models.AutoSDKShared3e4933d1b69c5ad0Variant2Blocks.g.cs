
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3e4933d1b69c5ad0Variant2Blocks
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
    public static class AutoSDKShared3e4933d1b69c5ad0Variant2BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3e4933d1b69c5ad0Variant2Blocks value)
        {
            return value switch
            {
                AutoSDKShared3e4933d1b69c5ad0Variant2Blocks.BuildStart => "build-start",
                AutoSDKShared3e4933d1b69c5ad0Variant2Blocks.DeploymentAlias => "deployment-alias",
                AutoSDKShared3e4933d1b69c5ad0Variant2Blocks.DeploymentPromotion => "deployment-promotion",
                AutoSDKShared3e4933d1b69c5ad0Variant2Blocks.DeploymentStart => "deployment-start",
                AutoSDKShared3e4933d1b69c5ad0Variant2Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3e4933d1b69c5ad0Variant2Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => AutoSDKShared3e4933d1b69c5ad0Variant2Blocks.BuildStart,
                "deployment-alias" => AutoSDKShared3e4933d1b69c5ad0Variant2Blocks.DeploymentAlias,
                "deployment-promotion" => AutoSDKShared3e4933d1b69c5ad0Variant2Blocks.DeploymentPromotion,
                "deployment-start" => AutoSDKShared3e4933d1b69c5ad0Variant2Blocks.DeploymentStart,
                "none" => AutoSDKShared3e4933d1b69c5ad0Variant2Blocks.None,
                _ => null,
            };
        }
    }
}