
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAliaDeploymentBranchMatcherType
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
    public static class GetProjectsResponseVariant3ProjectAliaDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAliaDeploymentBranchMatcherType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAliaDeploymentBranchMatcherType.EndsWith => "endsWith",
                GetProjectsResponseVariant3ProjectAliaDeploymentBranchMatcherType.Equals => "equals",
                GetProjectsResponseVariant3ProjectAliaDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAliaDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectsResponseVariant3ProjectAliaDeploymentBranchMatcherType.EndsWith,
                "equals" => GetProjectsResponseVariant3ProjectAliaDeploymentBranchMatcherType.Equals,
                "startsWith" => GetProjectsResponseVariant3ProjectAliaDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}