
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Cron,
        /// <summary>
        /// 
        /// </summary>
        Job,
        /// <summary>
        /// 
        /// </summary>
        Web,
        /// <summary>
        /// 
        /// </summary>
        Worker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ServiceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant1Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant1Type.Cron => "cron",
                GetDeploymentResponseVariant1ServiceVariant1Type.Job => "job",
                GetDeploymentResponseVariant1ServiceVariant1Type.Web => "web",
                GetDeploymentResponseVariant1ServiceVariant1Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => GetDeploymentResponseVariant1ServiceVariant1Type.Cron,
                "job" => GetDeploymentResponseVariant1ServiceVariant1Type.Job,
                "web" => GetDeploymentResponseVariant1ServiceVariant1Type.Web,
                "worker" => GetDeploymentResponseVariant1ServiceVariant1Type.Worker,
                _ => null,
            };
        }
    }
}