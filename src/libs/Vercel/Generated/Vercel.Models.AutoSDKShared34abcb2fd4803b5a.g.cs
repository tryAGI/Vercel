#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared34abcb2fd4803b5a : global::System.IEquatable<AutoSDKShared34abcb2fd4803b5a>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared5f73cd821829ef28? Shared5f73cd821829ef28 { get; init; }
#else
        public global::Vercel.AutoSDKShared5f73cd821829ef28? Shared5f73cd821829ef28 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared5f73cd821829ef28))]
#endif
        public bool IsShared5f73cd821829ef28 => Shared5f73cd821829ef28 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared5f73cd821829ef28(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared5f73cd821829ef28? value)
        {
            value = Shared5f73cd821829ef28;
            return IsShared5f73cd821829ef28;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared5f73cd821829ef28 PickShared5f73cd821829ef28() => IsShared5f73cd821829ef28
            ? Shared5f73cd821829ef28!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared5f73cd821829ef28' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2? AutoSDKShared34abcb2fd4803b5aVariant2 { get; init; }
#else
        public global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2? AutoSDKShared34abcb2fd4803b5aVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared34abcb2fd4803b5aVariant2))]
#endif
        public bool IsAutoSDKShared34abcb2fd4803b5aVariant2 => AutoSDKShared34abcb2fd4803b5aVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared34abcb2fd4803b5aVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2? value)
        {
            value = AutoSDKShared34abcb2fd4803b5aVariant2;
            return IsAutoSDKShared34abcb2fd4803b5aVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2 PickAutoSDKShared34abcb2fd4803b5aVariant2() => IsAutoSDKShared34abcb2fd4803b5aVariant2
            ? AutoSDKShared34abcb2fd4803b5aVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared34abcb2fd4803b5aVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3? AutoSDKShared34abcb2fd4803b5aVariant3 { get; init; }
#else
        public global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3? AutoSDKShared34abcb2fd4803b5aVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared34abcb2fd4803b5aVariant3))]
#endif
        public bool IsAutoSDKShared34abcb2fd4803b5aVariant3 => AutoSDKShared34abcb2fd4803b5aVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared34abcb2fd4803b5aVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3? value)
        {
            value = AutoSDKShared34abcb2fd4803b5aVariant3;
            return IsAutoSDKShared34abcb2fd4803b5aVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3 PickAutoSDKShared34abcb2fd4803b5aVariant3() => IsAutoSDKShared34abcb2fd4803b5aVariant3
            ? AutoSDKShared34abcb2fd4803b5aVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared34abcb2fd4803b5aVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared34abcb2fd4803b5a(global::Vercel.AutoSDKShared5f73cd821829ef28 value) => new AutoSDKShared34abcb2fd4803b5a((global::Vercel.AutoSDKShared5f73cd821829ef28?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared5f73cd821829ef28?(AutoSDKShared34abcb2fd4803b5a @this) => @this.Shared5f73cd821829ef28;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared34abcb2fd4803b5a(global::Vercel.AutoSDKShared5f73cd821829ef28? value)
        {
            Shared5f73cd821829ef28 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared34abcb2fd4803b5a FromShared5f73cd821829ef28(global::Vercel.AutoSDKShared5f73cd821829ef28? value) => new AutoSDKShared34abcb2fd4803b5a(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared34abcb2fd4803b5a(global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2 value) => new AutoSDKShared34abcb2fd4803b5a((global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2?(AutoSDKShared34abcb2fd4803b5a @this) => @this.AutoSDKShared34abcb2fd4803b5aVariant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared34abcb2fd4803b5a(global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2? value)
        {
            AutoSDKShared34abcb2fd4803b5aVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared34abcb2fd4803b5a FromAutoSDKShared34abcb2fd4803b5aVariant2(global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2? value) => new AutoSDKShared34abcb2fd4803b5a(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared34abcb2fd4803b5a(global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3 value) => new AutoSDKShared34abcb2fd4803b5a((global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3?(AutoSDKShared34abcb2fd4803b5a @this) => @this.AutoSDKShared34abcb2fd4803b5aVariant3;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared34abcb2fd4803b5a(global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3? value)
        {
            AutoSDKShared34abcb2fd4803b5aVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared34abcb2fd4803b5a FromAutoSDKShared34abcb2fd4803b5aVariant3(global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3? value) => new AutoSDKShared34abcb2fd4803b5a(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared34abcb2fd4803b5a(
            global::Vercel.AutoSDKShared5f73cd821829ef28? shared5f73cd821829ef28,
            global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2? autoSDKShared34abcb2fd4803b5aVariant2,
            global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3? autoSDKShared34abcb2fd4803b5aVariant3
            )
        {
            Shared5f73cd821829ef28 = shared5f73cd821829ef28;
            AutoSDKShared34abcb2fd4803b5aVariant2 = autoSDKShared34abcb2fd4803b5aVariant2;
            AutoSDKShared34abcb2fd4803b5aVariant3 = autoSDKShared34abcb2fd4803b5aVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKShared34abcb2fd4803b5aVariant3 as object ??
            AutoSDKShared34abcb2fd4803b5aVariant2 as object ??
            Shared5f73cd821829ef28 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared5f73cd821829ef28?.ToString() ??
            AutoSDKShared34abcb2fd4803b5aVariant2?.ToString() ??
            AutoSDKShared34abcb2fd4803b5aVariant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared5f73cd821829ef28 && !IsAutoSDKShared34abcb2fd4803b5aVariant2 && !IsAutoSDKShared34abcb2fd4803b5aVariant3 || !IsShared5f73cd821829ef28 && IsAutoSDKShared34abcb2fd4803b5aVariant2 && !IsAutoSDKShared34abcb2fd4803b5aVariant3 || !IsShared5f73cd821829ef28 && !IsAutoSDKShared34abcb2fd4803b5aVariant2 && IsAutoSDKShared34abcb2fd4803b5aVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared5f73cd821829ef28, TResult>? shared5f73cd821829ef28 = null,
            global::System.Func<global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2, TResult>? autoSDKShared34abcb2fd4803b5aVariant2 = null,
            global::System.Func<global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3, TResult>? autoSDKShared34abcb2fd4803b5aVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared5f73cd821829ef28 && shared5f73cd821829ef28 != null)
            {
                return shared5f73cd821829ef28(Shared5f73cd821829ef28!);
            }
            else if (IsAutoSDKShared34abcb2fd4803b5aVariant2 && autoSDKShared34abcb2fd4803b5aVariant2 != null)
            {
                return autoSDKShared34abcb2fd4803b5aVariant2(AutoSDKShared34abcb2fd4803b5aVariant2!);
            }
            else if (IsAutoSDKShared34abcb2fd4803b5aVariant3 && autoSDKShared34abcb2fd4803b5aVariant3 != null)
            {
                return autoSDKShared34abcb2fd4803b5aVariant3(AutoSDKShared34abcb2fd4803b5aVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared5f73cd821829ef28>? shared5f73cd821829ef28 = null,

            global::System.Action<global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2>? autoSDKShared34abcb2fd4803b5aVariant2 = null,

            global::System.Action<global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3>? autoSDKShared34abcb2fd4803b5aVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared5f73cd821829ef28)
            {
                shared5f73cd821829ef28?.Invoke(Shared5f73cd821829ef28!);
            }
            else if (IsAutoSDKShared34abcb2fd4803b5aVariant2)
            {
                autoSDKShared34abcb2fd4803b5aVariant2?.Invoke(AutoSDKShared34abcb2fd4803b5aVariant2!);
            }
            else if (IsAutoSDKShared34abcb2fd4803b5aVariant3)
            {
                autoSDKShared34abcb2fd4803b5aVariant3?.Invoke(AutoSDKShared34abcb2fd4803b5aVariant3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared5f73cd821829ef28>? shared5f73cd821829ef28 = null,
            global::System.Action<global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2>? autoSDKShared34abcb2fd4803b5aVariant2 = null,
            global::System.Action<global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3>? autoSDKShared34abcb2fd4803b5aVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared5f73cd821829ef28)
            {
                shared5f73cd821829ef28?.Invoke(Shared5f73cd821829ef28!);
            }
            else if (IsAutoSDKShared34abcb2fd4803b5aVariant2)
            {
                autoSDKShared34abcb2fd4803b5aVariant2?.Invoke(AutoSDKShared34abcb2fd4803b5aVariant2!);
            }
            else if (IsAutoSDKShared34abcb2fd4803b5aVariant3)
            {
                autoSDKShared34abcb2fd4803b5aVariant3?.Invoke(AutoSDKShared34abcb2fd4803b5aVariant3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared5f73cd821829ef28,
                typeof(global::Vercel.AutoSDKShared5f73cd821829ef28),
                AutoSDKShared34abcb2fd4803b5aVariant2,
                typeof(global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2),
                AutoSDKShared34abcb2fd4803b5aVariant3,
                typeof(global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3),
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
        public bool Equals(AutoSDKShared34abcb2fd4803b5a other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared5f73cd821829ef28?>.Default.Equals(Shared5f73cd821829ef28, other.Shared5f73cd821829ef28) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant2?>.Default.Equals(AutoSDKShared34abcb2fd4803b5aVariant2, other.AutoSDKShared34abcb2fd4803b5aVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared34abcb2fd4803b5aVariant3?>.Default.Equals(AutoSDKShared34abcb2fd4803b5aVariant3, other.AutoSDKShared34abcb2fd4803b5aVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared34abcb2fd4803b5a obj1, AutoSDKShared34abcb2fd4803b5a obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared34abcb2fd4803b5a>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared34abcb2fd4803b5a obj1, AutoSDKShared34abcb2fd4803b5a obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared34abcb2fd4803b5a o && Equals(o);
        }
    }
}
