
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Direction to order grouped results by. Defaults to desc.
    /// </summary>
    public enum CreateObservabilityQueryRequestOrderDirection
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObservabilityQueryRequestOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityQueryRequestOrderDirection value)
        {
            return value switch
            {
                CreateObservabilityQueryRequestOrderDirection.Asc => "asc",
                CreateObservabilityQueryRequestOrderDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityQueryRequestOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => CreateObservabilityQueryRequestOrderDirection.Asc,
                "desc" => CreateObservabilityQueryRequestOrderDirection.Desc,
                _ => null,
            };
        }
    }
}