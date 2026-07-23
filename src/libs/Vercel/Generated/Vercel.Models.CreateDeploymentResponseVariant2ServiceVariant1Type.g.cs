
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant1Type
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
    public static class CreateDeploymentResponseVariant2ServiceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant1Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant1Type.Cron => "cron",
                CreateDeploymentResponseVariant2ServiceVariant1Type.Job => "job",
                CreateDeploymentResponseVariant2ServiceVariant1Type.Web => "web",
                CreateDeploymentResponseVariant2ServiceVariant1Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => CreateDeploymentResponseVariant2ServiceVariant1Type.Cron,
                "job" => CreateDeploymentResponseVariant2ServiceVariant1Type.Job,
                "web" => CreateDeploymentResponseVariant2ServiceVariant1Type.Web,
                "worker" => CreateDeploymentResponseVariant2ServiceVariant1Type.Worker,
                _ => null,
            };
        }
    }
}