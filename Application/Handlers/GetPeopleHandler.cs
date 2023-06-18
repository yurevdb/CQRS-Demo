using Domain;
using MediatR;
using Persistence;

namespace Application;

public class GetPeopleHandler : IRequestHandler<GetPeopleQuery, IEnumerable<Person>>
{
    private readonly IDataAccess data;
    public GetPeopleHandler(IDataAccess data)
    {
        this.data = data;
    }

    public Task<IEnumerable<Person>> Handle(GetPeopleQuery request, CancellationToken cancellationToken)
    {
        return data.GetPeople();
    }
}
