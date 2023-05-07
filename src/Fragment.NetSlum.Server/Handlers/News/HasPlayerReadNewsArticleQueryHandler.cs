using Fragment.NetSlum.Core.CommandBus.Contracts.Queries;
using Fragment.NetSlum.Networking.Queries.News;
using Fragment.NetSlum.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Fragment.NetSlum.Server.Handlers.News;

public class HasPlayerReadNewsArticleQueryHandler : IQueryHandler<HasPlayerReadNewsArticle, bool>
{
    private readonly FragmentContext _database;

    public HasPlayerReadNewsArticleQueryHandler(FragmentContext database)
    {
        _database = database;
    }

    public Task<bool> Handle(HasPlayerReadNewsArticle command, CancellationToken cancellationToken)
    {
        return _database.WebNewsReadLogs.AnyAsync(
            wnl => wnl.PlayerAccountId == command.PlayerId && wnl.WebNewsArticleId == command.ArticleId,
            cancellationToken: cancellationToken);
    }
}
