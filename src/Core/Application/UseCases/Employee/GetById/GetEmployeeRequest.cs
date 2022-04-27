using MediatR;
using N5.Common.Helpers;
using System;

namespace N5.Application.UseCases.Employee.GetById
{
    public class GetEmployeeRequest : IRequest<Response<GetEmployeeResult>>
    {
        public int Id { get; set; }

        public GetEmployeeRequest(int id) 
        {
            Id = id;
        }
    }
}
