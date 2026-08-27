
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant1Type
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
    public static class GetDeploymentResponseVariant2ServiceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant1Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant1Type.Cron => "cron",
                GetDeploymentResponseVariant2ServiceVariant1Type.Job => "job",
                GetDeploymentResponseVariant2ServiceVariant1Type.Web => "web",
                GetDeploymentResponseVariant2ServiceVariant1Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => GetDeploymentResponseVariant2ServiceVariant1Type.Cron,
                "job" => GetDeploymentResponseVariant2ServiceVariant1Type.Job,
                "web" => GetDeploymentResponseVariant2ServiceVariant1Type.Web,
                "worker" => GetDeploymentResponseVariant2ServiceVariant1Type.Worker,
                _ => null,
            };
        }
    }
}