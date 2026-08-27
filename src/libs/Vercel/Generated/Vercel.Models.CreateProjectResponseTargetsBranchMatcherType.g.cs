
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum CreateProjectResponseTargetsBranchMatcherType
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
    public static class CreateProjectResponseTargetsBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTargetsBranchMatcherType value)
        {
            return value switch
            {
                CreateProjectResponseTargetsBranchMatcherType.EndsWith => "endsWith",
                CreateProjectResponseTargetsBranchMatcherType.Equals => "equals",
                CreateProjectResponseTargetsBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTargetsBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => CreateProjectResponseTargetsBranchMatcherType.EndsWith,
                "equals" => CreateProjectResponseTargetsBranchMatcherType.Equals,
                "startsWith" => CreateProjectResponseTargetsBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}