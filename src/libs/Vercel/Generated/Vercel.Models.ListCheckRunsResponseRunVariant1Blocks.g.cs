
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListCheckRunsResponseRunVariant1Blocks
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
    public static class ListCheckRunsResponseRunVariant1BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant1Blocks value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant1Blocks.BuildStart => "build-start",
                ListCheckRunsResponseRunVariant1Blocks.DeploymentAlias => "deployment-alias",
                ListCheckRunsResponseRunVariant1Blocks.DeploymentPromotion => "deployment-promotion",
                ListCheckRunsResponseRunVariant1Blocks.DeploymentStart => "deployment-start",
                ListCheckRunsResponseRunVariant1Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant1Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => ListCheckRunsResponseRunVariant1Blocks.BuildStart,
                "deployment-alias" => ListCheckRunsResponseRunVariant1Blocks.DeploymentAlias,
                "deployment-promotion" => ListCheckRunsResponseRunVariant1Blocks.DeploymentPromotion,
                "deployment-start" => ListCheckRunsResponseRunVariant1Blocks.DeploymentStart,
                "none" => ListCheckRunsResponseRunVariant1Blocks.None,
                _ => null,
            };
        }
    }
}