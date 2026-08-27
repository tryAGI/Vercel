
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UpdateProjectResponseTargetsBranchMatcherType
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
    public static class UpdateProjectResponseTargetsBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTargetsBranchMatcherType value)
        {
            return value switch
            {
                UpdateProjectResponseTargetsBranchMatcherType.EndsWith => "endsWith",
                UpdateProjectResponseTargetsBranchMatcherType.Equals => "equals",
                UpdateProjectResponseTargetsBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTargetsBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UpdateProjectResponseTargetsBranchMatcherType.EndsWith,
                "equals" => UpdateProjectResponseTargetsBranchMatcherType.Equals,
                "startsWith" => UpdateProjectResponseTargetsBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}