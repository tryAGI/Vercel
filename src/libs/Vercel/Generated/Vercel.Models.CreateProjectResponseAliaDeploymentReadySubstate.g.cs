
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseAliaDeploymentReadySubstate
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
    public static class CreateProjectResponseAliaDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAliaDeploymentReadySubstate value)
        {
            return value switch
            {
                CreateProjectResponseAliaDeploymentReadySubstate.Promoted => "PROMOTED",
                CreateProjectResponseAliaDeploymentReadySubstate.Rolling => "ROLLING",
                CreateProjectResponseAliaDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAliaDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => CreateProjectResponseAliaDeploymentReadySubstate.Promoted,
                "ROLLING" => CreateProjectResponseAliaDeploymentReadySubstate.Rolling,
                "STAGED" => CreateProjectResponseAliaDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}