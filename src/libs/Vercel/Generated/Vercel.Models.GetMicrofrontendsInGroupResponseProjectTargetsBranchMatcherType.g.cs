
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTargetsBranchMatcherType
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
    public static class GetMicrofrontendsInGroupResponseProjectTargetsBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTargetsBranchMatcherType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTargetsBranchMatcherType.EndsWith => "endsWith",
                GetMicrofrontendsInGroupResponseProjectTargetsBranchMatcherType.Equals => "equals",
                GetMicrofrontendsInGroupResponseProjectTargetsBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTargetsBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetMicrofrontendsInGroupResponseProjectTargetsBranchMatcherType.EndsWith,
                "equals" => GetMicrofrontendsInGroupResponseProjectTargetsBranchMatcherType.Equals,
                "startsWith" => GetMicrofrontendsInGroupResponseProjectTargetsBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}