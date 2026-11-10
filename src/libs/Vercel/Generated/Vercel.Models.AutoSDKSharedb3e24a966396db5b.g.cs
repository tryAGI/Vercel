#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedb3e24a966396db5b : global::System.IEquatable<AutoSDKSharedb3e24a966396db5b>
    {
        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared6bbdd9b0474e1d24? Shared6bbdd9b0474e1d24 { get; init; }
#else
        public global::Vercel.AutoSDKShared6bbdd9b0474e1d24? Shared6bbdd9b0474e1d24 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared6bbdd9b0474e1d24))]
#endif
        public bool IsShared6bbdd9b0474e1d24 => Shared6bbdd9b0474e1d24 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared6bbdd9b0474e1d24(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared6bbdd9b0474e1d24? value)
        {
            value = Shared6bbdd9b0474e1d24;
            return IsShared6bbdd9b0474e1d24;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared6bbdd9b0474e1d24 PickShared6bbdd9b0474e1d24() => Shared6bbdd9b0474e1d24 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared6bbdd9b0474e1d24' but the value was {ToString()}.");

        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedfeb17b1223c8bf77? Sharedfeb17b1223c8bf77 { get; init; }
#else
        public global::Vercel.AutoSDKSharedfeb17b1223c8bf77? Sharedfeb17b1223c8bf77 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedfeb17b1223c8bf77))]
#endif
        public bool IsSharedfeb17b1223c8bf77 => Sharedfeb17b1223c8bf77 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedfeb17b1223c8bf77(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedfeb17b1223c8bf77? value)
        {
            value = Sharedfeb17b1223c8bf77;
            return IsSharedfeb17b1223c8bf77;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedfeb17b1223c8bf77 PickSharedfeb17b1223c8bf77() => Sharedfeb17b1223c8bf77 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedfeb17b1223c8bf77' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedb3e24a966396db5b(global::Vercel.AutoSDKShared6bbdd9b0474e1d24 value) => new AutoSDKSharedb3e24a966396db5b((global::Vercel.AutoSDKShared6bbdd9b0474e1d24?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared6bbdd9b0474e1d24?(AutoSDKSharedb3e24a966396db5b @this) => @this.Shared6bbdd9b0474e1d24;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedb3e24a966396db5b(global::Vercel.AutoSDKShared6bbdd9b0474e1d24? value)
        {
            Shared6bbdd9b0474e1d24 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedb3e24a966396db5b FromShared6bbdd9b0474e1d24(global::Vercel.AutoSDKShared6bbdd9b0474e1d24? value) => new AutoSDKSharedb3e24a966396db5b(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedb3e24a966396db5b(global::Vercel.AutoSDKSharedfeb17b1223c8bf77 value) => new AutoSDKSharedb3e24a966396db5b((global::Vercel.AutoSDKSharedfeb17b1223c8bf77?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedfeb17b1223c8bf77?(AutoSDKSharedb3e24a966396db5b @this) => @this.Sharedfeb17b1223c8bf77;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedb3e24a966396db5b(global::Vercel.AutoSDKSharedfeb17b1223c8bf77? value)
        {
            Sharedfeb17b1223c8bf77 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedb3e24a966396db5b FromSharedfeb17b1223c8bf77(global::Vercel.AutoSDKSharedfeb17b1223c8bf77? value) => new AutoSDKSharedb3e24a966396db5b(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedb3e24a966396db5b(
            global::Vercel.AutoSDKShared6bbdd9b0474e1d24? shared6bbdd9b0474e1d24,
            global::Vercel.AutoSDKSharedfeb17b1223c8bf77? sharedfeb17b1223c8bf77
            )
        {
            Shared6bbdd9b0474e1d24 = shared6bbdd9b0474e1d24;
            Sharedfeb17b1223c8bf77 = sharedfeb17b1223c8bf77;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedfeb17b1223c8bf77 as object ??
            Shared6bbdd9b0474e1d24 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared6bbdd9b0474e1d24?.ToString() ??
            Sharedfeb17b1223c8bf77?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared6bbdd9b0474e1d24 && !IsSharedfeb17b1223c8bf77 || !IsShared6bbdd9b0474e1d24 && IsSharedfeb17b1223c8bf77;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared6bbdd9b0474e1d24, TResult>? shared6bbdd9b0474e1d24 = null,
            global::System.Func<global::Vercel.AutoSDKSharedfeb17b1223c8bf77, TResult>? sharedfeb17b1223c8bf77 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared6bbdd9b0474e1d24 is { } __value0 && shared6bbdd9b0474e1d24 != null)
            {
                return shared6bbdd9b0474e1d24(__value0);
            }
            else if (Sharedfeb17b1223c8bf77 is { } __value1 && sharedfeb17b1223c8bf77 != null)
            {
                return sharedfeb17b1223c8bf77(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared6bbdd9b0474e1d24>? shared6bbdd9b0474e1d24 = null,

            global::System.Action<global::Vercel.AutoSDKSharedfeb17b1223c8bf77>? sharedfeb17b1223c8bf77 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared6bbdd9b0474e1d24 is { } __value0)
            {
                shared6bbdd9b0474e1d24?.Invoke(__value0);
            }
            else if (Sharedfeb17b1223c8bf77 is { } __value1)
            {
                sharedfeb17b1223c8bf77?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared6bbdd9b0474e1d24>? shared6bbdd9b0474e1d24 = null,
            global::System.Action<global::Vercel.AutoSDKSharedfeb17b1223c8bf77>? sharedfeb17b1223c8bf77 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared6bbdd9b0474e1d24 is { } __value0)
            {
                shared6bbdd9b0474e1d24?.Invoke(__value0);
            }
            else if (Sharedfeb17b1223c8bf77 is { } __value1)
            {
                sharedfeb17b1223c8bf77?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared6bbdd9b0474e1d24,
                typeof(global::Vercel.AutoSDKShared6bbdd9b0474e1d24),
                Sharedfeb17b1223c8bf77,
                typeof(global::Vercel.AutoSDKSharedfeb17b1223c8bf77),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AutoSDKSharedb3e24a966396db5b other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared6bbdd9b0474e1d24?>.Default.Equals(Shared6bbdd9b0474e1d24, other.Shared6bbdd9b0474e1d24) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedfeb17b1223c8bf77?>.Default.Equals(Sharedfeb17b1223c8bf77, other.Sharedfeb17b1223c8bf77)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedb3e24a966396db5b obj1, AutoSDKSharedb3e24a966396db5b obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedb3e24a966396db5b>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedb3e24a966396db5b obj1, AutoSDKSharedb3e24a966396db5b obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedb3e24a966396db5b o && Equals(o);
        }
    }
}
