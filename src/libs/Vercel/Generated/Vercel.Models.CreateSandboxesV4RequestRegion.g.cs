
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Vercel region in which to create the sandbox.<br/>
    /// Default Value: [iad1, sfo1, cle1, cdg1]<br/>
    /// Example: iad1
    /// </summary>
    public enum CreateSandboxesV4RequestRegion
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
    public static class CreateSandboxesV4RequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV4RequestRegion value)
        {
            return value switch
            {
                CreateSandboxesV4RequestRegion.Cdg1 => "cdg1",
                CreateSandboxesV4RequestRegion.Cle1 => "cle1",
                CreateSandboxesV4RequestRegion.Iad1 => "iad1",
                CreateSandboxesV4RequestRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV4RequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => CreateSandboxesV4RequestRegion.Cdg1,
                "cle1" => CreateSandboxesV4RequestRegion.Cle1,
                "iad1" => CreateSandboxesV4RequestRegion.Iad1,
                "sfo1" => CreateSandboxesV4RequestRegion.Sfo1,
                _ => null,
            };
        }
    }
}