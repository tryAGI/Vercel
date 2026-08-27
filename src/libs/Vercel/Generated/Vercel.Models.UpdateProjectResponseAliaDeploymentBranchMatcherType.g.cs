
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UpdateProjectResponseAliaDeploymentBranchMatcherType
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
    public static class UpdateProjectResponseAliaDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAliaDeploymentBranchMatcherType value)
        {
            return value switch
            {
                UpdateProjectResponseAliaDeploymentBranchMatcherType.EndsWith => "endsWith",
                UpdateProjectResponseAliaDeploymentBranchMatcherType.Equals => "equals",
                UpdateProjectResponseAliaDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAliaDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UpdateProjectResponseAliaDeploymentBranchMatcherType.EndsWith,
                "equals" => UpdateProjectResponseAliaDeploymentBranchMatcherType.Equals,
                "startsWith" => UpdateProjectResponseAliaDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}