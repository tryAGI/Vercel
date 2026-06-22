
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant1Type
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
    public static class CreateDeploymentResponseServiceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant1Type value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant1Type.Cron => "cron",
                CreateDeploymentResponseServiceVariant1Type.Job => "job",
                CreateDeploymentResponseServiceVariant1Type.Web => "web",
                CreateDeploymentResponseServiceVariant1Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => CreateDeploymentResponseServiceVariant1Type.Cron,
                "job" => CreateDeploymentResponseServiceVariant1Type.Job,
                "web" => CreateDeploymentResponseServiceVariant1Type.Web,
                "worker" => CreateDeploymentResponseServiceVariant1Type.Worker,
                _ => null,
            };
        }
    }
}