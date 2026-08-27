
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectLatestDeploymentBranchMatcherType
    {
        /// <summary>
        ///
        /// </summary>
        EndsWith,
        /// <summary>
        ///
        /// </summary>
        Equals,
        /// <summary>
        ///
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectLatestDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectLatestDeploymentBranchMatcherType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectLatestDeploymentBranchMatcherType.EndsWith => "endsWith",
                GetProjectsResponseVariant3ProjectLatestDeploymentBranchMatcherType.Equals => "equals",
                GetProjectsResponseVariant3ProjectLatestDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectLatestDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectsResponseVariant3ProjectLatestDeploymentBranchMatcherType.EndsWith,
                "equals" => GetProjectsResponseVariant3ProjectLatestDeploymentBranchMatcherType.Equals,
                "startsWith" => GetProjectsResponseVariant3ProjectLatestDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}