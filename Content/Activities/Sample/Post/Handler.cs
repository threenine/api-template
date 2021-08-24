using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ApiProject.Content.Activities.Sample.Post
{
    public class Handler : IRequestHandler<Command, Unit>
    {
        public Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}