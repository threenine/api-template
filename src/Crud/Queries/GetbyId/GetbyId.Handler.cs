using AutoMapper;
using MediatR;
using Threenine.ApiResponse;
using Threenine.Data;
using Namespace.Resource.Get;
using Namespace.Data;

namespace Namespace.Activities.Resource.Queries.GetbyId;

public class Handler : IRequestHandler<Query, SingleResponse<Response>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<SingleResponse<Response>> Handle(Query request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.GetReadOnlyRepositoryAsync<Model>()
            .SingleOrDefaultAsync(predicate: x => x.Id == request.Id);
        
        return new SingleResponse<Response>(_mapper.Map<Response>(result));
    }
}
