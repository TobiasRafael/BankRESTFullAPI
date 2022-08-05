using Application.Wrappers;
using MediatR;

namespace Application.Features.Customer.Commands.CreateCustomerCommand;

public class CreateCustomerCommand : IRequest<Response<int>>
{
    private int _age;
    
    public string Name { get; set; }

    public string LastName { get; set; }

    public DateTime BirthDate { get; set; }

    public string PhoneNumber { get; set; }

    public string Address { get; set; }
}

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Response<int>>
{
    public async Task<Response<int>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
        
}