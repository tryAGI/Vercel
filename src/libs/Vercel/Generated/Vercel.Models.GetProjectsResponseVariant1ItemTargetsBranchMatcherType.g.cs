
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectsResponseVariant1ItemTargetsBranchMatcherType
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
    public static class GetProjectsResponseVariant1ItemTargetsBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemTargetsBranchMatcherType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemTargetsBranchMatcherType.EndsWith => "endsWith",
                GetProjectsResponseVariant1ItemTargetsBranchMatcherType.Equals => "equals",
                GetProjectsResponseVariant1ItemTargetsBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemTargetsBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectsResponseVariant1ItemTargetsBranchMatcherType.EndsWith,
                "equals" => GetProjectsResponseVariant1ItemTargetsBranchMatcherType.Equals,
                "startsWith" => GetProjectsResponseVariant1ItemTargetsBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}