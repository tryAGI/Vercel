
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5455d199d07ea329Blocks
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
    public static class AutoSDKShared5455d199d07ea329BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5455d199d07ea329Blocks value)
        {
            return value switch
            {
                AutoSDKShared5455d199d07ea329Blocks.BuildStart => "build-start",
                AutoSDKShared5455d199d07ea329Blocks.DeploymentAlias => "deployment-alias",
                AutoSDKShared5455d199d07ea329Blocks.DeploymentPromotion => "deployment-promotion",
                AutoSDKShared5455d199d07ea329Blocks.DeploymentStart => "deployment-start",
                AutoSDKShared5455d199d07ea329Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5455d199d07ea329Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => AutoSDKShared5455d199d07ea329Blocks.BuildStart,
                "deployment-alias" => AutoSDKShared5455d199d07ea329Blocks.DeploymentAlias,
                "deployment-promotion" => AutoSDKShared5455d199d07ea329Blocks.DeploymentPromotion,
                "deployment-start" => AutoSDKShared5455d199d07ea329Blocks.DeploymentStart,
                "none" => AutoSDKShared5455d199d07ea329Blocks.None,
                _ => null,
            };
        }
    }
}