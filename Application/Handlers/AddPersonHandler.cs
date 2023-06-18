using MediatR;
using Persistence;

namespace Application;

public class AddPersonHandler : IRequestHandler<AddPersonCommand>
{
    private readonly IDataAccess data;
    public AddPersonHandler(IDataAccess data)
    {
        this.data = data;
    }
	public Task Handle(AddPersonCommand request, CancellationToken cancellationToken)
	{
        return Task.FromResult(data.AddPerson(request.Person));
	}
}
