
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSandboxesByNameForkV2RequestFailoverRegion
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
    public static class CreateSandboxesByNameForkV2RequestFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesByNameForkV2RequestFailoverRegion value)
        {
            return value switch
            {
                CreateSandboxesByNameForkV2RequestFailoverRegion.Cdg1 => "cdg1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Cle1 => "cle1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Iad1 => "iad1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesByNameForkV2RequestFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Cdg1,
                "cle1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Cle1,
                "iad1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Iad1,
                "sfo1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}