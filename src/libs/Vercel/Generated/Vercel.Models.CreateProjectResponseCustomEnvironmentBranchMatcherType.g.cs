
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum CreateProjectResponseCustomEnvironmentBranchMatcherType
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
    public static class CreateProjectResponseCustomEnvironmentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseCustomEnvironmentBranchMatcherType value)
        {
            return value switch
            {
                CreateProjectResponseCustomEnvironmentBranchMatcherType.EndsWith => "endsWith",
                CreateProjectResponseCustomEnvironmentBranchMatcherType.Equals => "equals",
                CreateProjectResponseCustomEnvironmentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseCustomEnvironmentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => CreateProjectResponseCustomEnvironmentBranchMatcherType.EndsWith,
                "equals" => CreateProjectResponseCustomEnvironmentBranchMatcherType.Equals,
                "startsWith" => CreateProjectResponseCustomEnvironmentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}