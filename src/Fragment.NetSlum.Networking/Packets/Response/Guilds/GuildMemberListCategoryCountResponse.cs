using System.Buffers.Binary;
using Fragment.NetSlum.Networking.Constants;
using Fragment.NetSlum.Networking.Objects;

namespace Fragment.NetSlum.Networking.Packets.Response.Guilds;

public class GuildMemberListCategoryCountResponse : BaseResponse
{
    private readonly ushort _numEntries;

    public GuildMemberListCategoryCountResponse(ushort numEntries)
    {
        _numEntries = numEntries;
    }

    public override FragmentMessage Build()
    {
        var buffer = new Memory<byte>(new byte[2]);
        BinaryPrimitives.WriteUInt16BigEndian(buffer.Span, _numEntries);

        return new FragmentMessage
        {
            OpCode = OpCodes.Data,
            DataPacketType = OpCodes.DataGuildMemberListCategoryCountResponse,
            Data = buffer,
        };
    }
}
