
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UpdateMicrofrontendsResponseLatestDeploymentBranchMatcherType
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
    public static class UpdateMicrofrontendsResponseLatestDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseLatestDeploymentBranchMatcherType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseLatestDeploymentBranchMatcherType.EndsWith => "endsWith",
                UpdateMicrofrontendsResponseLatestDeploymentBranchMatcherType.Equals => "equals",
                UpdateMicrofrontendsResponseLatestDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseLatestDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UpdateMicrofrontendsResponseLatestDeploymentBranchMatcherType.EndsWith,
                "equals" => UpdateMicrofrontendsResponseLatestDeploymentBranchMatcherType.Equals,
                "startsWith" => UpdateMicrofrontendsResponseLatestDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}