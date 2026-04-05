
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Forces a new deployment even if there is a previous similar deployment
    /// </summary>
    public enum CreateDeploymentForceNew
    {
        /// <summary>
        /// 
        /// </summary>
        x0,
        /// <summary>
        /// 
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentForceNewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentForceNew value)
        {
            return value switch
            {
                CreateDeploymentForceNew.x0 => "0",
                CreateDeploymentForceNew.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentForceNew? ToEnum(string value)
        {
            return value switch
            {
                "0" => CreateDeploymentForceNew.x0,
                "1" => CreateDeploymentForceNew.x1,
                _ => null,
            };
        }
    }
}