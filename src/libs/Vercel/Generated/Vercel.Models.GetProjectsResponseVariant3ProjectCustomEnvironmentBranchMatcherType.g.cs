
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectCustomEnvironmentBranchMatcherType
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
    public static class GetProjectsResponseVariant3ProjectCustomEnvironmentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectCustomEnvironmentBranchMatcherType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectCustomEnvironmentBranchMatcherType.EndsWith => "endsWith",
                GetProjectsResponseVariant3ProjectCustomEnvironmentBranchMatcherType.Equals => "equals",
                GetProjectsResponseVariant3ProjectCustomEnvironmentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectCustomEnvironmentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectsResponseVariant3ProjectCustomEnvironmentBranchMatcherType.EndsWith,
                "equals" => GetProjectsResponseVariant3ProjectCustomEnvironmentBranchMatcherType.Equals,
                "startsWith" => GetProjectsResponseVariant3ProjectCustomEnvironmentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}