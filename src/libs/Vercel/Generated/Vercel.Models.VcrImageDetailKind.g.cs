
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the manifest is a multi-platform image index, a single-platform image manifest or an attestation.
    /// </summary>
    public enum VcrImageDetailKind
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
    public static class VcrImageDetailKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageDetailKind value)
        {
            return value switch
            {
                VcrImageDetailKind.Attestation => "attestation",
                VcrImageDetailKind.Index => "index",
                VcrImageDetailKind.Manifest => "manifest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageDetailKind? ToEnum(string value)
        {
            return value switch
            {
                "attestation" => VcrImageDetailKind.Attestation,
                "index" => VcrImageDetailKind.Index,
                "manifest" => VcrImageDetailKind.Manifest,
                _ => null,
            };
        }
    }
}