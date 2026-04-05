
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseSourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentCheckRunResponseSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseSourceVariant2Kind value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseSourceVariant2Kind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => CreateDeploymentCheckRunResponseSourceVariant2Kind.Webhook,
                _ => null,
            };
        }
    }
}