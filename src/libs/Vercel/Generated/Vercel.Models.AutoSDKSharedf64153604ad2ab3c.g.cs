#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedf64153604ad2ab3c : global::System.IEquatable<AutoSDKSharedf64153604ad2ab3c>
    {
        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared0b04f80869bc5cc2? Shared0b04f80869bc5cc2 { get; init; }
#else
        public global::Vercel.AutoSDKShared0b04f80869bc5cc2? Shared0b04f80869bc5cc2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared0b04f80869bc5cc2))]
#endif
        public bool IsShared0b04f80869bc5cc2 => Shared0b04f80869bc5cc2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared0b04f80869bc5cc2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared0b04f80869bc5cc2? value)
        {
            value = Shared0b04f80869bc5cc2;
            return IsShared0b04f80869bc5cc2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared0b04f80869bc5cc2 PickShared0b04f80869bc5cc2() => Shared0b04f80869bc5cc2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared0b04f80869bc5cc2' but the value was {ToString()}.");

        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared87d7a4edbf209283? Shared87d7a4edbf209283 { get; init; }
#else
        public global::Vercel.AutoSDKShared87d7a4edbf209283? Shared87d7a4edbf209283 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared87d7a4edbf209283))]
#endif
        public bool IsShared87d7a4edbf209283 => Shared87d7a4edbf209283 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared87d7a4edbf209283(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared87d7a4edbf209283? value)
        {
            value = Shared87d7a4edbf209283;
            return IsShared87d7a4edbf209283;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared87d7a4edbf209283 PickShared87d7a4edbf209283() => Shared87d7a4edbf209283 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared87d7a4edbf209283' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedf64153604ad2ab3c(global::Vercel.AutoSDKShared0b04f80869bc5cc2 value) => new AutoSDKSharedf64153604ad2ab3c((global::Vercel.AutoSDKShared0b04f80869bc5cc2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared0b04f80869bc5cc2?(AutoSDKSharedf64153604ad2ab3c @this) => @this.Shared0b04f80869bc5cc2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedf64153604ad2ab3c(global::Vercel.AutoSDKShared0b04f80869bc5cc2? value)
        {
            Shared0b04f80869bc5cc2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedf64153604ad2ab3c FromShared0b04f80869bc5cc2(global::Vercel.AutoSDKShared0b04f80869bc5cc2? value) => new AutoSDKSharedf64153604ad2ab3c(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedf64153604ad2ab3c(global::Vercel.AutoSDKShared87d7a4edbf209283 value) => new AutoSDKSharedf64153604ad2ab3c((global::Vercel.AutoSDKShared87d7a4edbf209283?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared87d7a4edbf209283?(AutoSDKSharedf64153604ad2ab3c @this) => @this.Shared87d7a4edbf209283;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedf64153604ad2ab3c(global::Vercel.AutoSDKShared87d7a4edbf209283? value)
        {
            Shared87d7a4edbf209283 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedf64153604ad2ab3c FromShared87d7a4edbf209283(global::Vercel.AutoSDKShared87d7a4edbf209283? value) => new AutoSDKSharedf64153604ad2ab3c(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedf64153604ad2ab3c(
            global::Vercel.AutoSDKShared0b04f80869bc5cc2? shared0b04f80869bc5cc2,
            global::Vercel.AutoSDKShared87d7a4edbf209283? shared87d7a4edbf209283
            )
        {
            Shared0b04f80869bc5cc2 = shared0b04f80869bc5cc2;
            Shared87d7a4edbf209283 = shared87d7a4edbf209283;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared87d7a4edbf209283 as object ??
            Shared0b04f80869bc5cc2 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared0b04f80869bc5cc2?.ToString() ??
            Shared87d7a4edbf209283?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared0b04f80869bc5cc2 && !IsShared87d7a4edbf209283 || !IsShared0b04f80869bc5cc2 && IsShared87d7a4edbf209283;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared0b04f80869bc5cc2, TResult>? shared0b04f80869bc5cc2 = null,
            global::System.Func<global::Vercel.AutoSDKShared87d7a4edbf209283, TResult>? shared87d7a4edbf209283 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared0b04f80869bc5cc2 is { } __value0 && shared0b04f80869bc5cc2 != null)
            {
                return shared0b04f80869bc5cc2(__value0);
            }
            else if (Shared87d7a4edbf209283 is { } __value1 && shared87d7a4edbf209283 != null)
            {
                return shared87d7a4edbf209283(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared0b04f80869bc5cc2>? shared0b04f80869bc5cc2 = null,

            global::System.Action<global::Vercel.AutoSDKShared87d7a4edbf209283>? shared87d7a4edbf209283 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared0b04f80869bc5cc2 is { } __value0)
            {
                shared0b04f80869bc5cc2?.Invoke(__value0);
            }
            else if (Shared87d7a4edbf209283 is { } __value1)
            {
                shared87d7a4edbf209283?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared0b04f80869bc5cc2>? shared0b04f80869bc5cc2 = null,
            global::System.Action<global::Vercel.AutoSDKShared87d7a4edbf209283>? shared87d7a4edbf209283 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared0b04f80869bc5cc2 is { } __value0)
            {
                shared0b04f80869bc5cc2?.Invoke(__value0);
            }
            else if (Shared87d7a4edbf209283 is { } __value1)
            {
                shared87d7a4edbf209283?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared0b04f80869bc5cc2,
                typeof(global::Vercel.AutoSDKShared0b04f80869bc5cc2),
                Shared87d7a4edbf209283,
                typeof(global::Vercel.AutoSDKShared87d7a4edbf209283),
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
        public bool Equals(AutoSDKSharedf64153604ad2ab3c other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared0b04f80869bc5cc2?>.Default.Equals(Shared0b04f80869bc5cc2, other.Shared0b04f80869bc5cc2) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared87d7a4edbf209283?>.Default.Equals(Shared87d7a4edbf209283, other.Shared87d7a4edbf209283)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedf64153604ad2ab3c obj1, AutoSDKSharedf64153604ad2ab3c obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedf64153604ad2ab3c>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedf64153604ad2ab3c obj1, AutoSDKSharedf64153604ad2ab3c obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedf64153604ad2ab3c o && Equals(o);
        }
    }
}
