
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Value: deployment-alias
    /// </summary>
    public enum CreateProjectCheckRequestBlocks
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
    public static class CreateProjectCheckRequestBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectCheckRequestBlocks value)
        {
            return value switch
            {
                CreateProjectCheckRequestBlocks.BuildStart => "build-start",
                CreateProjectCheckRequestBlocks.DeploymentAlias => "deployment-alias",
                CreateProjectCheckRequestBlocks.DeploymentPromotion => "deployment-promotion",
                CreateProjectCheckRequestBlocks.DeploymentStart => "deployment-start",
                CreateProjectCheckRequestBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectCheckRequestBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => CreateProjectCheckRequestBlocks.BuildStart,
                "deployment-alias" => CreateProjectCheckRequestBlocks.DeploymentAlias,
                "deployment-promotion" => CreateProjectCheckRequestBlocks.DeploymentPromotion,
                "deployment-start" => CreateProjectCheckRequestBlocks.DeploymentStart,
                "none" => CreateProjectCheckRequestBlocks.None,
                _ => null,
            };
        }
    }
}