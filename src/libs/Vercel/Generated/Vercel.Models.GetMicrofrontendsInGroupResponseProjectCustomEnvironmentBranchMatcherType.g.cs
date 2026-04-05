
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectCustomEnvironmentBranchMatcherType
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
    public static class GetMicrofrontendsInGroupResponseProjectCustomEnvironmentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectCustomEnvironmentBranchMatcherType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectCustomEnvironmentBranchMatcherType.EndsWith => "endsWith",
                GetMicrofrontendsInGroupResponseProjectCustomEnvironmentBranchMatcherType.Equals => "equals",
                GetMicrofrontendsInGroupResponseProjectCustomEnvironmentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectCustomEnvironmentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetMicrofrontendsInGroupResponseProjectCustomEnvironmentBranchMatcherType.EndsWith,
                "equals" => GetMicrofrontendsInGroupResponseProjectCustomEnvironmentBranchMatcherType.Equals,
                "startsWith" => GetMicrofrontendsInGroupResponseProjectCustomEnvironmentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}