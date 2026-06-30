
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectTargetsBranchMatcherType
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
    public static class GetProjectsResponseVariant2ProjectTargetsBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectTargetsBranchMatcherType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectTargetsBranchMatcherType.EndsWith => "endsWith",
                GetProjectsResponseVariant2ProjectTargetsBranchMatcherType.Equals => "equals",
                GetProjectsResponseVariant2ProjectTargetsBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectTargetsBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectsResponseVariant2ProjectTargetsBranchMatcherType.EndsWith,
                "equals" => GetProjectsResponseVariant2ProjectTargetsBranchMatcherType.Equals,
                "startsWith" => GetProjectsResponseVariant2ProjectTargetsBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}