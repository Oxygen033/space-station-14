// © SS220, An EULA/CLA with a hosting restriction, full text: https://raw.githubusercontent.com/SerbiaStrong-220/space-station-14/master/CLA.txt

using Content.Shared.Atmos;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.SS220.DebugGasSpawner.Components;

[RegisterComponent, NetworkedComponent]
public sealed partial class DebugGasSpawnerComponent : Component
{
    public Gas Gas = Gas.Oxygen;

    [ViewVariables(VVAccess.ReadWrite)]
    public float Moles = 10f;

    [ViewVariables(VVAccess.ReadWrite)]
    public float Temperature = 293.15f;

    [Serializable, NetSerializable]
    public enum DebugGasSpawnerUiKey
    {
        Key,
    }

    [Serializable, NetSerializable]
    public sealed class DebugGasSpawnerUserMessage : BoundUserInterfaceMessage
    {

    }
}
