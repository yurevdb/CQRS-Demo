using Domain;
using MediatR;

namespace Application;

public record GetPeopleQuery() : IRequest<IEnumerable<Person>>;
