
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared87d88207314b07b3Blocks
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
    public static class AutoSDKShared87d88207314b07b3BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d88207314b07b3Blocks value)
        {
            return value switch
            {
                AutoSDKShared87d88207314b07b3Blocks.BuildStart => "build-start",
                AutoSDKShared87d88207314b07b3Blocks.DeploymentAlias => "deployment-alias",
                AutoSDKShared87d88207314b07b3Blocks.DeploymentPromotion => "deployment-promotion",
                AutoSDKShared87d88207314b07b3Blocks.DeploymentStart => "deployment-start",
                AutoSDKShared87d88207314b07b3Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d88207314b07b3Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => AutoSDKShared87d88207314b07b3Blocks.BuildStart,
                "deployment-alias" => AutoSDKShared87d88207314b07b3Blocks.DeploymentAlias,
                "deployment-promotion" => AutoSDKShared87d88207314b07b3Blocks.DeploymentPromotion,
                "deployment-start" => AutoSDKShared87d88207314b07b3Blocks.DeploymentStart,
                "none" => AutoSDKShared87d88207314b07b3Blocks.None,
                _ => null,
            };
        }
    }
}