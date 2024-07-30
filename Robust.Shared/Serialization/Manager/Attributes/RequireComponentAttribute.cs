using System;
using Robust.Shared.GameObjects;

namespace Robust.Shared.Serialization.Manager.Attributes;
[System.AttributeUsage(System.AttributeTargets.Class)]
public class RequireComponentAttribute : Attribute
{
    IComponent Component;
    public RequireComponentAttribute(IComponent access)
    {
        Component = access;
    }
}
