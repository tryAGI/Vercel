
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UpdateProjectResponseLatestDeploymentBranchMatcherType
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
    public static class UpdateProjectResponseLatestDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLatestDeploymentBranchMatcherType value)
        {
            return value switch
            {
                UpdateProjectResponseLatestDeploymentBranchMatcherType.EndsWith => "endsWith",
                UpdateProjectResponseLatestDeploymentBranchMatcherType.Equals => "equals",
                UpdateProjectResponseLatestDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLatestDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UpdateProjectResponseLatestDeploymentBranchMatcherType.EndsWith,
                "equals" => UpdateProjectResponseLatestDeploymentBranchMatcherType.Equals,
                "startsWith" => UpdateProjectResponseLatestDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}