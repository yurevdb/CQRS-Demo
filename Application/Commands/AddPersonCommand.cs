using Domain;
using MediatR;

namespace Application;

public record AddPersonCommand(Person Person): IRequest;
