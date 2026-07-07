
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the manifest is a multi-platform image index, a single-platform image manifest or an attestation.
    /// </summary>
    public enum VcrTagKind
    {
        /// <summary>
        /// 
        /// </summary>
        Attestation,
        /// <summary>
        /// 
        /// </summary>
        Index,
        /// <summary>
        /// 
        /// </summary>
        Manifest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VcrTagKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrTagKind value)
        {
            return value switch
            {
                VcrTagKind.Attestation => "attestation",
                VcrTagKind.Index => "index",
                VcrTagKind.Manifest => "manifest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrTagKind? ToEnum(string value)
        {
            return value switch
            {
                "attestation" => VcrTagKind.Attestation,
                "index" => VcrTagKind.Index,
                "manifest" => VcrTagKind.Manifest,
                _ => null,
            };
        }
    }
}