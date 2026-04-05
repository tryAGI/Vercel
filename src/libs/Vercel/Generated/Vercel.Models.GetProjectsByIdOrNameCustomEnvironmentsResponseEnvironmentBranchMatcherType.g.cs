
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcherType
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
    public static class GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcherType value)
        {
            return value switch
            {
                GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcherType.EndsWith => "endsWith",
                GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcherType.Equals => "equals",
                GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcherType.EndsWith,
                "equals" => GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcherType.Equals,
                "startsWith" => GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}