
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectResponseAliaDeploymentBranchMatcherType
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
    public static class GetProjectResponseAliaDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAliaDeploymentBranchMatcherType value)
        {
            return value switch
            {
                GetProjectResponseAliaDeploymentBranchMatcherType.EndsWith => "endsWith",
                GetProjectResponseAliaDeploymentBranchMatcherType.Equals => "equals",
                GetProjectResponseAliaDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAliaDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectResponseAliaDeploymentBranchMatcherType.EndsWith,
                "equals" => GetProjectResponseAliaDeploymentBranchMatcherType.Equals,
                "startsWith" => GetProjectResponseAliaDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}