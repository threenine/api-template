using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ApiProject.Content.Activities.Sample.Post
{
    public class PostSampleHandler : IRequestHandler<PostSampleCommand, Unit>
    {
        public Task<Unit> Handle(PostSampleCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}