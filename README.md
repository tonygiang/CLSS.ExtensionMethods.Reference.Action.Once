# CLSS.ExtensionMethods.Reference.Action.Once

### Problem

Registering a method that will execute only once upon invocation of an event is a common operation in the observer pattern. In languages such as JavaScript, this is done in one line by specifying an options property:

```
element.addEventListener("click", () => { ... }, { once: true });
```

In C#, it is done like this:

```
Action OnEvent = delegate { }

Action wrapperEvent = null;
wrapperEvent = () =>
{
  OnEvent -= wrapperEvent;
  // Actions that will only execute once
}
OnEvent += wrapperEvent;
```

This syntax can use some improvements so that it wouldn't take a minimum of 7 lines of code.

However, in the lack of native language support for registering a method as an one-off invocation, providing an 1-line syntax for this operation via extension methods poses some challenges. Delegates are immutable, and the `+=` & `-=` operators will in fact replace the reference on the left-hand side with a new reference. Since source argument of an extension method is always passed by value, calling `+=` on a copied reference of a delegate will only replace that copied reference while the original delegate remains unreplaced. However, passing the reference encapsuling that delegate will preserve the delegate's reference. This calls for a general-purpose encapsulating reference type to make this syntax work.

### Solution

By utilising the CLSS type [`Reference`](https://www.nuget.org/packages/CLSS.Types.Reference) - a general-purpose reference-type wrapper for a single value of any type, this package is able to provide the `Once` extension method to a delegate encapsulated in a `CLSS.Reference`. The one-off method registration syntax can now be done in as short as one line.

```
using CLSS;

Reference<Action> OnEvent = new Reference<Action>(delegate { });

OnEvent.Once(() => { ... });

// Test invocations
OnEvent.Value.Invoke(); // Registered method only executes on this invocation
OnEvent.Value.Invoke();
```

`Once` only works well as long as the encapsulated delegate is used via its encapsulating `CLSS.Reference`. Creating a `CLSS.Reference` out of a raw delegate field will not result in methods being registered to the raw delegate.

```
using CLSS;

Action RawEvent = delegate { };

// Object.ReferenceEquals(EventRef.Value, RawEvent) is still true at this line
var EventRef = new Reference<Action>(RawEvent);
EventRef.Once(MethodA); // reference replaced inside EventRef
RawEvent += MethodB; // RawEvent replaced

// Test invocations
RawEvent.Invoke(); // Does not call MethodA, will call MethodB
EventRef.Value.Invoke(); // Will call MethodA, does not call MethodB
EventRef.Value.Invoke(); // Does not call MethodA or MethodB
```

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).