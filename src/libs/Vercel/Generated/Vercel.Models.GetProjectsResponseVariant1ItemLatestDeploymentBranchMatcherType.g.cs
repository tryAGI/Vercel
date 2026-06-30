
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType
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
    public static class GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType.EndsWith => "endsWith",
                GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType.Equals => "equals",
                GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType.EndsWith,
                "equals" => GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType.Equals,
                "startsWith" => GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}