
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunVariant2Blocks
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
    public static class ListCheckRunsResponseRunVariant2BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant2Blocks value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant2Blocks.BuildStart => "build-start",
                ListCheckRunsResponseRunVariant2Blocks.DeploymentAlias => "deployment-alias",
                ListCheckRunsResponseRunVariant2Blocks.DeploymentPromotion => "deployment-promotion",
                ListCheckRunsResponseRunVariant2Blocks.DeploymentStart => "deployment-start",
                ListCheckRunsResponseRunVariant2Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant2Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => ListCheckRunsResponseRunVariant2Blocks.BuildStart,
                "deployment-alias" => ListCheckRunsResponseRunVariant2Blocks.DeploymentAlias,
                "deployment-promotion" => ListCheckRunsResponseRunVariant2Blocks.DeploymentPromotion,
                "deployment-start" => ListCheckRunsResponseRunVariant2Blocks.DeploymentStart,
                "none" => ListCheckRunsResponseRunVariant2Blocks.None,
                _ => null,
            };
        }
    }
}