
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAliaDeploymentBranchMatcherType
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
    public static class GetProjectsResponseVariant2ProjectAliaDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAliaDeploymentBranchMatcherType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAliaDeploymentBranchMatcherType.EndsWith => "endsWith",
                GetProjectsResponseVariant2ProjectAliaDeploymentBranchMatcherType.Equals => "equals",
                GetProjectsResponseVariant2ProjectAliaDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAliaDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectsResponseVariant2ProjectAliaDeploymentBranchMatcherType.EndsWith,
                "equals" => GetProjectsResponseVariant2ProjectAliaDeploymentBranchMatcherType.Equals,
                "startsWith" => GetProjectsResponseVariant2ProjectAliaDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}