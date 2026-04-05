
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UpdateProjectResponseCustomEnvironmentBranchMatcherType
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
    public static class UpdateProjectResponseCustomEnvironmentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseCustomEnvironmentBranchMatcherType value)
        {
            return value switch
            {
                UpdateProjectResponseCustomEnvironmentBranchMatcherType.EndsWith => "endsWith",
                UpdateProjectResponseCustomEnvironmentBranchMatcherType.Equals => "equals",
                UpdateProjectResponseCustomEnvironmentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseCustomEnvironmentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UpdateProjectResponseCustomEnvironmentBranchMatcherType.EndsWith,
                "equals" => UpdateProjectResponseCustomEnvironmentBranchMatcherType.Equals,
                "startsWith" => UpdateProjectResponseCustomEnvironmentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}