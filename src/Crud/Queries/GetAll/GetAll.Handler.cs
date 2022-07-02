using AutoMapper;
using MediatR;
using Threenine.ApiResponse;
using Threenine.Data;

namespace  Namespace.Resource.Queries.GetAll;

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
        var results = await _unitOfWork.GetReadOnlyRepositoryAsync<Model>()
            .GetListAsync(x => x.Active == true, size: Int32.MaxValue);
        
        return new SingleResponse<Response>(new Response { DTO = _mapper.Map<List<DTO>>(results.Items)});
    }
}
