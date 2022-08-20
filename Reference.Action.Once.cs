// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class ReferenceActionOnce
  {
    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action> Once(this Reference<Action> source,
      Action listener)
    {
      Action wrapperAction = null;
      wrapperAction = () =>
      {
        source.Value -= wrapperAction;
        listener();
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1>> Once<T1>(
      this Reference<Action<T1>> source,
      Action<T1> listener)
    {
      Action<T1> wrapperAction = null;
      wrapperAction = (arg1) =>
      {
        source.Value -= wrapperAction;
        listener(arg1);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2>> Once<T1, T2>(
      this Reference<Action<T1, T2>> source,
      Action<T1, T2> listener)
    {
      Action<T1, T2> wrapperAction = null;
      wrapperAction = (arg1,
        arg2) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3>> Once<T1, T2, T3>(
      this Reference<Action<T1, T2, T3>> source,
      Action<T1, T2, T3> listener)
    {
      Action<T1, T2, T3> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4>> Once<T1, T2, T3, T4>(
      this Reference<Action<T1, T2, T3, T4>> source,
      Action<T1, T2, T3, T4> listener)
    {
      Action<T1, T2, T3, T4> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5>> Once<T1, T2, T3, T4, T5>(
      this Reference<Action<T1, T2, T3, T4, T5>> source,
      Action<T1, T2, T3, T4, T5> listener)
    {
      Action<T1, T2, T3, T4, T5> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5, T6>> Once<T1, T2, T3, T4, T5, T6>(
      this Reference<Action<T1, T2, T3, T4, T5, T6>> source,
      Action<T1, T2, T3, T4, T5, T6> listener)
    {
      Action<T1, T2, T3, T4, T5, T6> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5, T6, T7>> Once<T1, T2, T3, T4, T5, T6, T7>(
      this Reference<Action<T1, T2, T3, T4, T5, T6, T7>> source,
      Action<T1, T2, T3, T4, T5, T6, T7> listener)
    {
      Action<T1, T2, T3, T4, T5, T6, T7> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6,
          arg7);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8>> Once<T1, T2, T3, T4, T5, T6, T7, T8>(
      this Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8>> source,
      Action<T1, T2, T3, T4, T5, T6, T7, T8> listener)
    {
      Action<T1, T2, T3, T4, T5, T6, T7, T8> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6,
          arg7,
          arg8);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
      this Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> source,
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> listener)
    {
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6,
          arg7,
          arg8,
          arg9);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
      this Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> source,
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> listener)
    {
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6,
          arg7,
          arg8,
          arg9,
          arg10);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
      this Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> source,
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> listener)
    {
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6,
          arg7,
          arg8,
          arg9,
          arg10,
          arg11);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
      this Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> source,
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> listener)
    {
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6,
          arg7,
          arg8,
          arg9,
          arg10,
          arg11,
          arg12);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
      this Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> source,
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> listener)
    {
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6,
          arg7,
          arg8,
          arg9,
          arg10,
          arg11,
          arg12,
          arg13);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
      this Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> source,
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> listener)
    {
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13,
        arg14) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6,
          arg7,
          arg8,
          arg9,
          arg10,
          arg11,
          arg12,
          arg13,
          arg14);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <inheritdoc cref="Once{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(Reference{Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16})"/>
    public static Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
      this Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> source,
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> listener)
    {
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13,
        arg14,
        arg15) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6,
          arg7,
          arg8,
          arg9,
          arg10,
          arg11,
          arg12,
          arg13,
          arg14,
          arg15);
      };
      source.Value += wrapperAction;
      return source;
    }

    /// <summary>
    /// Registers a specified method to be executed only once on the source's
    /// referenced delegate.
    /// </summary>
    /// <typeparam name="T1">The type of the first parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T2">The type of the second parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T3">The type of the third parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T4">The type of the fourth parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T5">The type of the fifth parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T6">The type of the sixth parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T7">The type of the seventh parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T8">The type of the eighth parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T9">The type of the ninth parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T10">The type of the tenth parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T11">The type of the eleventh parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T12">The type of the twelfth parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T13">The type of the thirteenth parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T14">The type of the fourteenth parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T15">The type of the fifteenth parameter of the method
    /// that will be registered.</typeparam>
    /// <typeparam name="T16">The type of the sixteenth parameter of the method
    /// that will be registered.</typeparam>
    /// <param name="source">The source encapsulated delegate.</param>
    /// <param name="listener">The method that will execute only once upon
    /// registering.</param>
    /// <returns>The source encapsulated delegate.</returns>
    public static Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
      this Reference<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> source,
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> listener)
    {
      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> wrapperAction = null;
      wrapperAction = (arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13,
        arg14,
        arg15,
        arg16) =>
      {
        source.Value -= wrapperAction;
        listener(arg1,
          arg2,
          arg3,
          arg4,
          arg5,
          arg6,
          arg7,
          arg8,
          arg9,
          arg10,
          arg11,
          arg12,
          arg13,
          arg14,
          arg15,
          arg16);
      };
      source.Value += wrapperAction;
      return source;
    }
  }
}