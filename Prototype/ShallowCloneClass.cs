using System;

public class ShallowCloneClass : CloneClass, ICloneable
{
    public object Clone()
    {
        return (ShallowCloneClass)this.MemberwiseClone();
    }
}