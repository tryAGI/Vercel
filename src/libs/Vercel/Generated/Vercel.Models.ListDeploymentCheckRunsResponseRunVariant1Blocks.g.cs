
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant1Blocks
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
    public static class ListDeploymentCheckRunsResponseRunVariant1BlocksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant1Blocks value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant1Blocks.BuildStart => "build-start",
                ListDeploymentCheckRunsResponseRunVariant1Blocks.DeploymentAlias => "deployment-alias",
                ListDeploymentCheckRunsResponseRunVariant1Blocks.DeploymentPromotion => "deployment-promotion",
                ListDeploymentCheckRunsResponseRunVariant1Blocks.DeploymentStart => "deployment-start",
                ListDeploymentCheckRunsResponseRunVariant1Blocks.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant1Blocks? ToEnum(string value)
        {
            return value switch
            {
                "build-start" => ListDeploymentCheckRunsResponseRunVariant1Blocks.BuildStart,
                "deployment-alias" => ListDeploymentCheckRunsResponseRunVariant1Blocks.DeploymentAlias,
                "deployment-promotion" => ListDeploymentCheckRunsResponseRunVariant1Blocks.DeploymentPromotion,
                "deployment-start" => ListDeploymentCheckRunsResponseRunVariant1Blocks.DeploymentStart,
                "none" => ListDeploymentCheckRunsResponseRunVariant1Blocks.None,
                _ => null,
            };
        }
    }
}