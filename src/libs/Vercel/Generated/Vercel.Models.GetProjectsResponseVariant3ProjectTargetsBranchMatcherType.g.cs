
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTargetsBranchMatcherType
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
    public static class GetProjectsResponseVariant3ProjectTargetsBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTargetsBranchMatcherType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTargetsBranchMatcherType.EndsWith => "endsWith",
                GetProjectsResponseVariant3ProjectTargetsBranchMatcherType.Equals => "equals",
                GetProjectsResponseVariant3ProjectTargetsBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTargetsBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectsResponseVariant3ProjectTargetsBranchMatcherType.EndsWith,
                "equals" => GetProjectsResponseVariant3ProjectTargetsBranchMatcherType.Equals,
                "startsWith" => GetProjectsResponseVariant3ProjectTargetsBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}