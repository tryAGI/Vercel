
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filter by scope type
    /// </summary>
    public enum GetProjectBoxesScopeType
    {
        /// <summary>
        ///
        /// </summary>
        Branch,
        /// <summary>
        ///
        /// </summary>
        CustomEnvironment,
        /// <summary>
        ///
        /// </summary>
        Target,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectBoxesScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectBoxesScopeType value)
        {
            return value switch
            {
                GetProjectBoxesScopeType.Branch => "branch",
                GetProjectBoxesScopeType.CustomEnvironment => "customEnvironment",
                GetProjectBoxesScopeType.Target => "target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectBoxesScopeType? ToEnum(string value)
        {
            return value switch
            {
                "branch" => GetProjectBoxesScopeType.Branch,
                "customEnvironment" => GetProjectBoxesScopeType.CustomEnvironment,
                "target" => GetProjectBoxesScopeType.Target,
                _ => null,
            };
        }
    }
}