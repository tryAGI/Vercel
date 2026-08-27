
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetProjectResponseTargetsBranchMatcherType
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
    public static class GetProjectResponseTargetsBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTargetsBranchMatcherType value)
        {
            return value switch
            {
                GetProjectResponseTargetsBranchMatcherType.EndsWith => "endsWith",
                GetProjectResponseTargetsBranchMatcherType.Equals => "equals",
                GetProjectResponseTargetsBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTargetsBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetProjectResponseTargetsBranchMatcherType.EndsWith,
                "equals" => GetProjectResponseTargetsBranchMatcherType.Equals,
                "startsWith" => GetProjectResponseTargetsBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}