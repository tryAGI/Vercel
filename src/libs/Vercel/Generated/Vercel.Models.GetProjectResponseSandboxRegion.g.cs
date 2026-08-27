
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseSandboxRegion
    {
        /// <summary>
        ///
        /// </summary>
        Cdg1,
        /// <summary>
        ///
        /// </summary>
        Cle1,
        /// <summary>
        ///
        /// </summary>
        Iad1,
        /// <summary>
        ///
        /// </summary>
        Sfo1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSandboxRegion value)
        {
            return value switch
            {
                GetProjectResponseSandboxRegion.Cdg1 => "cdg1",
                GetProjectResponseSandboxRegion.Cle1 => "cle1",
                GetProjectResponseSandboxRegion.Iad1 => "iad1",
                GetProjectResponseSandboxRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => GetProjectResponseSandboxRegion.Cdg1,
                "cle1" => GetProjectResponseSandboxRegion.Cle1,
                "iad1" => GetProjectResponseSandboxRegion.Iad1,
                "sfo1" => GetProjectResponseSandboxRegion.Sfo1,
                _ => null,
            };
        }
    }
}