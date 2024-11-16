using MediatR;
using QMW.ERP.Messenger.Application.Core;
using QMW.ERP.Messenger.Persistence;

namespace QMW.ERP.Messenger.Application.Chats;
public class List
{
    public class Query : IRequest<Result<List<ChatDTO>>> { }

    public class Handler(MessengerContext context) : IRequestHandler<Query, Result<List<ChatDTO>>>
    {
        public async Task<Result<List<ChatDTO>>> Handle(Query request, CancellationToken token)
        {
            //var chats = await context.Chats
            throw new NotImplementedException();
        }
    }
}
