# Discord-Objects

This repository aims to provide DotNet structures to represent the various JSON objects ouput by Discord's API.

It performs no processing or conversion - its sole aim is to provide types to work with.

### The Json Namespace
The `Discord.Json` namespace in this repository provides simple JSON wrappers.
This means that most of the provided objects do not provide simple access to related complex objects, as all relations are
linked at the whim of the Discord API.

As an example, the `MemberObject` has a `ulong[] roles` property, as the Discord API never provides a member object which contains full role objects as well.

### The Descriptors Namespace
The `Discord.Descriptors` namespace in this repository intends to expand upon the Json namespace, and provides full wrappers of the Discord types:
```C#
public class MemberDescriptor
{
    public IEnumerable<RoleDescriptor> Roles { get; set; }
	...
}
```

Again, no processing or conversion is performed in this library.
