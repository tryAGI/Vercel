
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Value: deployment-alias
    /// </summary>
    public enum UpdateProjectCheckRequestBlocks
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
    public static class UpdateProjectCheckRequestBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectCheckRequestBlocks value)
        {
            return value switch
            {
                UpdateProjectCheckRequestBlocks.BuildStart => "build-start",
                UpdateProjectCheckRequestBlocks.DeploymentAlias => "deployment-alias",
                UpdateProjectCheckRequestBlocks.DeploymentPromotion => "deployment-promotion",
                UpdateProjectCheckRequestBlocks.DeploymentStart => "deployment-start",
                UpdateProjectCheckRequestBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectCheckRequestBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => UpdateProjectCheckRequestBlocks.BuildStart,
                "deployment-alias" => UpdateProjectCheckRequestBlocks.DeploymentAlias,
                "deployment-promotion" => UpdateProjectCheckRequestBlocks.DeploymentPromotion,
                "deployment-start" => UpdateProjectCheckRequestBlocks.DeploymentStart,
                "none" => UpdateProjectCheckRequestBlocks.None,
                _ => null,
            };
        }
    }
}