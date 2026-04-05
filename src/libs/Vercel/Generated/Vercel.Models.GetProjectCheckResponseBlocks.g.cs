
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectCheckResponseBlocks
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
    public static class GetProjectCheckResponseBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectCheckResponseBlocks value)
        {
            return value switch
            {
                GetProjectCheckResponseBlocks.BuildStart => "build-start",
                GetProjectCheckResponseBlocks.DeploymentAlias => "deployment-alias",
                GetProjectCheckResponseBlocks.DeploymentPromotion => "deployment-promotion",
                GetProjectCheckResponseBlocks.DeploymentStart => "deployment-start",
                GetProjectCheckResponseBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectCheckResponseBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => GetProjectCheckResponseBlocks.BuildStart,
                "deployment-alias" => GetProjectCheckResponseBlocks.DeploymentAlias,
                "deployment-promotion" => GetProjectCheckResponseBlocks.DeploymentPromotion,
                "deployment-start" => GetProjectCheckResponseBlocks.DeploymentStart,
                "none" => GetProjectCheckResponseBlocks.None,
                _ => null,
            };
        }
    }
}