
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAliaDeploymentReadySubstate
    {
        /// <summary>
        /// 
        /// </summary>
        Promoted,
        /// <summary>
        /// 
        /// </summary>
        Rolling,
        /// <summary>
        /// 
        /// </summary>
        Staged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemAliaDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAliaDeploymentReadySubstate value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAliaDeploymentReadySubstate.Promoted => "PROMOTED",
                GetProjectsResponseVariant1ItemAliaDeploymentReadySubstate.Rolling => "ROLLING",
                GetProjectsResponseVariant1ItemAliaDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAliaDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectsResponseVariant1ItemAliaDeploymentReadySubstate.Promoted,
                "ROLLING" => GetProjectsResponseVariant1ItemAliaDeploymentReadySubstate.Rolling,
                "STAGED" => GetProjectsResponseVariant1ItemAliaDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}