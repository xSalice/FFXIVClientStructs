using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI.Arrays;

[CExportIgnore]
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 8 * 4)]
public unsafe partial struct BlackListNumberArrayArray {
    public static BlackListNumberArrayArray* Instance() => (BlackListNumberArrayArray*)AtkStage.Instance()->GetNumberArrayData(NumberArrayType.BlackList)->IntArray;

    [FieldOffset(0), FixedSizeArray, CExportIgnore] internal FixedSizeArray8<int> _data;

    [FieldOffset(0)] public int BlackListCount;
}
