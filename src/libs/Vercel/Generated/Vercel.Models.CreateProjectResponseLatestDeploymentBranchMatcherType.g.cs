
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum CreateProjectResponseLatestDeploymentBranchMatcherType
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
    public static class CreateProjectResponseLatestDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLatestDeploymentBranchMatcherType value)
        {
            return value switch
            {
                CreateProjectResponseLatestDeploymentBranchMatcherType.EndsWith => "endsWith",
                CreateProjectResponseLatestDeploymentBranchMatcherType.Equals => "equals",
                CreateProjectResponseLatestDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLatestDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => CreateProjectResponseLatestDeploymentBranchMatcherType.EndsWith,
                "equals" => CreateProjectResponseLatestDeploymentBranchMatcherType.Equals,
                "startsWith" => CreateProjectResponseLatestDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}