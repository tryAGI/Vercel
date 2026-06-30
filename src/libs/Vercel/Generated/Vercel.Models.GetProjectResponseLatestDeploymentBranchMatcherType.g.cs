
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectResponseLatestDeploymentBranchMatcherType
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
    public static class GetProjectResponseLatestDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLatestDeploymentBranchMatcherType value)
        {
            return value switch
            {
                GetProjectResponseLatestDeploymentBranchMatcherType.EndsWith => "endsWith",
                GetProjectResponseLatestDeploymentBranchMatcherType.Equals => "equals",
                GetProjectResponseLatestDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLatestDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectResponseLatestDeploymentBranchMatcherType.EndsWith,
                "equals" => GetProjectResponseLatestDeploymentBranchMatcherType.Equals,
                "startsWith" => GetProjectResponseLatestDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}