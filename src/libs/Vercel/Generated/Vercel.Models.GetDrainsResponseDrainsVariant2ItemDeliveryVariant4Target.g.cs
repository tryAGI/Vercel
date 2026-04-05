
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Target
    {
        /// <summary>
        /// 
        /// </summary>
        VercelOtelTracesDb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant2ItemDeliveryVariant4TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Target value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Target.VercelOtelTracesDb => "vercel-otel-traces-db",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Target? ToEnum(string value)
        {
            return value switch
            {
                "vercel-otel-traces-db" => GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Target.VercelOtelTracesDb,
                _ => null,
            };
        }
    }
}