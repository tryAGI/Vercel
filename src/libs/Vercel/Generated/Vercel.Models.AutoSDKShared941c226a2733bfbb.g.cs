#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared941c226a2733bfbb : global::System.IEquatable<AutoSDKShared941c226a2733bfbb>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared92580a598ccc210f? Shared92580a598ccc210f { get; init; }
#else
        public global::Vercel.AutoSDKShared92580a598ccc210f? Shared92580a598ccc210f { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared92580a598ccc210f))]
#endif
        public bool IsShared92580a598ccc210f => Shared92580a598ccc210f != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared92580a598ccc210f(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared92580a598ccc210f? value)
        {
            value = Shared92580a598ccc210f;
            return IsShared92580a598ccc210f;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared92580a598ccc210f PickShared92580a598ccc210f() => Shared92580a598ccc210f is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared92580a598ccc210f' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared2bfc0b0e9e85f636? Shared2bfc0b0e9e85f636 { get; init; }
#else
        public global::Vercel.AutoSDKShared2bfc0b0e9e85f636? Shared2bfc0b0e9e85f636 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared2bfc0b0e9e85f636))]
#endif
        public bool IsShared2bfc0b0e9e85f636 => Shared2bfc0b0e9e85f636 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared2bfc0b0e9e85f636(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared2bfc0b0e9e85f636? value)
        {
            value = Shared2bfc0b0e9e85f636;
            return IsShared2bfc0b0e9e85f636;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared2bfc0b0e9e85f636 PickShared2bfc0b0e9e85f636() => Shared2bfc0b0e9e85f636 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared2bfc0b0e9e85f636' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared941c226a2733bfbb(global::Vercel.AutoSDKShared92580a598ccc210f value) => new AutoSDKShared941c226a2733bfbb((global::Vercel.AutoSDKShared92580a598ccc210f?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared92580a598ccc210f?(AutoSDKShared941c226a2733bfbb @this) => @this.Shared92580a598ccc210f;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared941c226a2733bfbb(global::Vercel.AutoSDKShared92580a598ccc210f? value)
        {
            Shared92580a598ccc210f = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared941c226a2733bfbb FromShared92580a598ccc210f(global::Vercel.AutoSDKShared92580a598ccc210f? value) => new AutoSDKShared941c226a2733bfbb(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared941c226a2733bfbb(global::Vercel.AutoSDKShared2bfc0b0e9e85f636 value) => new AutoSDKShared941c226a2733bfbb((global::Vercel.AutoSDKShared2bfc0b0e9e85f636?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared2bfc0b0e9e85f636?(AutoSDKShared941c226a2733bfbb @this) => @this.Shared2bfc0b0e9e85f636;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared941c226a2733bfbb(global::Vercel.AutoSDKShared2bfc0b0e9e85f636? value)
        {
            Shared2bfc0b0e9e85f636 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared941c226a2733bfbb FromShared2bfc0b0e9e85f636(global::Vercel.AutoSDKShared2bfc0b0e9e85f636? value) => new AutoSDKShared941c226a2733bfbb(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared941c226a2733bfbb(
            global::Vercel.AutoSDKShared92580a598ccc210f? shared92580a598ccc210f,
            global::Vercel.AutoSDKShared2bfc0b0e9e85f636? shared2bfc0b0e9e85f636
            )
        {
            Shared92580a598ccc210f = shared92580a598ccc210f;
            Shared2bfc0b0e9e85f636 = shared2bfc0b0e9e85f636;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared2bfc0b0e9e85f636 as object ??
            Shared92580a598ccc210f as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared92580a598ccc210f?.ToString() ??
            Shared2bfc0b0e9e85f636?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared92580a598ccc210f && !IsShared2bfc0b0e9e85f636 || !IsShared92580a598ccc210f && IsShared2bfc0b0e9e85f636;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared92580a598ccc210f, TResult>? shared92580a598ccc210f = null,
            global::System.Func<global::Vercel.AutoSDKShared2bfc0b0e9e85f636, TResult>? shared2bfc0b0e9e85f636 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared92580a598ccc210f is { } __value0 && shared92580a598ccc210f != null)
            {
                return shared92580a598ccc210f(__value0);
            }
            else if (Shared2bfc0b0e9e85f636 is { } __value1 && shared2bfc0b0e9e85f636 != null)
            {
                return shared2bfc0b0e9e85f636(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared92580a598ccc210f>? shared92580a598ccc210f = null,

            global::System.Action<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>? shared2bfc0b0e9e85f636 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared92580a598ccc210f is { } __value0)
            {
                shared92580a598ccc210f?.Invoke(__value0);
            }
            else if (Shared2bfc0b0e9e85f636 is { } __value1)
            {
                shared2bfc0b0e9e85f636?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared92580a598ccc210f>? shared92580a598ccc210f = null,
            global::System.Action<global::Vercel.AutoSDKShared2bfc0b0e9e85f636>? shared2bfc0b0e9e85f636 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared92580a598ccc210f is { } __value0)
            {
                shared92580a598ccc210f?.Invoke(__value0);
            }
            else if (Shared2bfc0b0e9e85f636 is { } __value1)
            {
                shared2bfc0b0e9e85f636?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared92580a598ccc210f,
                typeof(global::Vercel.AutoSDKShared92580a598ccc210f),
                Shared2bfc0b0e9e85f636,
                typeof(global::Vercel.AutoSDKShared2bfc0b0e9e85f636),
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
        public bool Equals(AutoSDKShared941c226a2733bfbb other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared92580a598ccc210f?>.Default.Equals(Shared92580a598ccc210f, other.Shared92580a598ccc210f) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared2bfc0b0e9e85f636?>.Default.Equals(Shared2bfc0b0e9e85f636, other.Shared2bfc0b0e9e85f636)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared941c226a2733bfbb obj1, AutoSDKShared941c226a2733bfbb obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared941c226a2733bfbb>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared941c226a2733bfbb obj1, AutoSDKShared941c226a2733bfbb obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared941c226a2733bfbb o && Equals(o);
        }
    }
}
