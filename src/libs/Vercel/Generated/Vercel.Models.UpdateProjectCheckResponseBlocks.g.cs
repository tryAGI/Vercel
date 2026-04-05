
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectCheckResponseBlocks
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
    public static class UpdateProjectCheckResponseBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectCheckResponseBlocks value)
        {
            return value switch
            {
                UpdateProjectCheckResponseBlocks.BuildStart => "build-start",
                UpdateProjectCheckResponseBlocks.DeploymentAlias => "deployment-alias",
                UpdateProjectCheckResponseBlocks.DeploymentPromotion => "deployment-promotion",
                UpdateProjectCheckResponseBlocks.DeploymentStart => "deployment-start",
                UpdateProjectCheckResponseBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectCheckResponseBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => UpdateProjectCheckResponseBlocks.BuildStart,
                "deployment-alias" => UpdateProjectCheckResponseBlocks.DeploymentAlias,
                "deployment-promotion" => UpdateProjectCheckResponseBlocks.DeploymentPromotion,
                "deployment-start" => UpdateProjectCheckResponseBlocks.DeploymentStart,
                "none" => UpdateProjectCheckResponseBlocks.None,
                _ => null,
            };
        }
    }
}