using System;

public class DeepCloneClass : CloneClass, ICloneable
{
    public object Clone()
    {
        DeepCloneClass result = new DeepCloneClass();
        result.X = this.X;
        result.Y = this.Y;
        result.Data = new DeepStructure();
        result.Data.A = this.Data.A;
        result.Data.B = this.Data.B;
        return result;
    }
}