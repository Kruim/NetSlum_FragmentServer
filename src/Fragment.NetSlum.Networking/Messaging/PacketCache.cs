using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using Fragment.NetSlum.Networking.Attributes;
using Fragment.NetSlum.Networking.Constants;
using Fragment.NetSlum.Networking.Objects;

namespace Fragment.NetSlum.Networking.Messaging;

public class PacketCache
{
    private readonly Dictionary<OpCodes, Dictionary<OpCodes, Type>> _packetReferences = new();

    public void AddRequest(FragmentPacket msg, Type t)
    {
        EnsureCreated(msg);

        if (_packetReferences[msg.OpCode].TryGetValue(msg.DataPacketType, out var existingType))
        {
            throw new InvalidConstraintException(
                $"Attempted to add packet {t.Name} when existing reference already exists. ({existingType.Name})");
        }

        _packetReferences[msg.OpCode][msg.DataPacketType] = t;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.AggressiveInlining)]
    public Type? GetRequest(FragmentMessage o)
    {
        var opCode = o.OpCode;
        var dataPacketType = o.DataPacketType;

        if (!_packetReferences.ContainsKey(opCode))
        {
            return null;
        }

        return !_packetReferences[opCode].ContainsKey(dataPacketType) ? null : _packetReferences[opCode][dataPacketType];
    }

    private void EnsureCreated(FragmentPacket msg)
    {
        if (!_packetReferences.ContainsKey(msg.OpCode))
        {
            _packetReferences[msg.OpCode] = new Dictionary<OpCodes, Type>();
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder("=== Registered Packets ===");
        sb.AppendLine();

        foreach (var (type, classes) in _packetReferences)
        {
            sb.AppendLine($"{type} ({((byte)type):X2})");
            foreach (var (cls, pTypes) in classes)
            {
                sb.AppendLine($"  Type: {cls} -> {pTypes}");
            }
        }

        return sb.ToString();
    }
}
