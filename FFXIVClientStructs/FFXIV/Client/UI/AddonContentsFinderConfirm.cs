using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI;

// Client::UI::AddonContentsFinderConfirm
//   Component::GUI::AtkUnitBase
//     Component::GUI::AtkEventListener
[Addon("ContentsFinderConfirm")]
[GenerateInterop]
[Inherits<AtkUnitBase>]
[StructLayout(LayoutKind.Explicit, Size = 0x2F8)]
[VirtualTable("48 8D 05 ?? ?? ?? ?? 48 89 03 41 B0 01 33 C0 BA ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 8B CB 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 0F 11 83", 3)]
public unsafe partial struct AddonContentsFinderConfirm {
    [FieldOffset(0x238)] public AtkTextNode* AtkTextNode228;
    [FieldOffset(0x240)] public AtkTextNode* AtkTextNode230; // duty title
    [FieldOffset(0x248)] public AtkTextNode* AtkTextNode238;
    [FieldOffset(0x250)] public AtkTextNode* AtkTextNode240;
    [FieldOffset(0x258)] public AtkTextNode* AtkTextNode248;

    [FieldOffset(0x298)] public AtkComponentButton* CommenceButton;
    [FieldOffset(0x2A0)] public AtkComponentButton* WithdrawButton;
    [FieldOffset(0x2A8)] public AtkComponentButton* WaitButton;
}
