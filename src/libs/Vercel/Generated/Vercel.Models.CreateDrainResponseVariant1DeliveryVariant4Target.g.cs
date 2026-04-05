
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant1DeliveryVariant4Target
    {
        /// <summary>
        /// 
        /// </summary>
        VercelOtelTracesDb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainResponseVariant1DeliveryVariant4TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant1DeliveryVariant4Target value)
        {
            return value switch
            {
                CreateDrainResponseVariant1DeliveryVariant4Target.VercelOtelTracesDb => "vercel-otel-traces-db",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant1DeliveryVariant4Target? ToEnum(string value)
        {
            return value switch
            {
                "vercel-otel-traces-db" => CreateDrainResponseVariant1DeliveryVariant4Target.VercelOtelTracesDb,
                _ => null,
            };
        }
    }
}