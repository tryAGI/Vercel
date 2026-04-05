
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectCheckResponseBlocks
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
    public static class CreateProjectCheckResponseBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectCheckResponseBlocks value)
        {
            return value switch
            {
                CreateProjectCheckResponseBlocks.BuildStart => "build-start",
                CreateProjectCheckResponseBlocks.DeploymentAlias => "deployment-alias",
                CreateProjectCheckResponseBlocks.DeploymentPromotion => "deployment-promotion",
                CreateProjectCheckResponseBlocks.DeploymentStart => "deployment-start",
                CreateProjectCheckResponseBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectCheckResponseBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => CreateProjectCheckResponseBlocks.BuildStart,
                "deployment-alias" => CreateProjectCheckResponseBlocks.DeploymentAlias,
                "deployment-promotion" => CreateProjectCheckResponseBlocks.DeploymentPromotion,
                "deployment-start" => CreateProjectCheckResponseBlocks.DeploymentStart,
                "none" => CreateProjectCheckResponseBlocks.None,
                _ => null,
            };
        }
    }
}