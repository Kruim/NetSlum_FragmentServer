using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Fragment.NetSlum.Networking.Attributes;
using Fragment.NetSlum.Networking.Constants;
using Fragment.NetSlum.Networking.Objects;
using Fragment.NetSlum.Networking.Packets.Response.Mail;
using Fragment.NetSlum.Networking.Sessions;
using OpCodes = Fragment.NetSlum.Networking.Constants.OpCodes;

namespace Fragment.NetSlum.Networking.Packets.Request.Mail;

[FragmentPacket(MessageType.Data, OpCodes.DataGuildMailSend)]
public class SendGuildMailRequest : BaseRequest
{
    public override Task<ICollection<FragmentMessage>> GetResponse(FragmentTcpSession session, FragmentMessage request)
    {
        return SingleMessage(new SendMailResponse().SetStatusCode(OpCodes.DataGuildMailSendOk).Build());
    }
}