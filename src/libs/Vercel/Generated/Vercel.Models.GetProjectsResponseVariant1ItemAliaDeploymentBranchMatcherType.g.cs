
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAliaDeploymentBranchMatcherType
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
    public static class GetProjectsResponseVariant1ItemAliaDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAliaDeploymentBranchMatcherType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAliaDeploymentBranchMatcherType.EndsWith => "endsWith",
                GetProjectsResponseVariant1ItemAliaDeploymentBranchMatcherType.Equals => "equals",
                GetProjectsResponseVariant1ItemAliaDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAliaDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectsResponseVariant1ItemAliaDeploymentBranchMatcherType.EndsWith,
                "equals" => GetProjectsResponseVariant1ItemAliaDeploymentBranchMatcherType.Equals,
                "startsWith" => GetProjectsResponseVariant1ItemAliaDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}