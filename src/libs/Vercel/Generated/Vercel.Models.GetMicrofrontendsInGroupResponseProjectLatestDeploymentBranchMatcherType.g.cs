
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType
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
    public static class GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType.EndsWith => "endsWith",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType.Equals => "equals",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType.EndsWith,
                "equals" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType.Equals,
                "startsWith" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}