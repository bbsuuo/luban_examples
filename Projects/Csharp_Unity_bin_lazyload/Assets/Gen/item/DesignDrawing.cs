//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.item
{

public sealed partial class DesignDrawing :  item.ItemExtra 
{
    public DesignDrawing(ByteBuf _buf)  : base(_buf) 
    {
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);LearnComponentId = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); LearnComponentId.Add(_e0);}}
        PostInit();
    }

    public static DesignDrawing DeserializeDesignDrawing(ByteBuf _buf)
    {
        return new item.DesignDrawing(_buf);
    }

    public System.Collections.Generic.List<int> LearnComponentId { get; private set; }

    public const int __ID__ = -1679179579;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "LearnComponentId:" + Bright.Common.StringUtil.CollectionToString(LearnComponentId) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
