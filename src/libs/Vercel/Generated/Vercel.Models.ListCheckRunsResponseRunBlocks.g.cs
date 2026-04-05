
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunBlocks
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
    public static class ListCheckRunsResponseRunBlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunBlocks value)
        {
            return value switch
            {
                ListCheckRunsResponseRunBlocks.BuildStart => "build-start",
                ListCheckRunsResponseRunBlocks.DeploymentAlias => "deployment-alias",
                ListCheckRunsResponseRunBlocks.DeploymentPromotion => "deployment-promotion",
                ListCheckRunsResponseRunBlocks.DeploymentStart => "deployment-start",
                ListCheckRunsResponseRunBlocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunBlocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => ListCheckRunsResponseRunBlocks.BuildStart,
                "deployment-alias" => ListCheckRunsResponseRunBlocks.DeploymentAlias,
                "deployment-promotion" => ListCheckRunsResponseRunBlocks.DeploymentPromotion,
                "deployment-start" => ListCheckRunsResponseRunBlocks.DeploymentStart,
                "none" => ListCheckRunsResponseRunBlocks.None,
                _ => null,
            };
        }
    }
}