
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedca611ecff4bbfd16Blocks
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
    public static class AutoSDKSharedca611ecff4bbfd16BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedca611ecff4bbfd16Blocks value)
        {
            return value switch
            {
                AutoSDKSharedca611ecff4bbfd16Blocks.BuildStart => "build-start",
                AutoSDKSharedca611ecff4bbfd16Blocks.DeploymentAlias => "deployment-alias",
                AutoSDKSharedca611ecff4bbfd16Blocks.DeploymentPromotion => "deployment-promotion",
                AutoSDKSharedca611ecff4bbfd16Blocks.DeploymentStart => "deployment-start",
                AutoSDKSharedca611ecff4bbfd16Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedca611ecff4bbfd16Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => AutoSDKSharedca611ecff4bbfd16Blocks.BuildStart,
                "deployment-alias" => AutoSDKSharedca611ecff4bbfd16Blocks.DeploymentAlias,
                "deployment-promotion" => AutoSDKSharedca611ecff4bbfd16Blocks.DeploymentPromotion,
                "deployment-start" => AutoSDKSharedca611ecff4bbfd16Blocks.DeploymentStart,
                "none" => AutoSDKSharedca611ecff4bbfd16Blocks.None,
                _ => null,
            };
        }
    }
}