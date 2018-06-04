# C# Singleton Class

[![](https://raw.githubusercontent.com/pixel-cookers/built-with-badges/master/nuget/nuget-long.png)](https://www.nuget.org/packages/AF.DesignPatterns.Singleton)

A generic base class allowing you to efficiently handle the single-instance creation and initialization. Turn any type into a singleton by extending the `Singleton` class.

Due to the tradeoffs associated with creating a generic singleton base class, it is not possible to set your constructor to private in the class that inherits from it. Therefore it will not be a true singleton but will allow for other flexibility advantages such as unit testing. It is left to the developer to uphold the integrity of the pattern.

## Getting Started

Suppose you have an instance called `BusinessLogicClass`:

```csharp
public class BusinessLogicClass {
  public void DoSomeLogic() {
    // ...
  }
}
```

### Singleton

Now we want to treat our `BusinessLogicClass` class like a singleton. Simply make it inherit from `Singleton` as follows:

```csharp
public class BusinessLogicClass : Singleton<BusinessLogicClass> {
  public void DoSomeLogic() {
    // ...
  }
}
```

Now you will be able to call `BusinessLogicClass.Instance.DoSomeLogic();` as a single instance. 

### Singleton with interface 

You also have the ability to specify an interface that your type must implement:

```csharp
public class BusinessLogicClass : Singleton<BusinessLogicClass, IBizInterface>, IBizInterface {
  public void DoSomeLogic() {
    // ...
  }
}
```
