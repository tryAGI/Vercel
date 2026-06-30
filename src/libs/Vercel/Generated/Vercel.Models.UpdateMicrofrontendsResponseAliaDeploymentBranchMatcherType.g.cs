
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UpdateMicrofrontendsResponseAliaDeploymentBranchMatcherType
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
    public static class UpdateMicrofrontendsResponseAliaDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAliaDeploymentBranchMatcherType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAliaDeploymentBranchMatcherType.EndsWith => "endsWith",
                UpdateMicrofrontendsResponseAliaDeploymentBranchMatcherType.Equals => "equals",
                UpdateMicrofrontendsResponseAliaDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAliaDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UpdateMicrofrontendsResponseAliaDeploymentBranchMatcherType.EndsWith,
                "equals" => UpdateMicrofrontendsResponseAliaDeploymentBranchMatcherType.Equals,
                "startsWith" => UpdateMicrofrontendsResponseAliaDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}