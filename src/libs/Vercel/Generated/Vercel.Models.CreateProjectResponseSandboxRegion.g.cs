
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseSandboxRegion
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
    public static class CreateProjectResponseSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSandboxRegion value)
        {
            return value switch
            {
                CreateProjectResponseSandboxRegion.Cdg1 => "cdg1",
                CreateProjectResponseSandboxRegion.Cle1 => "cle1",
                CreateProjectResponseSandboxRegion.Iad1 => "iad1",
                CreateProjectResponseSandboxRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => CreateProjectResponseSandboxRegion.Cdg1,
                "cle1" => CreateProjectResponseSandboxRegion.Cle1,
                "iad1" => CreateProjectResponseSandboxRegion.Iad1,
                "sfo1" => CreateProjectResponseSandboxRegion.Sfo1,
                _ => null,
            };
        }
    }
}