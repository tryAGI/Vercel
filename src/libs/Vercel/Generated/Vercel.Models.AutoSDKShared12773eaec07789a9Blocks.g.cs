
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared12773eaec07789a9Blocks
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
    public static class AutoSDKShared12773eaec07789a9BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared12773eaec07789a9Blocks value)
        {
            return value switch
            {
                AutoSDKShared12773eaec07789a9Blocks.BuildStart => "build-start",
                AutoSDKShared12773eaec07789a9Blocks.DeploymentAlias => "deployment-alias",
                AutoSDKShared12773eaec07789a9Blocks.DeploymentPromotion => "deployment-promotion",
                AutoSDKShared12773eaec07789a9Blocks.DeploymentStart => "deployment-start",
                AutoSDKShared12773eaec07789a9Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared12773eaec07789a9Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => AutoSDKShared12773eaec07789a9Blocks.BuildStart,
                "deployment-alias" => AutoSDKShared12773eaec07789a9Blocks.DeploymentAlias,
                "deployment-promotion" => AutoSDKShared12773eaec07789a9Blocks.DeploymentPromotion,
                "deployment-start" => AutoSDKShared12773eaec07789a9Blocks.DeploymentStart,
                "none" => AutoSDKShared12773eaec07789a9Blocks.None,
                _ => null,
            };
        }
    }
}