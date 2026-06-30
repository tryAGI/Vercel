
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UpdateMicrofrontendsResponseTargetsBranchMatcherType
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
    public static class UpdateMicrofrontendsResponseTargetsBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTargetsBranchMatcherType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTargetsBranchMatcherType.EndsWith => "endsWith",
                UpdateMicrofrontendsResponseTargetsBranchMatcherType.Equals => "equals",
                UpdateMicrofrontendsResponseTargetsBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTargetsBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UpdateMicrofrontendsResponseTargetsBranchMatcherType.EndsWith,
                "equals" => UpdateMicrofrontendsResponseTargetsBranchMatcherType.Equals,
                "startsWith" => UpdateMicrofrontendsResponseTargetsBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}