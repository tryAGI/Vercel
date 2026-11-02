
#nullable enable

namespace Vercel
{
    /// <summary>
    /// List connections where this project is the source (default) or the consumer
    /// </summary>
    public enum GetFlagsProjectConnectionsRole
    {
        /// <summary>
        ///
        /// </summary>
        Consumer,
        /// <summary>
        ///
        /// </summary>
        Source,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFlagsProjectConnectionsRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFlagsProjectConnectionsRole value)
        {
            return value switch
            {
                GetFlagsProjectConnectionsRole.Consumer => "consumer",
                GetFlagsProjectConnectionsRole.Source => "source",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFlagsProjectConnectionsRole? ToEnum(string value)
        {
            return value switch
            {
                "consumer" => GetFlagsProjectConnectionsRole.Consumer,
                "source" => GetFlagsProjectConnectionsRole.Source,
                _ => null,
            };
        }
    }
}